using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class Teacher:TeacherServices
    {
        public int teacherId { get; set; }
        public string subject { get; set; }
        public int? accId { get; set; }
        public virtual Account account { get; set; }
        public virtual List<Exam> exams { get; set; }
        public Teacher()
        {
            base.id = teacherId;
        }
        public Teacher(Teacher input)
        {
            base.id=input.teacherId;
            teacherId = input.teacherId;
            subject = input.subject;
            accId = input.accId;
            account = input.account;
            exams = input.exams;
        }
        public Teacher(int accountId):this()
        {
            ExamDb db = new ExamDb();
            Teacher person = db.teachers.Find(accountId);
            if(person != null)
            {
                subject = person.subject;
            }
        }
        
    }
}
