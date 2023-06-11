using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public abstract class SignUp
    {
        protected int createUser(string userName, string password,string name, char gender)
        {
            if (signUpValidation(userName, password))
            {
                Account user = new Account(name,userName,password,gender);
                ExamDb db = new ExamDb();
                db.Add(user);
                db.SaveChanges();
                return user.Id;
            }
            else
            {
                return -1;
            }
        }
        protected bool signUpValidation(string userName, string password)
        {
            ExamDb db = new ExamDb();
            var user=db.accounts.Where(a=>a.userName==userName&&a.password==password).ToList();
            return user.Count == 0;
        }
        public abstract bool signUpOperation(string username,string password,string name,char gender,object additionalInfo);
    }
}
