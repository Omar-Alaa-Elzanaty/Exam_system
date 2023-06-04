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
            throw new NotImplementedException();
        }
        protected bool signUpValidation(string userName, string password)
        {
            throw new NotImplementedException();
        }
        protected abstract bool signUpOperation(string username,string password,string name,char gender,object additionalInfo);
    }
}
