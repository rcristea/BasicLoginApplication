using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BasicLoginApplication.res {
    class Gradient : Panel {
        public Color ColorTop { get; set; }
        public Color ColorBottom { get; set; }

        protected override void OnPaint(PaintEventArgs e) {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, this.ColorTop, this.ColorBottom, 90F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
