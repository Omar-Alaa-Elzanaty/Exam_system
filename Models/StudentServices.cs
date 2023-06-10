using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
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
        public object showAvaliableExams(int level)
        {
            ExamDb db= new ExamDb();
            var examAndSubject = db.exams.Include(e => e.teacher).Where(e => e.grade == level);
            var resultOfStudent = db.results.Where(r => r.sId != studentId);
            var availableExams = (from i in examAndSubject
                                  from j in resultOfStudent
                                  where i.examId == j.examId
                                  select new { i.examId, i.teacher.subject, i.durationInMinute }).ToArray();
            return availableExams;
        }
        public void takeExam(int examId,double result)
        {
            Result studentResult = new Result() { examId = examId, result = result };
            ExamDb.db.Add(studentResult);
            ExamDb.db.SaveChanges();
        }
        public object showExamsResults()
        {
            var Examresults = ExamDb.db.results.Include(r => r.exam.teacher).Include(r=>r.student);
            return Examresults.Where(r => r.sId == r.student.studentId && r.exam.teacherId == r.exam.teacher.teacherId)
                              .Select(r => new { r.exam.teacher.subject, r.result }).ToArray();
        }
    }
}
