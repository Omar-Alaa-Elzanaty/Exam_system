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
        public bool createExam(int numberOfQuestions,int grade,int durationInMinute,List<Question>questions)
        {
            Exam exam = new Exam(numberOfQuestions,this.id,grade,durationInMinute,questions);
            try
            {
                ExamDb.db.Add(exam);
                ExamDb.db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void deleteExam(int examId)
        {
            Exam exam = ExamDb.db.exams.Find(examId);
            var questions = ExamDb.db.questions.Where(q => q.examId == examId).ToList();
            if (questions != null)
            {
                ExamDb.db.questions.RemoveRange(questions);
            }
            if (exam != null)
            {
                ExamDb.db.exams.Remove(exam);
            }
            ExamDb.db.SaveChanges();
        }
        public object showStudentsResultsOfLevel(int level)
        {
            var resultOfStudent=ExamDb.db.results.Include(i=>i.student.account);
            return resultOfStudent.Where(r=>r.student.level==level).Select(k=>new {k.student.account.name,k.result });
        }
    }
}
