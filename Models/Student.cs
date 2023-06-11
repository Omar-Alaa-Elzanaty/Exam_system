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
            base.id = studentId;
        }
        public Student(Student input) {
            this.id = input.studentId;
            this.studentId = input.studentId;
            this.level = input.level;
            this.accId = input.accId;
            this.account = input.account;
            this.results = input.results;
        }
    }
}
