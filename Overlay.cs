using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RPElite
{
    public partial class Overlay : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private readonly Color stationColor = Color.Orange;
        private readonly Color textMsgColor = Color.BlueViolet;//Color.FromArgb(52, 37, 76);
        private readonly Color entryColor = Color.MediumVioletRed;

        private readonly LogChecker _log;
        private bool isDebug;
        private int count;

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
            isDebug = false;
            // Form.
            InitializeComponent();
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // Hot key.
            int id = 0; // id for hide/unhide gui
            RegisterHotKey(this.Handle, id, (int)KeyModifier.None, Keys.Oem3.GetHashCode());

            // Panel.
            this.panel.Left = (this.ClientSize.Width - this.panel.Width) / 2;
            this.panel.Top = 10;
            //this.panel.Top = (this.ClientSize.Height - this.panel.Height) / 2;

            // Textbox Log
            this.tbLog.BackColor = Color.FromArgb(255, 133, 0);
            this.rtbLog.BackColor = Color.FromArgb(255, 133, 0);
            _log = new LogChecker();
            _log.newEntryHandler += LogNewEntryHandler;

            // Game mechanics.
            this.commander = new Commander();
            FoodFactory.Init();
            UpdateGUI();
            
            // Timer for one minute (5 sec test).
            this.timerOneMinute.Start();
        }

        private void LogNewEntryHandler(object sender, LogEvent e)
        {
            string entry = EventLogger.GetPrettyLog(e.GetString());
            int length = entry.Length;
            if (!entry.StartsWith("Undefined"))
            {
                this.tbLog.AppendText(entry + "\r\n");
                this.tbLog.SelectionStart = this.tbLog.Text.Length;
                this.tbLog.SelectionLength = 0;
            }
            // Rich
            if (!entry.StartsWith("Undefined"))
            {
                this.rtbLog.AppendText(entry + "\r\n");
                this.rtbLog.SelectionStart = this.rtbLog.Text.Length;
                this.rtbLog.ScrollToCaret();
                CustomizeEntryText(entry, length);
            }
        }

        private void CustomizeEntryText(string entry, int length)
        {
            int start = this.rtbLog.Text.Length - length;
            if (start > 0) start -= 1;
            Regex regSender = new Regex(@"\[+.*\]+");
            Regex regMessage = new Regex(@"-->--\s.*");
            // ->
            this.rtbLog.SelectionStart = start;
            this.rtbLog.SelectionLength = 2;
            this.rtbLog.SelectionColor = entryColor;
            // [Station]
            MatchCollection mc = regSender.Matches(entry);
            foreach (Match item in mc)
            {
                int startIndex = item.Index + start;
                int stopIndex = item.Length;
                this.rtbLog.Select(startIndex, stopIndex);
                this.rtbLog.SelectionColor = stationColor;
                this.rtbLog.SelectionStart = start;
            }
            // [-->-- textMsg]
            mc = regMessage.Matches(entry);
            foreach (Match item in mc)
            {
                int startIndex = item.Index + start;// + 6; without -->--
                int stopIndex = item.Length;
                this.rtbLog.Select(startIndex, stopIndex);
                this.rtbLog.SelectionColor = textMsgColor;
                this.rtbLog.SelectionStart = start;
            }
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
            this._log.sr.Close();
            this._log.fs.Close();
            this.Close();
        }

        private void Overlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, 0);
        }

        private void TimerOneSecond_Tick(object sender, EventArgs e)
        {
            if (count % 5 == 0) // Every 5 seconds.
            {
                this.commander.DecreaseStats();
                this._log.ReadLog();
            }
            UpdateGUI();
            if (count > 255) { count = 0; } else { count++; }
        }

        private void UpdateGUI()
        {
            this.pbFood.Value = this.commander.GetFood();
            this.pbWater.Value = this.commander.GetWater();
            this.pbSleep.Value = this.commander.GetSleep();
        }

        private void CloseAllPanels()
        {
            this.panelShip.Visible = false;
            this.panelKitchen.Visible = false;
            this.panelStation.Visible = false;
            this.panelMarket.Visible = false;
        }

        private void ButtonShip_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            this.panelShip.Visible = true;
        }

        private void ButtonStation_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            this.panelStation.Visible = true;
        }

        private void ButtonSleep_Click(object sender, EventArgs e)
        {
            this.commander.AddSleep();
        }

        private void rpButtonCockpit_Click(object sender, EventArgs e)
        {
            this.panelShip.Visible = false;
        }

        private void ButtonEat_Click(object sender, EventArgs e)
        {

        }

        private void rpButtonShip_Click(object sender, EventArgs e)
        {
            this.panelStation.Visible = false;
        }

        private void rpButtonMarket_Click(object sender, EventArgs e)
        {
            this.panelMarket.Visible = true;
            this.dataGridViewMarket.Rows.Add(FoodFactory.CreateFood("Яблоко").ToStringArray());
            this.dataGridViewMarket.Rows.Add(FoodFactory.CreateFood("Суп").ToStringArray());
        }

        private void rpButtonMarketExit_Click(object sender, EventArgs e)
        {
            CloseAllPanels();
            this.panelStation.Visible = true;
        }
    }
}
