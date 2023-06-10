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
    public partial class StudentForm : Form
    {
        Student student;
        double result;
        public StudentForm(Student student)
        {
            this.student = student;
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.student.showExamsResults();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.student.showAvaliableExams(student.level);
        }

        private void SelectedExam_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            ExamForm form=new ExamForm(student,x);
            form.Visible = true;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
