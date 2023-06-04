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
        public virtual Teacher teacher { get; set; }
        public virtual Student student { get; set; }
        public Account(int id) { }
    }
}
