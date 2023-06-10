using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public char gender { get; set; }
        public virtual Teacher? teacher { get; set; }
        public virtual Student? student { get; set; }
        public Account() { }
        public Account(int id) {
            ExamDb db= new ExamDb();
            Account user=db.accounts.Where(a=>a.Id==id).FirstOrDefault();
            if (user != null)
            {
                name = user.name;
                userName=user.userName;
                gender = user.gender;
                password = user.password;
            }
        }

        public Account(string name, string userName, string password, char gender)
        {
            this.name = name;
            this.userName = userName;
            this.password = password;
            this.gender = gender;
        }
    }
}
