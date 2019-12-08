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
            this.textBoxCueUsername = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.textBoxCuePassword = new BasicLoginApplication.Custom_Controls.TextBoxCue();
            this.checkBoxRememberMe = new System.Windows.Forms.CheckBox();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignIn
            // 
            this.labelSignIn.AutoSize = true;
            this.labelSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignIn.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignIn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSignIn.Location = new System.Drawing.Point(100, 30);
            this.labelSignIn.Margin = new System.Windows.Forms.Padding(100, 30, 100, 0);
            this.labelSignIn.Name = "labelSignIn";
            this.labelSignIn.Size = new System.Drawing.Size(164, 51);
            this.labelSignIn.TabIndex = 0;
            this.labelSignIn.Text = "SIGN IN";
            this.labelSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCueUsername
            // 
            this.textBoxCueUsername.Cue = "Username";
            this.textBoxCueUsername.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCueUsername.Location = new System.Drawing.Point(87, 87);
            this.textBoxCueUsername.Margin = new System.Windows.Forms.Padding(95, 20, 95, 3);
            this.textBoxCueUsername.Name = "textBoxCueUsername";
            this.textBoxCueUsername.Size = new System.Drawing.Size(182, 31);
            this.textBoxCueUsername.TabIndex = 1;
            // 
            // textBoxCuePassword
            // 
            this.textBoxCuePassword.Cue = "●●●●●●●●";
            this.textBoxCuePassword.Font = new System.Drawing.Font("Segoe UI", 13.25F);
            this.textBoxCuePassword.Location = new System.Drawing.Point(87, 131);
            this.textBoxCuePassword.Margin = new System.Windows.Forms.Padding(95, 10, 95, 3);
            this.textBoxCuePassword.Name = "textBoxCuePassword";
            this.textBoxCuePassword.PasswordChar = '●';
            this.textBoxCuePassword.Size = new System.Drawing.Size(182, 31);
            this.textBoxCuePassword.TabIndex = 2;
            // 
            // checkBoxRememberMe
            // 
            this.checkBoxRememberMe.AutoSize = true;
            this.checkBoxRememberMe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.checkBoxRememberMe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(144)))), ((int)(((byte)(180)))));
            this.checkBoxRememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRememberMe.Location = new System.Drawing.Point(87, 175);
            this.checkBoxRememberMe.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.checkBoxRememberMe.Name = "checkBoxRememberMe";
            this.checkBoxRememberMe.Size = new System.Drawing.Size(110, 21);
            this.checkBoxRememberMe.TabIndex = 3;
            this.checkBoxRememberMe.Text = "Remember me";
            this.checkBoxRememberMe.UseVisualStyleBackColor = true;
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.Font = new System.Drawing.Font("Segoe UI", 6.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalid.ForeColor = System.Drawing.Color.Firebrick;
            this.labelInvalid.Location = new System.Drawing.Point(85, 74);
            this.labelInvalid.Margin = new System.Windows.Forms.Padding(0);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(125, 12);
            this.labelInvalid.TabIndex = 4;
            this.labelInvalid.Text = "Invalid username or password!";
            // 
            // SignInPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelInvalid);
            this.Controls.Add(this.checkBoxRememberMe);
            this.Controls.Add(this.textBoxCuePassword);
            this.Controls.Add(this.textBoxCueUsername);
            this.Controls.Add(this.labelSignIn);
            this.Name = "SignInPanel";
            this.Size = new System.Drawing.Size(364, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignIn;
        private TextBoxCue textBoxCueUsername;
        private TextBoxCue textBoxCuePassword;
        private System.Windows.Forms.CheckBox checkBoxRememberMe;
        private System.Windows.Forms.Label labelInvalid;
    }
}
