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
        public int teacherId { get; set; }
        public virtual Teacher teacher { get; set; }    
        public virtual List<Question> questions { get; set; }
        public virtual List<Result> results { get; set; }
        public Exam() { }
        public Exam(int questionsnumber,int teacherId,int grade,int duration,List<Question> questions) {
            this.teacherId=teacherId;
            this.grade=grade;
            this.durationInMinute=duration;
            this.questions = questions;
            ExamDb.db.Add(this);
        }
    }
}
