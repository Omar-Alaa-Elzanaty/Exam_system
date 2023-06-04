using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public Student(int aacount) : this() { }
    }
}
