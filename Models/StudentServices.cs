using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public abstract class StudentServices
    {
        protected int studentId;
        public List<Exam> showAvaliableExams(int level)
        {
            return ExamDb.db.exams.Where(e => e.grade == level).ToList();
        }
        public void takeExam(int examId,double result)
        {
            Result studentResult=new Result() { examId = examId, result = result };
            ExamDb.db.Add(studentResult);
            ExamDb.db.SaveChanges();
        }
        public object showExamsResults()
        {
            var Examresults = ExamDb.db.results.Include(r => r.exam.teacher).Include(r=>r.student);
            return Examresults.Where(r => r.sId == r.student.studentId && r.exam.teacherId == r.exam.teacher.teacherId)
                              .Select(r => new { r.exam.teacher.subject, r.result }).ToList();
        }
    }
}
