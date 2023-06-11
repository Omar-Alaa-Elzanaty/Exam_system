namespace Examsystem
{
    partial class SignUpForm
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
            buttonTeacherSignUp = new Button();
            buttonStudentSignUp = new Button();
            textBoxAdd = new TextBox();
            textBoxGender = new TextBox();
            textBoxName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            SuspendLayout();
            // 
            // buttonTeacherSignUp
            // 
            buttonTeacherSignUp.Anchor = AnchorStyles.Bottom;
            buttonTeacherSignUp.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTeacherSignUp.Location = new Point(531, 391);
            buttonTeacherSignUp.Name = "buttonTeacherSignUp";
            buttonTeacherSignUp.Size = new Size(266, 52);
            buttonTeacherSignUp.TabIndex = 13;
            buttonTeacherSignUp.Text = "Signup as Teacher";
            buttonTeacherSignUp.UseVisualStyleBackColor = true;
            buttonTeacherSignUp.Click += buttonTeacherSignUp_Click;
            // 
            // buttonStudentSignUp
            // 
            buttonStudentSignUp.Anchor = AnchorStyles.Bottom;
            buttonStudentSignUp.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStudentSignUp.Location = new Point(133, 391);
            buttonStudentSignUp.Name = "buttonStudentSignUp";
            buttonStudentSignUp.Size = new Size(266, 52);
            buttonStudentSignUp.TabIndex = 12;
            buttonStudentSignUp.Text = "Signup as Student";
            buttonStudentSignUp.UseVisualStyleBackColor = true;
            buttonStudentSignUp.Click += buttonStudentSignUp_Click;
            // 
            // textBoxAdd
            // 
            textBoxAdd.Anchor = AnchorStyles.Top;
            textBoxAdd.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxAdd.Location = new Point(309, 322);
            textBoxAdd.Name = "textBoxAdd";
            textBoxAdd.Size = new Size(330, 39);
            textBoxAdd.TabIndex = 11;
            textBoxAdd.Text = "Additional Info";
            textBoxAdd.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxGender
            // 
            textBoxGender.Anchor = AnchorStyles.Top;
            textBoxGender.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxGender.Location = new Point(309, 248);
            textBoxGender.Name = "textBoxGender";
            textBoxGender.Size = new Size(330, 39);
            textBoxGender.TabIndex = 10;
            textBoxGender.Text = "Gender";
            textBoxGender.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Top;
            textBoxName.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.Location = new Point(309, 191);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(330, 39);
            textBoxName.TabIndex = 9;
            textBoxName.Text = "Name";
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(309, 119);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(330, 39);
            textBoxPassword.TabIndex = 8;
            textBoxPassword.Text = "Password";
            textBoxPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top;
            textBoxUsername.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(309, 41);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(330, 39);
            textBoxUsername.TabIndex = 7;
            textBoxUsername.Text = "Username";
            textBoxUsername.TextAlign = HorizontalAlignment.Center;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(930, 485);
            Controls.Add(buttonTeacherSignUp);
            Controls.Add(buttonStudentSignUp);
            Controls.Add(textBoxAdd);
            Controls.Add(textBoxGender);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTeacherSignUp;
        private Button buttonStudentSignUp;
        private TextBox textBoxAdd;
        private TextBox textBoxGender;
        private TextBox textBoxName;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
    }
}