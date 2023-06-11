using Microsoft.EntityFrameworkCore;
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
            ExamDb db = new ExamDb();
            return db.accounts.Include(a=>a.student).Include(a=>a.teacher).Where(acc=>acc.userName==userName&&acc.password==password).FirstOrDefault();
        }
        public static Teacher teacherLogin(string userName,string password)
        {
            Account user=createAccount(userName,password);
            return user?.teacher??null;
        }
        public static Student studentLogin(string userName,string password) 
        {
            Account user=createAccount(userName,password);
            return user?.student??null;
        }
    }
}
