
namespace RPElite
{
    partial class Overlay
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.buttonSleep = new RPElite.RPButton();
            this.buttonDrink = new RPElite.RPButton();
            this.buttonEat = new RPElite.RPButton();
            this.pbSleep = new RPElite.RPProgressBar();
            this.pbWater = new RPElite.RPProgressBar();
            this.buttonExit = new RPElite.RPButton();
            this.pbFood = new RPElite.RPProgressBar();
            this.timerOneMinute = new System.Windows.Forms.Timer(this.components);
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.Controls.Add(this.tbLog);
            this.panel.Controls.Add(this.buttonSleep);
            this.panel.Controls.Add(this.buttonDrink);
            this.panel.Controls.Add(this.buttonEat);
            this.panel.Controls.Add(this.pbSleep);
            this.panel.Controls.Add(this.pbWater);
            this.panel.Controls.Add(this.buttonExit);
            this.panel.Controls.Add(this.pbFood);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(760, 313);
            this.panel.TabIndex = 2;
            // 
            // tbLog
            // 
            this.tbLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLog.Location = new System.Drawing.Point(183, 79);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ReadOnly = true;
            this.tbLog.Size = new System.Drawing.Size(400, 180);
            this.tbLog.TabIndex = 8;
            // 
            // buttonSleep
            // 
            this.buttonSleep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSleep.Location = new System.Drawing.Point(423, 50);
            this.buttonSleep.Name = "buttonSleep";
            this.buttonSleep.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonSleep.Size = new System.Drawing.Size(63, 23);
            this.buttonSleep.TabIndex = 6;
            this.buttonSleep.Text = "Sleep";
            this.buttonSleep.Click += new System.EventHandler(this.ButtonSleep_Click);
            // 
            // buttonDrink
            // 
            this.buttonDrink.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDrink.Location = new System.Drawing.Point(354, 50);
            this.buttonDrink.Name = "buttonDrink";
            this.buttonDrink.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonDrink.Size = new System.Drawing.Size(63, 23);
            this.buttonDrink.TabIndex = 5;
            this.buttonDrink.Text = "Drink";
            this.buttonDrink.Click += new System.EventHandler(this.ButtonDrink_Click);
            // 
            // buttonEat
            // 
            this.buttonEat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonEat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonEat.Location = new System.Drawing.Point(286, 50);
            this.buttonEat.Name = "buttonEat";
            this.buttonEat.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonEat.Size = new System.Drawing.Size(63, 23);
            this.buttonEat.TabIndex = 4;
            this.buttonEat.Text = "Eat";
            this.buttonEat.Click += new System.EventHandler(this.ButtonEat_Click);
            // 
            // pbSleep
            // 
            this.pbSleep.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbSleep.BackColor = System.Drawing.Color.LightGray;
            this.pbSleep.BorderColor = System.Drawing.Color.Black;
            this.pbSleep.BorderWidth = 2;
            this.pbSleep.ForeColor = System.Drawing.Color.Black;
            this.pbSleep.Location = new System.Drawing.Point(286, 34);
            this.pbSleep.MaxValue = 100;
            this.pbSleep.MinValue = 0;
            this.pbSleep.Name = "pbSleep";
            this.pbSleep.ProgressColor = System.Drawing.Color.BlueViolet;
            this.pbSleep.ProgressTextType = RPElite.RPProgressBar.RPProgressTextType.Percent;
            this.pbSleep.ShowProgressText = true;
            this.pbSleep.Size = new System.Drawing.Size(200, 10);
            this.pbSleep.TabIndex = 3;
            this.pbSleep.Text = "Sleep";
            this.pbSleep.Value = 86;
            // 
            // pbWater
            // 
            this.pbWater.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbWater.BackColor = System.Drawing.Color.LightGray;
            this.pbWater.BorderColor = System.Drawing.Color.Black;
            this.pbWater.BorderWidth = 2;
            this.pbWater.ForeColor = System.Drawing.Color.Black;
            this.pbWater.Location = new System.Drawing.Point(286, 18);
            this.pbWater.MaxValue = 100;
            this.pbWater.MinValue = 0;
            this.pbWater.Name = "pbWater";
            this.pbWater.ProgressColor = System.Drawing.Color.LightSeaGreen;
            this.pbWater.ProgressTextType = RPElite.RPProgressBar.RPProgressTextType.Percent;
            this.pbWater.ShowProgressText = true;
            this.pbWater.Size = new System.Drawing.Size(200, 10);
            this.pbWater.TabIndex = 2;
            this.pbWater.Text = "Water";
            this.pbWater.Value = 86;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExit.Location = new System.Drawing.Point(354, 265);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonExit.Size = new System.Drawing.Size(63, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Hit me";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // pbFood
            // 
            this.pbFood.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbFood.BackColor = System.Drawing.Color.LightGray;
            this.pbFood.BorderColor = System.Drawing.Color.Black;
            this.pbFood.BorderWidth = 2;
            this.pbFood.ForeColor = System.Drawing.Color.Black;
            this.pbFood.Location = new System.Drawing.Point(286, 2);
            this.pbFood.MaxValue = 100;
            this.pbFood.MinValue = 0;
            this.pbFood.Name = "pbFood";
            this.pbFood.ProgressColor = System.Drawing.Color.GreenYellow;
            this.pbFood.ProgressTextType = RPElite.RPProgressBar.RPProgressTextType.Percent;
            this.pbFood.ShowProgressText = true;
            this.pbFood.Size = new System.Drawing.Size(200, 12);
            this.pbFood.TabIndex = 1;
            this.pbFood.Text = "Food";
            this.pbFood.Value = 86;
            // 
            // timerOneMinute
            // 
            this.timerOneMinute.Interval = 1000;
            this.timerOneMinute.Tick += new System.EventHandler(this.TimerOneSecond_Tick);
            // 
            // Overlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.panel);
            this.Name = "Overlay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPElite";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Overlay_FormClosing);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public void changeVisible()
        {
            this.panel.Visible = !this.panel.Visible;
        }

        private RPButton buttonExit;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Timer timerOneMinute;
        private RPProgressBar pbFood;
        private RPProgressBar pbWater;
        private RPProgressBar pbSleep;
        private RPButton buttonEat;
        private RPButton buttonDrink;
        private RPButton buttonSleep;
        private System.Windows.Forms.TextBox tbLog;
    }
}

