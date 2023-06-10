namespace Examsystem
{
    partial class ExamForm
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
            label2 = new Label();
            numberOfQuestion = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.FromArgb(128, 255, 128);
            dataGridView1.Location = new Point(12, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1257, 533);
            dataGridView1.TabIndex = 0;
            dataGridView1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(452, 569);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 2;
            label2.Text = "Choice";
            label2.UseWaitCursor = true;
            // 
            // numberOfQuestion
            // 
            numberOfQuestion.Anchor = AnchorStyles.Bottom;
            numberOfQuestion.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            numberOfQuestion.Location = new Point(277, 569);
            numberOfQuestion.Name = "numberOfQuestion";
            numberOfQuestion.Size = new Size(114, 39);
            numberOfQuestion.TabIndex = 3;
            numberOfQuestion.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 569);
            label1.Name = "label1";
            label1.Size = new Size(264, 37);
            label1.TabIndex = 1;
            label1.Text = "Number of question";
            label1.UseWaitCursor = true;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Bottom;
            comboBox1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(558, 563);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(150, 48);
            comboBox1.TabIndex = 4;
            comboBox1.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(766, 562);
            button1.Name = "button1";
            button1.Size = new Size(210, 48);
            button1.TabIndex = 5;
            button1.Text = "Save answer";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(1091, 563);
            button2.Name = "button2";
            button2.Size = new Size(178, 48);
            button2.TabIndex = 6;
            button2.Text = "End Exam";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1281, 658);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(numberOfQuestion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamForm";
            UseWaitCursor = true;
            WindowState = FormWindowState.Maximized;
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private TextBox numberOfQuestion;
        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
    }
}