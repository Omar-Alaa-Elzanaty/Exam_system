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
        public List<Exam> showAvaliableExams()
        {
            throw new NotImplementedException();
        }
        public void takeExam(Exam exam)
        {
            throw new NotSupportedException();
        }
        public Dictionary<string,int> showExamsResults()
        {
            throw new NotImplementedException ();
        }
    }
}
