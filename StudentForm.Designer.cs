namespace Examsystem
{
    partial class StudentForm
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            SelectedExam = new Button();
            textBox1 = new TextBox();
            buttonback = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(155, 376);
            button1.Name = "button1";
            button1.Size = new Size(334, 61);
            button1.TabIndex = 0;
            button1.Text = "Show exams results";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(109, 43);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridView1.Size = new Size(871, 310);
            dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Right;
            button2.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(625, 376);
            button2.Name = "button2";
            button2.Size = new Size(355, 61);
            button2.TabIndex = 2;
            button2.Text = "Show available exams";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SelectedExam
            // 
            SelectedExam.Anchor = AnchorStyles.Bottom;
            SelectedExam.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedExam.Location = new Point(365, 491);
            SelectedExam.Name = "SelectedExam";
            SelectedExam.Size = new Size(299, 61);
            SelectedExam.TabIndex = 3;
            SelectedExam.Text = "Take selected Exam";
            SelectedExam.UseVisualStyleBackColor = true;
            SelectedExam.Click += SelectedExam_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Bottom;
            textBox1.Font = new Font("Calibri", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(25, 506);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 37);
            textBox1.TabIndex = 4;
            textBox1.Text = "Enter Exam ID";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonback
            // 
            buttonback.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonback.Location = new Point(885, 491);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(170, 52);
            buttonback.TabIndex = 5;
            buttonback.Text = "Logout";
            buttonback.UseVisualStyleBackColor = true;
            buttonback.Click += buttonback_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1082, 564);
            Controls.Add(buttonback);
            Controls.Add(textBox1);
            Controls.Add(SelectedExam);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "StudentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentForm";
            WindowState = FormWindowState.Maximized;
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button SelectedExam;
        private TextBox textBox1;
        private Button buttonback;
    }
}