namespace Examsystem
{
    partial class ExamCreationForm
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
            button2 = new Button();
            label1 = new Label();
            textBoxQuestion = new TextBox();
            textBoxA = new TextBox();
            textBoxD = new TextBox();
            textBoxC = new TextBox();
            textBoxB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBoxDuration = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(667, 383);
            button1.Name = "button1";
            button1.Size = new Size(369, 58);
            button1.TabIndex = 0;
            button1.Text = "Add Question";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(667, 454);
            button2.Name = "button2";
            button2.Size = new Size(369, 58);
            button2.TabIndex = 1;
            button2.Text = "Save Exam";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(57, 32);
            label1.Name = "label1";
            label1.Size = new Size(128, 37);
            label1.TabIndex = 2;
            label1.Text = "Question";
            // 
            // textBoxQuestion
            // 
            textBoxQuestion.Location = new Point(317, 46);
            textBoxQuestion.Name = "textBoxQuestion";
            textBoxQuestion.Size = new Size(661, 23);
            textBoxQuestion.TabIndex = 3;
            textBoxQuestion.TextChanged += textBox1_TextChanged;
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(317, 109);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(661, 23);
            textBoxA.TabIndex = 4;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(317, 323);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(661, 23);
            textBoxD.TabIndex = 5;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(317, 246);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(661, 23);
            textBoxC.TabIndex = 6;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(317, 172);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(661, 23);
            textBoxB.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(57, 98);
            label2.Name = "label2";
            label2.Size = new Size(123, 32);
            label2.TabIndex = 8;
            label2.Text = "Choice A :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(57, 161);
            label3.Name = "label3";
            label3.Size = new Size(122, 32);
            label3.TabIndex = 9;
            label3.Text = "Choice B :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(57, 235);
            label4.Name = "label4";
            label4.Size = new Size(122, 32);
            label4.TabIndex = 10;
            label4.Text = "Choice C :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(57, 312);
            label5.Name = "label5";
            label5.Size = new Size(124, 32);
            label5.TabIndex = 11;
            label5.Text = "Choice D :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(317, 392);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(57, 383);
            label6.Name = "label6";
            label6.Size = new Size(107, 32);
            label6.TabIndex = 13;
            label6.Text = "Answer :";
            // 
            // textBoxDuration
            // 
            textBoxDuration.Anchor = AnchorStyles.Bottom;
            textBoxDuration.Location = new Point(380, 546);
            textBoxDuration.Name = "textBoxDuration";
            textBoxDuration.Size = new Size(129, 23);
            textBoxDuration.TabIndex = 15;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(57, 481);
            label7.Name = "label7";
            label7.Size = new Size(82, 32);
            label7.TabIndex = 16;
            label7.Text = "Grade";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Blue;
            label8.Location = new Point(57, 537);
            label8.Name = "label8";
            label8.Size = new Size(245, 32);
            label8.TabIndex = 17;
            label8.Text = "Duration in Minutes";
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Bottom;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(380, 481);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(129, 23);
            comboBox2.TabIndex = 18;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(667, 524);
            button3.Name = "button3";
            button3.Size = new Size(369, 53);
            button3.TabIndex = 19;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ExamCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1091, 589);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxDuration);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxB);
            Controls.Add(textBoxC);
            Controls.Add(textBoxD);
            Controls.Add(textBoxA);
            Controls.Add(textBoxQuestion);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ExamCreationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExamCreationForm";
            WindowState = FormWindowState.Maximized;
            Load += ExamCreationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox textBoxQuestion;
        private TextBox textBoxA;
        private TextBox textBoxD;
        private TextBox textBoxC;
        private TextBox textBoxB;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Label label6;
        private TextBox textBoxDuration;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private Button button3;
    }
}