using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public abstract class TeacherServices
    {
        protected int id;
        public TeacherServices() { }
        public TeacherServices(int teacherId)
        {
            id= teacherId;
        }
        public bool createExam(int grade,int durationInMinute,List<Question>questions)
        {
            Exam exam = new Exam(this.id,grade,durationInMinute,questions);
            ExamDb db = new ExamDb();
            try
            {
                db.Add(exam);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void deleteExam(int examId)
        {
            ExamDb db = new ExamDb();
            Exam exam = db.exams.Find(examId);
            var questions = db.questions.Where(q => q.examId == examId).ToList();
            var results=db.results.Where(r=>r.examId==examId).ToList();
            if (questions != null)
            {
                db.questions.RemoveRange(questions);
            }
            if (results != null)
            {
                db.results.RemoveRange(results);
            }
            
            if (exam != null)
            {
                db.exams.Remove(exam);
            }
            db.SaveChanges();
        }
        public object showExams()
        {
            ExamDb db= new ExamDb();
            return db.exams.Where(e => e.teacherId == id).ToArray();
        }
        public object showStudentsResultsOfLevel(int level)
        {
            ExamDb db = new ExamDb();
            var resultOfStudent=db.results.Include(i=>i.student.account).Include(i=>i.exam);
            return resultOfStudent.Where(r=>r.student.level==level&&r.exam.teacherId==id).Select(k=>new {k.student.account.name,k.result }).ToArray()??null;
        }
    }
}
