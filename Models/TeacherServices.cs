using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public abstract class TeacherServices
    {
        protected int id;
        public TeacherServices() { }
        public TeacherServices(int teacherId)
        {
            id= teacherId;
        }
        public bool createExam(int numberOfQuestions)
        {
            throw new NotImplementedException();
        }
        public void deleteExam(int examId)
        {
            throw new NotImplementedException();
        }
        public List<Result>showStudentsResultsOfLevel(int level)
        {
            throw new NotImplementedException();
        }
    }
}
