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
    public partial class TeacherForm : Form
    {
        Teacher teacher;
        public TeacherForm(Teacher teacher)
        {
            InitializeComponent();
            this.teacher = new Teacher(teacher);
            comboBox1.Items.Add(1);
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonResultOfStudent_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teacher.showStudentsResultsOfLevel(int.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void buttonShowExam_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = teacher.showExams();
            dataGridView1.Columns["teacher"].Visible = false;
            dataGridView1.Columns["teacherId"].Visible = false;
        }

        private void buttonExamCreation_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ExamCreationForm form = new ExamCreationForm(teacher);
            form.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            teacher.deleteExam(int.Parse(textBoxExamDeleted.Text));
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            StartingPoint startingPoint = new StartingPoint();
            startingPoint.Visible = true;
        }
    }
}
