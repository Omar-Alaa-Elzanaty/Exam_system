using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class Question
    {
        public int questionId { get; set; }
        public string question { get; set; }
        public string answer { get; set; }
        public string choicA { get; set; }
        public string choicB { get; set; }
        public string choicC { get; set; }
        public string choicD { get; set; }
        public int? examId { get; set; }
        public virtual Exam exam { get; set; }
        public bool checkAsnwer(string answer)
        {
            throw new NotImplementedException();
        }
    }
}
