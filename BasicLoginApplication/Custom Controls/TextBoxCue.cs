using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BasicLoginApplication.Custom_Controls {
    public partial class TextBoxCue : TextBox {
        [Localizable(true)]
        public string Cue {
            get { return PrivateCue; }
            set { this.PrivateCue = value; updateUsername(); }
        }

        private string PrivateCue;
        public TextBoxCue() {
            InitializeComponent();
        }

        private void updateUsername() {
            if (this.IsHandleCreated && Cue != null) {
                NativeMethods.SendMessage(this.Handle, NativeMethods.EM_SETCUEBANNER, (IntPtr)1, Cue);
            }
        }

        protected override void OnHandleCreated(EventArgs e) {
            base.OnHandleCreated(e);
            updateUsername();
        }
    }

    static class NativeMethods {
        private const uint ECM_FIRST = 0x1500;
        internal const uint EM_SETCUEBANNER = ECM_FIRST + 1;

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, string lParam);
    }
}
