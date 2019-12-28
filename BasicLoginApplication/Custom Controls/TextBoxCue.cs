using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BasicLoginApplication.Custom_Controls {
    /// <summary>
    ///     Custom textbox that displays a "cue" on the inside giving information on what should be entered into the textbox.
    /// </summary>
    public partial class TextBoxCue : TextBox {
        [Localizable(true)]
        public string Cue {
            get { return PrivateCue; }
            set { this.PrivateCue = value; updateCue(); }
        }

        private string PrivateCue;
        /// <summary>
        ///     Creates a new textBoxCue.
        /// </summary>
        public TextBoxCue() {
            InitializeComponent();
        }

        /// <summary>
        ///     Adds/Updates the cue inside the textBox.
        /// </summary>
        private void updateCue() {
            if (this.IsHandleCreated && Cue != null) {
                NativeMethods.SendMessage(this.Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, Cue);
            }
        }

        /// <summary>
        ///     Updates the cue when the handle is created for the control.
        /// </summary>
        /// <param name="e">The OnHandleCreated event.</param>
        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            updateCue();
        }
    }

    /// <summary>
    ///     Used to put the method into the textbox.
    /// </summary>
    static class NativeMethods {
        private const uint ECM_FIRST = 0x1500;
        internal const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);
    }
}
