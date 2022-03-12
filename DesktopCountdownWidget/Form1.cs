using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DesktopCountdownWidget
{
    public partial class MainForm : Form
    {
        internal class User32
        {
            public const int SE_SHUTDOWN_PRIVILEGE = 0x13;
            [DllImport("user32.dll")]

            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [DllImport("user32.dll")]

            public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
            [DllImport("user32.dll")]

            public static extern bool SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int X, int Y, int cx,
                int cy, uint uFlags);
        }

        public MainForm()
        {
            InitializeComponent();
            try
            {
                if (Environment.OSVersion.Version.Major < 6)
                {
                    base.SendToBack();
                    IntPtr hWndNewParent = User32.FindWindow("Progman", null);
                    User32.SetParent(base.Handle, hWndNewParent);
                }
                else
                {
                    User32.SetWindowPos(base.Handle, 1, 0, 0, 0, 0, User32.SE_SHUTDOWN_PRIVILEGE);
                }
            }
            catch (ApplicationException exx)
            {
                MessageBox.Show(this, exx.Message, "Pin to Desktop");
            }
        }

        private void refreshLayout()
        {
            this.Top = 25;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 25;
            DateTime dateNow = DateTime.Now;
            DateTime dateTarget = new DateTime(2022, 6, 7);
            TimeSpan timeSpan = dateTarget.Subtract(dateNow);
            CountLabel.Text = String.Format("{0:D3}天", timeSpan.Days);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                User32.SetWindowPos(base.Handle, 1, 0, 0, 0, 0, User32.SE_SHUTDOWN_PRIVILEGE);
            }
            refreshLayout();
        }

        private void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConfigForm configForm = new ConfigForm();
            configForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refreshLayout();
        }
    }
}
