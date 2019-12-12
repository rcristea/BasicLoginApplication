namespace BasicLoginApplication.Custom_Controls {
    partial class SignInPanel {
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
            this.labelSignIn = new System.Windows.Forms.Label();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.labelUsernameInvalid = new System.Windows.Forms.Label();
            this.labelPasswordInvalid = new System.Windows.Forms.Label();
            this.textBoxCuePassword = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.textBoxCueUsername = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.SuspendLayout();
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSignIn.Location = new System.Drawing.Point(150, 35);
            this.labelSignIn.Margin = new System.Windows.Forms.Padding(150, 46, 150, 0);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(242, 74);
            this.labelSignIn.TabIndex = 0;
            this.labelSignIn.Text = "SIGN IN";
            this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.checkBoxRememberMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(180)))));
            this.checkBoxRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(130, 269);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(4, 15, 4, 5);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(159, 32);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalid.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalid.ForeColor = System.Drawing.Color.Firebrick;
            this.labelInvalid.Location = new System.Drawing.Point(128, 114);
            this.labelInvalid.Margin = new System.Windows.Forms.Padding(0);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(188, 17);
            this.labelInvalid.TabIndex = 4;
            this.labelInvalid.Text = "Invalid username or password!";
            // 
            // labelUsernameInvalid
            // 
            this.labelUsernameInvalid.AutoSize = true;
            this.labelUsernameInvalid.BackColor = System.Drawing.Color.Transparent;
            this.labelUsernameInvalid.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameInvalid.ForeColor = System.Drawing.Color.Firebrick;
            this.labelUsernameInvalid.Location = new System.Drawing.Point(128, 181);
            this.labelUsernameInvalid.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsernameInvalid.Name = "labelUsernameInvalid";
            this.labelUsernameInvalid.Size = new System.Drawing.Size(203, 17);
            this.labelUsernameInvalid.TabIndex = 5;
            this.labelUsernameInvalid.Text = "Username must be alphanumeric.";
            // 
            // labelPasswordInvalid
            // 
            this.labelPasswordInvalid.AutoSize = true;
            this.labelPasswordInvalid.BackColor = System.Drawing.Color.Transparent;
            this.labelPasswordInvalid.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordInvalid.ForeColor = System.Drawing.Color.Firebrick;
            this.labelPasswordInvalid.Location = new System.Drawing.Point(127, 250);
            this.labelPasswordInvalid.Margin = new System.Windows.Forms.Padding(0);
            this.labelPasswordInvalid.Name = "labelPasswordInvalid";
            this.labelPasswordInvalid.Size = new System.Drawing.Size(337, 17);
            this.labelPasswordInvalid.TabIndex = 6;
            this.labelPasswordInvalid.Text = "Must contain a capital letter, a number, and 8 characters";
            // 
            // textBoxCuePassword
            // 
            this.textBoxCuePassword.Cue = "●●●●●●●●";
            this.textBoxCuePassword.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCuePassword.Location = new System.Drawing.Point(130, 202);
            this.textBoxCuePassword.Margin = new System.Windows.Forms.Padding(142, 15, 142, 5);
            this.textBoxCuePassword.Name = "textBoxCuePassword";
            this.textBoxCuePassword.PasswordChar = '●';
            this.textBoxCuePassword.Size = new System.Drawing.Size(271, 43);
            this.textBoxCuePassword.TabIndex = 2;
            this.textBoxCuePassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCuePassword_MouseDown);
            // 
            // textBoxCueUsername
            // 
            this.textBoxCueUsername.Cue = "Username";
            this.textBoxCueUsername.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCueUsername.Location = new System.Drawing.Point(130, 134);
            this.textBoxCueUsername.Margin = new System.Windows.Forms.Padding(142, 31, 142, 5);
            this.textBoxCueUsername.Name = "textBoxCueUsername";
            this.textBoxCueUsername.Size = new System.Drawing.Size(271, 43);
            this.textBoxCueUsername.TabIndex = 1;
            this.textBoxCueUsername.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBoxCueUsername_MouseDown);
            // 
            // SignInPanel
            // 
            this.AccessibleDescription = "7";
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelPasswordInvalid);
            this.Controls.Add(this.labelUsernameInvalid);
            this.Controls.Add(this.labelInvalid);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.textBoxCuePassword);
            this.Controls.Add(this.textBoxCueUsername);
            this.Controls.Add(this.labelSignIn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SignInPanel";
            this.Size = new System.Drawing.Size(546, 349);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignIn;
        private TextBoxCue textBoxCueUsername;
        private TextBoxCue textBoxCuePassword;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelInvalid;
        private System.Windows.Forms.Label labelUsernameInvalid;
        private System.Windows.Forms.Label labelPasswordInvalid;
    }
}
