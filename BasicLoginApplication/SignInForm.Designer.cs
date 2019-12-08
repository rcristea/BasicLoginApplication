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
            this.SuspendLayout();
            // 
            // gradient
            // 
            this.gradient.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(37)))), ((int)(((byte)(141)))));
            this.gradient.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(137)))), ((int)(((byte)(162)))));
            this.gradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradient.Location = new System.Drawing.Point(0, 0);
            this.gradient.Name = "gradient";
            this.gradient.Size = new System.Drawing.Size(470, 590);
            this.gradient.TabIndex = 0;
            this.gradient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseDown);
            this.gradient.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseMove);
            this.gradient.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gradient_MouseUp);
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
            this.ResumeLayout(false);

        }

        #endregion

        private res.Gradient gradient;
    }
}

