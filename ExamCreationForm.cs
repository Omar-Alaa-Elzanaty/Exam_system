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
    public partial class ExamCreationForm : Form
    {
        Teacher teacher;
        List<Question> questionList = new List<Question>();
        public ExamCreationForm(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = new Teacher(teacher);
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            comboBox2.Items.Add(1);
            comboBox2.Items.Add(2);
            comboBox2.Items.Add(3);
            comboBox2.Items.Add(4);
            comboBox2.Items.Add(5);
        }

        private void ExamCreationForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            questionList.Add(new Question()
            {
                question = textBoxQuestion.Text,
                choicA = textBoxA.Text,
                choicB = textBoxB.Text,
                choicC = textBoxC.Text,
                choicD = textBoxD.Text,
                answer = comboBox1.SelectedItem.ToString()
            });
            MessageBox.Show("Question added successfully");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (teacher.createExam(int.Parse(comboBox2.SelectedItem.ToString()), int.Parse(textBoxDuration.Text), questionList) == true)
            {
                MessageBox.Show("saved");
            }
            else
            {
                MessageBox.Show("Sorry but there is a problem during save the exam");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TeacherForm teacherForm = new TeacherForm(teacher);
            teacherForm.Visible = true; ;
        }
    }
}
