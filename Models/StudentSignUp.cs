using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    public class StudentSignUp : SignUp
    {
        protected override bool signUpOperation(string username, string password, string name, char gender, object additionalInfo)
        {
            throw new NotImplementedException();
        }
    }
}
