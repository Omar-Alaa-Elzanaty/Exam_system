using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public static class Login
    {
        static Account createAccount(string userName,string password)
        {
            return ExamDb.db.accounts.Where(acc=>acc.userName==userName).FirstOrDefault();
        }
        public static Teacher teacherLogin(string userName,string password)
        {
            Account user=createAccount(userName,password);
            if (user != null)
            {
                ExamDb.db.Entry(user).Reference(u => u.teacher).Load();
            }
            return user.teacher;
        }
        public static Student studentLogin(string userName,string password) 
        {
            Account user=createAccount(userName,password);
            if(user != null)
            {
                ExamDb.db.Entry(user).Reference(u => u.student).Load();
            }
            return user.student;
        }
    }
}
