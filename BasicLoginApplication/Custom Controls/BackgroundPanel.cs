using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     Used to create the curved background panel.
    /// </summary>
    public partial class BackgroundPanel : UserControl {
        /// <summary>
        ///     Creates a rectangle with rounded edges.
        /// </summary>
        /// <param name="Left">The left coordinate start.</param>
        /// <param name="Top">The top coordinate start.</param>
        /// <param name="Right">The right coordinate bound.</param>
        /// <param name="Bottom">The bottom coordinate bound.</param>
        /// <param name="Height">The height of the rounded edge.</param>
        /// <param name="Width">The width of the rounded edge.</param>
        /// <returns>Pointer of the regions of the rectangle.</returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int Left, int Top, int Right, int Bottom, int Height, int Width);

        /// <summary>
        ///     Creates a new background panel that has curved edges.
        /// </summary>
        public BackgroundPanel() {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
    }
}
