namespace BasicLoginApplication.Custom_Controls {
    partial class SignUpPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelInvalidEmail = new System.Windows.Forms.Label();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.textBoxCuePassword2 = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.textBoxCuePassword1 = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.textBoxCueUsername = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.textBoxCueEmail = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.labelUsernameTaken = new System.Windows.Forms.Label();
            this.labelInvalidPassword = new System.Windows.Forms.Label();
            this.labelPasswordDoesNotMatch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignUp.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUp.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSignUp.Location = new System.Drawing.Point(92, 14);
            this.labelSignUp.Margin = new System.Windows.Forms.Padding(100, 30, 100, 0);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(172, 51);
            this.labelSignUp.TabIndex = 1;
            this.labelSignUp.Text = "SIGN UP";
            this.labelSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInvalidEmail
            // 
            this.labelInvalidEmail.AutoSize = true;
            this.labelInvalidEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalidEmail.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidEmail.ForeColor = System.Drawing.Color.Firebrick;
            this.labelInvalidEmail.Location = new System.Drawing.Point(88, 65);
            this.labelInvalidEmail.Margin = new System.Windows.Forms.Padding(0);
            this.labelInvalidEmail.Name = "labelInvalidEmail";
            this.labelInvalidEmail.Size = new System.Drawing.Size(105, 12);
            this.labelInvalidEmail.TabIndex = 5;
            this.labelInvalidEmail.Text = "Please enter a valid email";
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.checkBoxShowPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(180)))));
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPassword.Location = new System.Drawing.Point(231, 180);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(41, 15);
            this.checkBoxShowPassword.TabIndex = 9;
            this.checkBoxShowPassword.Text = "Show";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.checkBoxShowPassword_CheckedChanged);
            // 
            // textBoxCuePassword2
            // 
            this.textBoxCuePassword2.Cue = "Reenter Password";
            this.textBoxCuePassword2.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCuePassword2.Location = new System.Drawing.Point(90, 218);
            this.textBoxCuePassword2.Margin = new System.Windows.Forms.Padding(92, 15, 92, 0);
            this.textBoxCuePassword2.Name = "textBoxCuePassword2";
            this.textBoxCuePassword2.Size = new System.Drawing.Size(182, 31);
            this.textBoxCuePassword2.TabIndex = 8;
            this.textBoxCuePassword2.TextChanged += new System.EventHandler(this.textBoxCuePassword2_TextChanged);
            this.textBoxCuePassword2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCuePassword2_MouseDown);
            // 
            // textBoxCuePassword1
            // 
            this.textBoxCuePassword1.Cue = "Password";
            this.textBoxCuePassword1.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCuePassword1.Location = new System.Drawing.Point(90, 172);
            this.textBoxCuePassword1.Margin = new System.Windows.Forms.Padding(92, 15, 92, 0);
            this.textBoxCuePassword1.Name = "textBoxCuePassword1";
            this.textBoxCuePassword1.PasswordChar = '●';
            this.textBoxCuePassword1.Size = new System.Drawing.Size(135, 31);
            this.textBoxCuePassword1.TabIndex = 7;
            this.textBoxCuePassword1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCuePassword1_MouseDown);
            // 
            // textBoxCueUsername
            // 
            this.textBoxCueUsername.Cue = "Username";
            this.textBoxCueUsername.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCueUsername.Location = new System.Drawing.Point(90, 126);
            this.textBoxCueUsername.Margin = new System.Windows.Forms.Padding(92, 15, 92, 0);
            this.textBoxCueUsername.Name = "textBoxCueUsername";
            this.textBoxCueUsername.Size = new System.Drawing.Size(182, 31);
            this.textBoxCueUsername.TabIndex = 6;
            this.textBoxCueUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCueUsername_MouseDown);
            // 
            // textBoxCueEmail
            // 
            this.textBoxCueEmail.Cue = "Email";
            this.textBoxCueEmail.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCueEmail.Location = new System.Drawing.Point(90, 80);
            this.textBoxCueEmail.Margin = new System.Windows.Forms.Padding(92, 15, 92, 0);
            this.textBoxCueEmail.Name = "textBoxCueEmail";
            this.textBoxCueEmail.Size = new System.Drawing.Size(182, 31);
            this.textBoxCueEmail.TabIndex = 2;
            this.textBoxCueEmail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCueEmail_MouseDown);
            // 
            // labelUsernameTaken
            // 
            this.labelUsernameTaken.AutoSize = true;
            this.labelUsernameTaken.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameTaken.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameTaken.ForeColor = System.Drawing.Color.Firebrick;
            this.labelUsernameTaken.Location = new System.Drawing.Point(88, 111);
            this.labelUsernameTaken.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsernameTaken.Name = "labelUsernameTaken";
            this.labelUsernameTaken.Size = new System.Drawing.Size(71, 12);
            this.labelUsernameTaken.TabIndex = 10;
            this.labelUsernameTaken.Text = "Username Taken";
            // 
            // labelInvalidPassword
            // 
            this.labelInvalidPassword.AutoSize = true;
            this.labelInvalidPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalidPassword.Font = new System.Drawing.Font("Segoe UI", 5.55F);
            this.labelInvalidPassword.ForeColor = System.Drawing.Color.Firebrick;
            this.labelInvalidPassword.Location = new System.Drawing.Point(88, 157);
            this.labelInvalidPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelInvalidPassword.Name = "labelInvalidPassword";
            this.labelInvalidPassword.Size = new System.Drawing.Size(223, 11);
            this.labelInvalidPassword.TabIndex = 11;
            this.labelInvalidPassword.Text = "Must have upper and lower case, a number, and 8 characters";
            // 
            // labelPasswordDoesNotMatch
            // 
            this.labelPasswordDoesNotMatch.AutoSize = true;
            this.labelPasswordDoesNotMatch.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordDoesNotMatch.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordDoesNotMatch.ForeColor = System.Drawing.Color.Firebrick;
            this.labelPasswordDoesNotMatch.Location = new System.Drawing.Point(88, 203);
            this.labelPasswordDoesNotMatch.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordDoesNotMatch.Name = "labelPasswordDoesNotMatch";
            this.labelPasswordDoesNotMatch.Size = new System.Drawing.Size(101, 12);
            this.labelPasswordDoesNotMatch.TabIndex = 12;
            this.labelPasswordDoesNotMatch.Text = "Passwords do not match";
            // 
            // SignUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelPasswordDoesNotMatch);
            this.Controls.Add(this.labelInvalidPassword);
            this.Controls.Add(this.labelUsernameTaken);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.textBoxCuePassword2);
            this.Controls.Add(this.textBoxCuePassword1);
            this.Controls.Add(this.textBoxCueUsername);
            this.Controls.Add(this.labelInvalidEmail);
            this.Controls.Add(this.textBoxCueEmail);
            this.Controls.Add(this.labelSignUp);
            this.Name = "SignUpPanel";
            this.Size = new System.Drawing.Size(364, 285);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUp;
        private TextBoxCue textBoxCueEmail;
        private System.Windows.Forms.Label labelInvalidEmail;
        private TextBoxCue textBoxCueUsername;
        private TextBoxCue textBoxCuePassword1;
        private TextBoxCue textBoxCuePassword2;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelUsernameTaken;
        private System.Windows.Forms.Label labelInvalidPassword;
        private System.Windows.Forms.Label labelPasswordDoesNotMatch;
    }
}
