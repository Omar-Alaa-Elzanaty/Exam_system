namespace Examsystem
{
    partial class TeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            buttonResultOfStudent = new Button();
            buttonShowExam = new Button();
            comboBox1 = new ComboBox();
            buttonExamCreation = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(76, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1199, 374);
            dataGridView1.TabIndex = 0;
            // 
            // buttonResultOfStudent
            // 
            buttonResultOfStudent.Anchor = AnchorStyles.Left;
            buttonResultOfStudent.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonResultOfStudent.Location = new Point(270, 415);
            buttonResultOfStudent.Name = "buttonResultOfStudent";
            buttonResultOfStudent.Size = new Size(322, 55);
            buttonResultOfStudent.TabIndex = 1;
            buttonResultOfStudent.Text = "Result of students";
            buttonResultOfStudent.UseVisualStyleBackColor = true;
            buttonResultOfStudent.Click += buttonResultOfStudent_Click;
            // 
            // buttonShowExam
            // 
            buttonShowExam.Anchor = AnchorStyles.Right;
            buttonShowExam.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShowExam.Location = new Point(852, 424);
            buttonShowExam.Name = "buttonShowExam";
            buttonShowExam.Size = new Size(303, 46);
            buttonShowExam.TabIndex = 2;
            buttonShowExam.Text = "Show your exams";
            buttonShowExam.UseVisualStyleBackColor = true;
            buttonShowExam.Click += buttonShowExam_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(55, 424);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 45);
            comboBox1.TabIndex = 3;
            // 
            // buttonExamCreation
            // 
            buttonExamCreation.Anchor = AnchorStyles.Bottom;
            buttonExamCreation.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExamCreation.Location = new Point(512, 564);
            buttonExamCreation.Name = "buttonExamCreation";
            buttonExamCreation.Size = new Size(228, 62);
            buttonExamCreation.TabIndex = 4;
            buttonExamCreation.Text = "Create Exam";
            buttonExamCreation.UseVisualStyleBackColor = true;
            buttonExamCreation.Click += buttonExamCreation_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1408, 655);
            Controls.Add(buttonExamCreation);
            Controls.Add(comboBox1);
            Controls.Add(buttonShowExam);
            Controls.Add(buttonResultOfStudent);
            Controls.Add(dataGridView1);
            Name = "TeacherForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TeacherForm";
            WindowState = FormWindowState.Maximized;
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonResultOfStudent;
        private Button buttonShowExam;
        private ComboBox comboBox1;
        private Button buttonExamCreation;
    }
}