namespace BasicLoginApplication {
    partial class SignInForm {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gradient = new BasicLoginApplication.res.Gradient();
            this.buttonDeleteAccount = new System.Windows.Forms.Button();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.signedInPanel = new BasicLoginApplication.Custom_Controls.SignedInPanel();
            this.labelButtonClose = new System.Windows.Forms.Label();
            this.successfulSignUpPanel = new BasicLoginApplication.Custom_Controls.SuccessfulSignUpPanel();
            this.labelBackButton = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.signUpPanel = new BasicLoginApplication.Custom_Controls.SignUpPanel();
            this.labelSignUpButton = new System.Windows.Forms.Label();
            this.labelNotAMemeber = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.signInPanel = new BasicLoginApplication.Custom_Controls.SignInPanel();
            this.buttonClose = new BasicLoginApplication.Custom_Controls.ButtonClose();
            this.backgroundPanel = new BasicLoginApplication.Custom_Controls.BackgroundPanel();
            this.gradient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.gradient.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.gradient.Controls.Add(this.buttonDeleteAccount);
            this.gradient.Controls.Add(this.buttonSignOut);
            this.gradient.Controls.Add(this.signedInPanel);
            this.gradient.Controls.Add(this.labelButtonClose);
            this.gradient.Controls.Add(this.successfulSignUpPanel);
            this.gradient.Controls.Add(this.labelBackButton);
            this.gradient.Controls.Add(this.buttonSignup);
            this.gradient.Controls.Add(this.signUpPanel);
            this.gradient.Controls.Add(this.labelSignUpButton);
            this.gradient.Controls.Add(this.labelNotAMemeber);
            this.gradient.Controls.Add(this.buttonLogin);
            this.gradient.Controls.Add(this.signInPanel);
            this.gradient.Controls.Add(this.buttonClose);
            this.gradient.Controls.Add(this.backgroundPanel);
            this.gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(470, 590);
            this.gradient.TabIndex = 0;
            this.gradient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseDown);
            this.gradient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseMove);
            this.gradient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseUp);
            // 
            // buttonDeleteAccount
            // 
            this.buttonDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.buttonDeleteAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteAccount.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.buttonDeleteAccount.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteAccount.Location = new System.Drawing.Point(141, 277);
            this.buttonDeleteAccount.Name = "buttonDeleteAccount";
            this.buttonDeleteAccount.Size = new System.Drawing.Size(188, 37);
            this.buttonDeleteAccount.TabIndex = 13;
            this.buttonDeleteAccount.Text = "DELETE ACCOUNT";
            this.buttonDeleteAccount.UseVisualStyleBackColor = false;
            this.buttonDeleteAccount.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDeleteAccount_MouseDown);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.buttonSignOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignOut.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.buttonSignOut.ForeColor = System.Drawing.Color.White;
            this.buttonSignOut.Location = new System.Drawing.Point(140, 217);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(188, 37);
            this.buttonSignOut.TabIndex = 12;
            this.buttonSignOut.Text = "SIGN OUT";
            this.buttonSignOut.UseVisualStyleBackColor = false;
            this.buttonSignOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSignOut_MouseDown);
            // 
            // signedInPanel
            // 
            this.signedInPanel.BackColor = System.Drawing.Color.White;
            this.signedInPanel.Location = new System.Drawing.Point(58, 124);
            this.signedInPanel.Name = "signedInPanel";
            this.signedInPanel.Size = new System.Drawing.Size(364, 67);
            this.signedInPanel.TabIndex = 11;
            // 
            // labelButtonClose
            // 
            this.labelButtonClose.AutoSize = true;
            this.labelButtonClose.BackColor = System.Drawing.Color.White;
            this.labelButtonClose.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelButtonClose.ForeColor = System.Drawing.Color.Gray;
            this.labelButtonClose.Location = new System.Drawing.Point(210, 492);
            this.labelButtonClose.Name = "labelButtonClose";
            this.labelButtonClose.Size = new System.Drawing.Size(35, 13);
            this.labelButtonClose.TabIndex = 10;
            this.labelButtonClose.Text = "Close";
            this.labelButtonClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelButtonClose_MouseDown);
            this.labelButtonClose.MouseLeave += new System.EventHandler(this.labelButtonClose_MouseLeave);
            this.labelButtonClose.MouseHover += new System.EventHandler(this.labelButtonClose_MouseHover);
            // 
            // successfulSignUpPanel
            // 
            this.successfulSignUpPanel.BackColor = System.Drawing.Color.White;
            this.successfulSignUpPanel.Location = new System.Drawing.Point(58, 113);
            this.successfulSignUpPanel.Name = "successfulSignUpPanel";
            this.successfulSignUpPanel.Size = new System.Drawing.Size(364, 227);
            this.successfulSignUpPanel.TabIndex = 9;
            // 
            // labelBackButton
            // 
            this.labelBackButton.AutoSize = true;
            this.labelBackButton.BackColor = System.Drawing.Color.White;
            this.labelBackButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBackButton.ForeColor = System.Drawing.Color.Gray;
            this.labelBackButton.Location = new System.Drawing.Point(210, 492);
            this.labelBackButton.Name = "labelBackButton";
            this.labelBackButton.Size = new System.Drawing.Size(30, 13);
            this.labelBackButton.TabIndex = 8;
            this.labelBackButton.Text = "Back";
            this.labelBackButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBackButton_MouseDown);
            this.labelBackButton.MouseLeave += new System.EventHandler(this.labelBackButton_MouseLeave);
            this.labelBackButton.MouseHover += new System.EventHandler(this.labelBackButton_MouseHover);
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.buttonSignup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.buttonSignup.ForeColor = System.Drawing.Color.White;
            this.buttonSignup.Location = new System.Drawing.Point(140, 392);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(188, 37);
            this.buttonSignup.TabIndex = 7;
            this.buttonSignup.Text = "SIGN UP";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSignup_MouseDown);
            // 
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.White;
            this.signUpPanel.Location = new System.Drawing.Point(58, 113);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(364, 285);
            this.signUpPanel.TabIndex = 6;
            // 
            // labelSignUpButton
            // 
            this.labelSignUpButton.AutoSize = true;
            this.labelSignUpButton.BackColor = System.Drawing.Color.White;
            this.labelSignUpButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpButton.ForeColor = System.Drawing.Color.Gray;
            this.labelSignUpButton.Location = new System.Drawing.Point(246, 492);
            this.labelSignUpButton.Name = "labelSignUpButton";
            this.labelSignUpButton.Size = new System.Drawing.Size(48, 13);
            this.labelSignUpButton.TabIndex = 5;
            this.labelSignUpButton.Text = "Sign Up";
            this.labelSignUpButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSignUpButton_MouseDown);
            this.labelSignUpButton.MouseLeave += new System.EventHandler(this.labelSignUpButton_MouseLeave);
            this.labelSignUpButton.MouseHover += new System.EventHandler(this.labelSignUpButton_MouseHover);
            // 
            // labelNotAMemeber
            // 
            this.labelNotAMemeber.AutoSize = true;
            this.labelNotAMemeber.BackColor = System.Drawing.Color.White;
            this.labelNotAMemeber.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotAMemeber.ForeColor = System.Drawing.Color.Gray;
            this.labelNotAMemeber.Location = new System.Drawing.Point(156, 492);
            this.labelNotAMemeber.Name = "labelNotAMemeber";
            this.labelNotAMemeber.Size = new System.Drawing.Size(84, 13);
            this.labelNotAMemeber.TabIndex = 4;
            this.labelNotAMemeber.Text = "Not a member?";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(140, 326);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(188, 38);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // signInPanel
            // 
            this.signInPanel.AccessibleDescription = "7";
            this.signInPanel.BackColor = System.Drawing.Color.White;
            this.signInPanel.Location = new System.Drawing.Point(58, 110);
            this.signInPanel.Margin = new System.Windows.Forms.Padding(0);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(364, 227);
            this.signInPanel.TabIndex = 2;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(381, 82);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(25, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonClose1_MouseDown);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackColor = System.Drawing.Color.White;
            this.backgroundPanel.Location = new System.Drawing.Point(47, 58);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(376, 472);
            this.backgroundPanel.TabIndex = 0;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 590);
            this.Controls.Add(this.gradient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignInForm";
            this.Text = "Sign In";
            this.gradient.ResumeLayout(false);
            this.gradient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private res.Gradient gradient;
        private Custom_Controls.BackgroundPanel backgroundPanel;
        private Custom_Controls.ButtonClose buttonClose;
        private System.Windows.Forms.Button buttonLogin;
        private Custom_Controls.SignInPanel signInPanel;
        private System.Windows.Forms.Label labelSignUpButton;
        private System.Windows.Forms.Label labelNotAMemeber;
        private System.Windows.Forms.Button buttonSignup;
        private Custom_Controls.SignUpPanel signUpPanel;
        private System.Windows.Forms.Label labelBackButton;
        private Custom_Controls.SuccessfulSignUpPanel successfulSignUpPanel;
        private System.Windows.Forms.Label labelButtonClose;
        private Custom_Controls.SignedInPanel signedInPanel;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Button buttonDeleteAccount;
    }
}

