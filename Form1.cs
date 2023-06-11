using Examsystem.Models;

namespace Examsystem
{
    public partial class StartingPoint : Form
    {
        public StartingPoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Student student = Login.studentLogin(textBoxUsername.Text, textBoxPassword.Text);
            if (student != null)
            {
                this.Visible = false;
                StudentForm form = new StudentForm(student);
                form.Visible = true;
            }
            else
            {
                MessageBox.Show("May be there is a wrong in username or password");
            }
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher(Login.teacherLogin(textBoxUsername.Text, textBoxPassword.Text));
            if (teacher != null)
            {
                this.Visible = false;
                TeacherForm form = new TeacherForm(teacher);
                form.Visible = true;
            }
            else
            {
                MessageBox.Show("May be there is a wrong in username or password");
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            SignUpForm form = new SignUpForm();
            form.Visible = true;
        }

        private void StartingPoint_Load(object sender, EventArgs e)
        {

        }
    }
}