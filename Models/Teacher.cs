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
        public Teacher(int accountId):this()
        {
            throw new NotImplementedException();
        }
        
    }
}
