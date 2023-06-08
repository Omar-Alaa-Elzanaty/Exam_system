using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examsystem.Models
{
    public class Student:StudentServices
    {
        public int studentId { get; set; }
        public int level { get; set; }
        public int? accId { get; set; }
        public virtual Account account { get; set; }
        public virtual List<Result> results { get; set; }
        public Student()
        {
            base.studentId = studentId;
        }
        public Student(int accountId) : this() {
            Student person = ExamDb.db.students.Find(accountId);
            if (person != null)
            {
                level = person.level;
            }
        }
    }
}
