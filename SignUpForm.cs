using Examsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examsystem
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void buttonStudentSignUp_Click(object sender, EventArgs e)
        {
            StudentSignUp studentSignUp = new StudentSignUp();
            bool valid = studentSignUp.signUpOperation(textBoxUsername.Text,
                                          textBoxPassword.Text,
                                          textBoxName.Text,
                                          Convert.ToChar(textBoxGender.Text.ToString())
                                          , int.Parse(textBoxAdd.Text));
            if (valid)
            {
                MessageBox.Show("SignUp successfully");
                this.Close();
                StartingPoint startingPoint = new StartingPoint();
                startingPoint.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed Successfully");
            }
        }

        private void buttonTeacherSignUp_Click(object sender, EventArgs e)
        {
            TeacherSignUp teacherSignUp = new TeacherSignUp();
            bool valid = teacherSignUp.signUpOperation(textBoxUsername.Text,
                                          textBoxPassword.Text,
                                          textBoxName.Text,
                                          Convert.ToChar(textBoxGender.Text.ToString())
                                          , textBoxAdd.Text.ToString());
            if (valid)
            {
                MessageBox.Show("SignUp successfully");
                this.Close();
                StartingPoint startingPoint = new StartingPoint();
                startingPoint.Visible = true;
            }
            else
            {
                MessageBox.Show("Failed Successfully");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // this.Visible = false;
            this.Close();
            StartingPoint startingPoint = new StartingPoint();
            startingPoint.Visible = true;

        }
    }
}
