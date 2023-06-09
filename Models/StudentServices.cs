﻿using Microsoft.EntityFrameworkCore;
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
        protected int id;
        public object showAvaliableExams(int level)
        {
            ExamDb db= new ExamDb();
            var AvilableExams = (from e in db.exams
                        join t in db.teachers on e.teacherId equals t.teacherId
                        where  db.results.Where(r=>r.examId==e.examId&&r.sId==id).Count()==0&&e.grade==level
                        select new
                        {
                            e.examId,
                            t.subject,
                            e.durationInMinute,
                        }).ToArray();
            return AvilableExams;
        }
        public void takeExam(int examId,double result)
        {
            ExamDb db = new ExamDb();
            Result studentResult = new Result() {sId=id, examId = examId, result = result };
           db.Add(studentResult);
           db.SaveChanges();
        }
        public object showExamsResults()
        {
            ExamDb db = new ExamDb();
            var Examresults = db.results.Include(r => r.exam.teacher).Include(r=>r.student);
            return Examresults.Where(r => r.sId == r.student.studentId && r.exam.teacherId == r.exam.teacher.teacherId)
                              .Select(r => new { r.exam.teacher.subject, r.result }).ToArray();
        }
    }
}
