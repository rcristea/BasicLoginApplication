using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BasicLoginApplication.res {
    /// <summary>
    ///     Used to get the purple and blue gradient background.
    /// </summary>
    class Gradient : Panel {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        /// <summary>
        ///     Creates a new linear gradient background using the top and bottom colors.
        /// </summary>
        /// <param name="e">The on paint event.</param>
        protected override void OnPaint(PaintEventArgs e) {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
