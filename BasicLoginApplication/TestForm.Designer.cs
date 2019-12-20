namespace BasicLoginApplication {
    partial class TestForm {
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
            this.signUpPanel1 = new BasicLoginApplication.Custom_Controls.SignUpPanel();
            this.SuspendLayout();
            // 
            // signUpPanel1
            // 
            this.signUpPanel1.Location = new System.Drawing.Point(196, 60);
            this.signUpPanel1.Name = "signUpPanel1";
            this.signUpPanel1.Size = new System.Drawing.Size(364, 291);
            this.signUpPanel1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signUpPanel1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls.SignUpPanel signUpPanel1;
    }
}