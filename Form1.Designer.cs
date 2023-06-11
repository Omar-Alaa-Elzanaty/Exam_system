namespace Examsystem
{
    partial class StartingPoint
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStudent = new Button();
            label1 = new Label();
            buttonSignUpStudent = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label2 = new Label();
            buttonTeacher = new Button();
            SuspendLayout();
            // 
            // buttonStudent
            // 
            buttonStudent.Anchor = AnchorStyles.Bottom;
            buttonStudent.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudent.ForeColor = Color.DarkRed;
            buttonStudent.ImageAlign = ContentAlignment.BottomCenter;
            buttonStudent.Location = new Point(172, 371);
            buttonStudent.Name = "buttonStudent";
            buttonStudent.Size = new Size(314, 83);
            buttonStudent.TabIndex = 0;
            buttonStudent.Text = "Login as Student";
            buttonStudent.UseVisualStyleBackColor = true;
            buttonStudent.Click += buttonLogin_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(311, 569);
            label1.Name = "label1";
            label1.Size = new Size(175, 29);
            label1.TabIndex = 1;
            label1.Text = "Has no account ?";
            // 
            // buttonSignUpStudent
            // 
            buttonSignUpStudent.Anchor = AnchorStyles.Bottom;
            buttonSignUpStudent.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUpStudent.ForeColor = Color.DarkRed;
            buttonSignUpStudent.ImageAlign = ContentAlignment.BottomCenter;
            buttonSignUpStudent.Location = new Point(528, 554);
            buttonSignUpStudent.Name = "buttonSignUpStudent";
            buttonSignUpStudent.Size = new Size(249, 57);
            buttonSignUpStudent.TabIndex = 2;
            buttonSignUpStudent.Text = "Signup as Student";
            buttonSignUpStudent.UseVisualStyleBackColor = true;
            buttonSignUpStudent.Click += buttonSignUp_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(342, 283);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(404, 39);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.Text = "Password";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            textBoxPassword.UseWaitCursor = true;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxUsername.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(342, 191);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(404, 39);
            textBoxUsername.TabIndex = 4;
            textBoxUsername.Text = "Username";
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            textBoxUsername.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 48F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(342, 40);
            label2.Name = "label2";
            label2.Size = new Size(435, 72);
            label2.TabIndex = 5;
            label2.Text = "Exams System";
            // 
            // buttonTeacher
            // 
            buttonTeacher.Anchor = AnchorStyles.Bottom;
            buttonTeacher.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeacher.ForeColor = Color.DarkRed;
            buttonTeacher.ImageAlign = ContentAlignment.BottomCenter;
            buttonTeacher.Location = new Point(616, 371);
            buttonTeacher.Name = "buttonTeacher";
            buttonTeacher.Size = new Size(314, 83);
            buttonTeacher.TabIndex = 6;
            buttonTeacher.Text = "Login as Teacher";
            buttonTeacher.UseVisualStyleBackColor = true;
            buttonTeacher.Click += buttonTeacher_Click;
            // 
            // StartingPoint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.NavajoWhite;
            ClientSize = new Size(1132, 627);
            Controls.Add(buttonTeacher);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(buttonSignUpStudent);
            Controls.Add(label1);
            Controls.Add(buttonStudent);
            Name = "StartingPoint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EnteringUser";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStudent;
        private Label label1;
        private Button buttonSignUpStudent;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label2;
        private Button buttonTeacher;
    }
}