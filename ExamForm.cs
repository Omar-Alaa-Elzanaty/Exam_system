using Examsystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examsystem
{
    public partial class ExamForm : Form
    {
        int exam;
        Student student;
        Dictionary<int, string> studentAnswers = new Dictionary<int, string>();
        public ExamForm(Student student, int examId)
        {
            InitializeComponent();
            this.exam = examId;
            this.student = student;
            comboBox1.Items.Add("A");
            comboBox1.Items.Add("B");
            comboBox1.Items.Add("C");
            comboBox1.Items.Add("D");
            ExamDb db = new ExamDb();
            dataGridView1.DataSource = db.questions.Where(q => q.examId == examId).ToArray();
            dataGridView1.Columns["answer"].Visible = false;
            dataGridView1.Columns["examId"].Visible = false;
            dataGridView1.Columns["exam"].Visible = false;
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentAnswers.TryAdd(int.Parse(numberOfQuestion.Text), comboBox1.SelectedItem.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExamDb db = new ExamDb();
            var questions = db.questions;
            double result = 0;
            foreach (var answer in studentAnswers)
            {
                var question = questions.Where(q => q.questionId == answer.Key).FirstOrDefault();
                if (question.checkAsnwer(answer.Value) == true)
                {
                    result++;
                }
            }
            result = result / questions.Count();
            student.takeExam(exam, result);
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentForm studentForm = new StudentForm(student);
            studentForm.Visible = false;
        }
    }
}
