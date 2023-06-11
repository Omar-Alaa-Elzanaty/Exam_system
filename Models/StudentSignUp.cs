using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class StudentSignUp : SignUp
    {
        public override bool signUpOperation(string userName, string password, string name, char gender, object additionalInfo)
        {
            int id = base.createUser(userName, password, name, gender);
            if (id == -1)
            {
                return false;
            }
            else
            {
                Student student= new Student();
                student.accId = id;
                student.level = (int)additionalInfo;
                ExamDb db = new ExamDb();
                db.Add(student);
                db.SaveChanges();
                return true;
            }
        }
    }
}
