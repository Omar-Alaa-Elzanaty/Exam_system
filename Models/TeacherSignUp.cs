﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examsystem.Models
{
    internal class TeacherSignUp : SignUp
    {
        protected override bool signUpOperation(string userName, string password, string name, char gender, object additionalInfo)
        {
            int id = base.createUser(userName, password, name, gender);
            if (id == -1)
            {
                return false;
            }
            else
            {
                Teacher teacher = new Teacher();
                teacher.accId = id;
                teacher.subject = additionalInfo.ToString();
                ExamDb.db.Add(teacher);
                ExamDb.db.SaveChanges();
                return true;
            }
        }
    }
}
