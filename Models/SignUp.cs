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
                ExamDb.db.Add(user);
                ExamDb.db.SaveChanges();
                return user.Id;
            }
            else
            {
                return -1;
            }
        }
        protected bool signUpValidation(string userName, string password)
        {
           var user=ExamDb.db.accounts.Select(a=>a.userName==userName&&a.password==password).ToList();
            return user != null && user.Count == 1;
        }
        public abstract bool signUpOperation(string username,string password,string name,char gender,object additionalInfo);
    }
}
