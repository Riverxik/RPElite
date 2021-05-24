using System;
using System.Drawing;
using System.Windows.Forms;

namespace RPElite
{
    public partial class Overlay : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        enum KeyModifier
        {
            None = 0,
            Alt = 1,
            Control = 2,
            Shift = 4,
            WinKey = 8
        }

        private readonly Commander commander;

        public Overlay()
        {
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            int id = 0; // id for hide/unhide gui
            RegisterHotKey(this.Handle, id, (int) KeyModifier.None, Keys.Oem3.GetHashCode());

            // Game mechanics.
            this.commander = new Commander();
            UpdateGUI();
            
            // Timer for one minute (5 sec test).
            this.timerOneMinute.Start();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x0312)
            {
                this.changeVisible();
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void TimerOneMinute_Tick(object sender, EventArgs e)
        {
            this.commander.DecreaseStats();
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            this.pbFood.Value = this.commander.GetFood();
            this.pbWater.Value = this.commander.GetWater();
            this.pbSleep.Value = this.commander.GetSleep();
            this.panel.Left = (this.ClientSize.Width - this.panel.Width) / 2;
            this.panel.Top = 10;
            //this.panel.Top = (this.ClientSize.Height - this.panel.Height) / 2;
        }
    }
}
