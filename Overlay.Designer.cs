﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.panelStation = new System.Windows.Forms.Panel();
            this.panelMarket = new System.Windows.Forms.Panel();
            this.rpButtonMarketExit = new RPElite.RPButton();
            this.dataGridViewMarket = new System.Windows.Forms.DataGridView();
            this.labelMarket = new System.Windows.Forms.Label();
            this.rpButtonHotel = new RPElite.RPButton();
            this.rpButtonShip = new RPElite.RPButton();
            this.rpButtonMarket = new RPElite.RPButton();
            this.panelShip = new System.Windows.Forms.Panel();
            this.panelKitchen = new System.Windows.Forms.Panel();
            this.rpButtonLiving = new RPElite.RPButton();
            this.rpButtonKitchen = new RPElite.RPButton();
            this.rpButtonCockpit = new RPElite.RPButton();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.buttonSleep = new RPElite.RPButton();
            this.buttonStation = new RPElite.RPButton();
            this.buttonShip = new RPElite.RPButton();
            this.pbSleep = new RPElite.RPProgressBar();
            this.pbWater = new RPElite.RPProgressBar();
            this.buttonExit = new RPElite.RPButton();
            this.pbFood = new RPElite.RPProgressBar();
            this.timerOneMinute = new System.Windows.Forms.Timer(this.components);
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel.SuspendLayout();
            this.panelStation.SuspendLayout();
            this.panelMarket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarket)).BeginInit();
            this.panelShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel.Controls.Add(this.panelStation);
            this.panel.Controls.Add(this.panelShip);
            this.panel.Controls.Add(this.rtbLog);
            this.panel.Controls.Add(this.tbLog);
            this.panel.Controls.Add(this.buttonSleep);
            this.panel.Controls.Add(this.buttonStation);
            this.panel.Controls.Add(this.buttonShip);
            this.panel.Controls.Add(this.pbSleep);
            this.panel.Controls.Add(this.pbWater);
            this.panel.Controls.Add(this.buttonExit);
            this.panel.Controls.Add(this.pbFood);
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(760, 485);
            this.panel.TabIndex = 2;
            // 
            // panelStation
            // 
            this.panelStation.Controls.Add(this.panelMarket);
            this.panelStation.Controls.Add(this.rpButtonHotel);
            this.panelStation.Controls.Add(this.rpButtonShip);
            this.panelStation.Controls.Add(this.rpButtonMarket);
            this.panelStation.Location = new System.Drawing.Point(65, 50);
            this.panelStation.Name = "panelStation";
            this.panelStation.Size = new System.Drawing.Size(644, 425);
            this.panelStation.TabIndex = 11;
            this.panelStation.Visible = false;
            // 
            // panelMarket
            // 
            this.panelMarket.Controls.Add(this.rpButtonMarketExit);
            this.panelMarket.Controls.Add(this.dataGridViewMarket);
            this.panelMarket.Controls.Add(this.labelMarket);
            this.panelMarket.Location = new System.Drawing.Point(0, 0);
            this.panelMarket.Name = "panelMarket";
            this.panelMarket.Size = new System.Drawing.Size(644, 425);
            this.panelMarket.TabIndex = 14;
            this.panelMarket.Visible = false;
            // 
            // rpButtonMarketExit
            // 
            this.rpButtonMarketExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonMarketExit.Location = new System.Drawing.Point(289, 186);
            this.rpButtonMarketExit.Name = "rpButtonMarketExit";
            this.rpButtonMarketExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonMarketExit.Size = new System.Drawing.Size(63, 23);
            this.rpButtonMarketExit.TabIndex = 7;
            this.rpButtonMarketExit.Text = "Back";
            this.rpButtonMarketExit.Click += new System.EventHandler(this.rpButtonMarketExit_Click);
            // 
            // dataGridViewMarket
            // 
            this.dataGridViewMarket.AllowUserToAddRows = false;
            this.dataGridViewMarket.AllowUserToDeleteRows = false;
            this.dataGridViewMarket.AllowUserToResizeColumns = false;
            this.dataGridViewMarket.AllowUserToResizeRows = false;
            this.dataGridViewMarket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewMarket.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewMarket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewMarket.ColumnHeadersHeight = 30;
            this.dataGridViewMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMarket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDesc,
            this.ColumnPrice,
            this.ColumnCount,
            this.ColumnBuy});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMarket.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewMarket.EnableHeadersVisualStyles = false;
            this.dataGridViewMarket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.Location = new System.Drawing.Point(0, 26);
            this.dataGridViewMarket.Name = "dataGridViewMarket";
            this.dataGridViewMarket.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarket.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewMarket.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewMarket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMarket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarket.Size = new System.Drawing.Size(500, 150);
            this.dataGridViewMarket.TabIndex = 2;
            // 
            // labelMarket
            // 
            this.labelMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.labelMarket.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarket.Location = new System.Drawing.Point(1, 3);
            this.labelMarket.Name = "labelMarket";
            this.labelMarket.Size = new System.Drawing.Size(499, 23);
            this.labelMarket.TabIndex = 1;
            this.labelMarket.Text = "Магазин";
            this.labelMarket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rpButtonHotel
            // 
            this.rpButtonHotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonHotel.Location = new System.Drawing.Point(358, 58);
            this.rpButtonHotel.Name = "rpButtonHotel";
            this.rpButtonHotel.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonHotel.Size = new System.Drawing.Size(63, 23);
            this.rpButtonHotel.TabIndex = 13;
            this.rpButtonHotel.Text = "Hotel";
            // 
            // rpButtonShip
            // 
            this.rpButtonShip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonShip.Location = new System.Drawing.Point(289, 24);
            this.rpButtonShip.Name = "rpButtonShip";
            this.rpButtonShip.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonShip.Size = new System.Drawing.Size(63, 23);
            this.rpButtonShip.TabIndex = 12;
            this.rpButtonShip.Text = "Ship";
            this.rpButtonShip.Click += new System.EventHandler(this.rpButtonShip_Click);
            // 
            // rpButtonMarket
            // 
            this.rpButtonMarket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonMarket.Location = new System.Drawing.Point(220, 58);
            this.rpButtonMarket.Name = "rpButtonMarket";
            this.rpButtonMarket.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonMarket.Size = new System.Drawing.Size(63, 23);
            this.rpButtonMarket.TabIndex = 7;
            this.rpButtonMarket.Text = "Market";
            this.rpButtonMarket.Click += new System.EventHandler(this.rpButtonMarket_Click);
            // 
            // panelShip
            // 
            this.panelShip.Controls.Add(this.panelKitchen);
            this.panelShip.Controls.Add(this.rpButtonLiving);
            this.panelShip.Controls.Add(this.rpButtonKitchen);
            this.panelShip.Controls.Add(this.rpButtonCockpit);
            this.panelShip.Location = new System.Drawing.Point(65, 50);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(644, 425);
            this.panelShip.TabIndex = 10;
            this.panelShip.Visible = false;
            // 
            // panelKitchen
            // 
            this.panelKitchen.Location = new System.Drawing.Point(122, 123);
            this.panelKitchen.Name = "panelKitchen";
            this.panelKitchen.Size = new System.Drawing.Size(400, 209);
            this.panelKitchen.TabIndex = 9;
            this.panelKitchen.Visible = false;
            // 
            // rpButtonLiving
            // 
            this.rpButtonLiving.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonLiving.Location = new System.Drawing.Point(358, 53);
            this.rpButtonLiving.Name = "rpButtonLiving";
            this.rpButtonLiving.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonLiving.Size = new System.Drawing.Size(63, 23);
            this.rpButtonLiving.TabIndex = 8;
            this.rpButtonLiving.Text = "Living";
            // 
            // rpButtonKitchen
            // 
            this.rpButtonKitchen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonKitchen.Location = new System.Drawing.Point(221, 53);
            this.rpButtonKitchen.Name = "rpButtonKitchen";
            this.rpButtonKitchen.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonKitchen.Size = new System.Drawing.Size(63, 23);
            this.rpButtonKitchen.TabIndex = 7;
            this.rpButtonKitchen.Text = "Kitchen";
            // 
            // rpButtonCockpit
            // 
            this.rpButtonCockpit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonCockpit.Location = new System.Drawing.Point(289, 23);
            this.rpButtonCockpit.Name = "rpButtonCockpit";
            this.rpButtonCockpit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonCockpit.Size = new System.Drawing.Size(63, 23);
            this.rpButtonCockpit.TabIndex = 6;
            this.rpButtonCockpit.Text = "Cockpit";
            this.rpButtonCockpit.Click += new System.EventHandler(this.rpButtonCockpit_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbLog.Location = new System.Drawing.Point(187, 294);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbLog.Size = new System.Drawing.Size(400, 180);
            this.rtbLog.TabIndex = 9;
            this.rtbLog.Text = "";
            // 
            // tbLog
            // 
            this.tbLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbLog.Location = new System.Drawing.Point(187, 79);
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
            this.buttonSleep.Text = "Reserved";
            this.buttonSleep.Click += new System.EventHandler(this.ButtonSleep_Click);
            // 
            // buttonStation
            // 
            this.buttonStation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStation.Location = new System.Drawing.Point(285, 50);
            this.buttonStation.Name = "buttonStation";
            this.buttonStation.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonStation.Size = new System.Drawing.Size(63, 23);
            this.buttonStation.TabIndex = 5;
            this.buttonStation.Text = "Station";
            this.buttonStation.Click += new System.EventHandler(this.ButtonStation_Click);
            // 
            // buttonShip
            // 
            this.buttonShip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonShip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonShip.Location = new System.Drawing.Point(354, 50);
            this.buttonShip.Name = "buttonShip";
            this.buttonShip.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonShip.Size = new System.Drawing.Size(63, 23);
            this.buttonShip.TabIndex = 4;
            this.buttonShip.Text = "Ship";
            this.buttonShip.Click += new System.EventHandler(this.ButtonShip_Click);
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
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnName.Frozen = true;
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDesc.Frozen = true;
            this.ColumnDesc.HeaderText = "Описание";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnPrice.Frozen = true;
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnCount
            // 
            this.ColumnCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCount.Frozen = true;
            this.ColumnCount.HeaderText = "Количество";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnBuy
            // 
            this.ColumnBuy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColumnBuy.HeaderText = "1 шт.";
            this.ColumnBuy.Name = "ColumnBuy";
            this.ColumnBuy.ReadOnly = true;
            this.ColumnBuy.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnBuy.Text = "Купить";
            this.ColumnBuy.UseColumnTextForButtonValue = true;
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
            this.panelStation.ResumeLayout(false);
            this.panelMarket.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarket)).EndInit();
            this.panelShip.ResumeLayout(false);
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
        private RPButton buttonShip;
        private RPButton buttonStation;
        private RPButton buttonSleep;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Panel panelShip;
        private RPButton rpButtonCockpit;
        private RPButton rpButtonKitchen;
        private RPButton rpButtonLiving;
        private System.Windows.Forms.Panel panelKitchen;
        private System.Windows.Forms.Panel panelStation;
        private RPButton rpButtonMarket;
        private RPButton rpButtonShip;
        private RPButton rpButtonHotel;
        private System.Windows.Forms.Panel panelMarket;
        private System.Windows.Forms.Label labelMarket;
        private System.Windows.Forms.DataGridView dataGridViewMarket;
        private RPButton rpButtonMarketExit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnBuy;
    }
}

