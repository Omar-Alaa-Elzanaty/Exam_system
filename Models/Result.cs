using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class Result
    {
        public int sId { get; set; }
        public virtual Student student { get; set; }
        public int examId { get; set; }
        public virtual Exam exam { get; set; }
        public double result { get; set; }
        public bool updateStudentResult()
        {
            throw new NotImplementedException();
        }
    }
}
