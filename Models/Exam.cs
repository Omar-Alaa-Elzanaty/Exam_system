using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class Exam
    {
        public int examId { get; set; }
        public int grade { get; set; }
        public int durationInMinute { get; set; }
        public int? teacherId { get; set; }
        public virtual Teacher teacher { get; set; }
        public virtual List<Question> questions { get; set; }
        public virtual List<Result> results { get; set; }
        public Exam() { }
        public Exam(int questionsnumber,int teacherId) {
            throw new NotImplementedException();
        }
        public double runningExam() { throw new NotImplementedException(); }
    }
}
