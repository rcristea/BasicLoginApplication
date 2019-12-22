namespace BasicLoginApplication.Custom_Controls {
    partial class SuccessfulSignUpPanel {
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
            this.labelSignUpSuccessfil = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSignUpSuccessfil
            // 
            this.labelSignUpSuccessfil.AutoSize = true;
            this.labelSignUpSuccessfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSignUpSuccessfil.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignUpSuccessfil.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelSignUpSuccessfil.Location = new System.Drawing.Point(13, 92);
            this.labelSignUpSuccessfil.Margin = new System.Windows.Forms.Padding(100, 30, 100, 0);
            this.labelSignUpSuccessfil.Name = "labelSignUpSuccessfil";
            this.labelSignUpSuccessfil.Size = new System.Drawing.Size(339, 47);
            this.labelSignUpSuccessfil.TabIndex = 1;
            this.labelSignUpSuccessfil.Text = "Sign Up Successful!";
            this.labelSignUpSuccessfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuccessfulSignUpPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelSignUpSuccessfil);
            this.Name = "SuccessfulSignUpPanel";
            this.Size = new System.Drawing.Size(364, 227);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUpSuccessfil;
    }
}
