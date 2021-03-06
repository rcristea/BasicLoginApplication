﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     The close button (black X in top right) which is used to close out the application at any time.
    /// </summary>
    public partial class ButtonClose : UserControl {
        /// <summary>
        ///     Creates the black X.
        /// </summary>
        public ButtonClose() {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.White;
        }

        /// <summary>
        ///     Used to paint the diagonal lines of the X.
        /// </summary>
        /// <param name="sender">The ButtonClose control.</param>
        /// <param name="e">The paint event.</param>
        private void ButtonClose_Paint(object sender, PaintEventArgs e) {
            Pen pen = new Pen(Color.Black, 2);

            PointF x1 = new PointF(0.0F, 0.0F);
            PointF y1 = new PointF(20.0F, 20.0F);
            PointF x2 = new PointF(20.0F, 0.0F);
            PointF y2 = new PointF(0.0F, 20.0F);

            e.Graphics.DrawLine(pen, x1, y1);
            e.Graphics.DrawLine(pen, x2, y2);
        }
    }
}
