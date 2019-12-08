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
            this.buttonClose = new BasicLoginApplication.Custom_Controls.ButtonClose();
            this.backgroundPanel = new BasicLoginApplication.Custom_Controls.BackgroundPanel();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.signInPanel1 = new BasicLoginApplication.Custom_Controls.SignInPanel();
            this.gradient.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.gradient.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.gradient.Controls.Add(this.buttonLogin);
            this.gradient.Controls.Add(this.signInPanel1);
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
            this.backgroundPanel.Location = new System.Drawing.Point(47, 52);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(376, 472);
            this.backgroundPanel.TabIndex = 0;
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
            // signInPanel1
            // 
            this.signInPanel1.BackColor = System.Drawing.Color.White;
            this.signInPanel1.Location = new System.Drawing.Point(58, 110);
            this.signInPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.signInPanel1.Name = "signInPanel1";
            this.signInPanel1.Size = new System.Drawing.Size(364, 227);
            this.signInPanel1.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private res.Gradient gradient;
        private Custom_Controls.BackgroundPanel backgroundPanel;
        private Custom_Controls.ButtonClose buttonClose;
        private System.Windows.Forms.Button buttonLogin;
        private Custom_Controls.SignInPanel signInPanel1;
    }
}

