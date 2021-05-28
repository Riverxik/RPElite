
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle43 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel = new System.Windows.Forms.Panel();
            this.panelStation = new System.Windows.Forms.Panel();
            this.panelMarket = new System.Windows.Forms.Panel();
            this.labelCredits = new System.Windows.Forms.Label();
            this.rpButtonMarketExit = new RPElite.RPButton();
            this.dataGridViewMarket = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStationCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLess = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMore = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.buttonReserved = new RPElite.RPButton();
            this.buttonStation = new RPElite.RPButton();
            this.buttonShip = new RPElite.RPButton();
            this.pbEnergy = new RPElite.RPProgressBar();
            this.pbWater = new RPElite.RPProgressBar();
            this.pbFood = new RPElite.RPProgressBar();
            this.buttonExit = new RPElite.RPButton();
            this.timerOneMinute = new System.Windows.Forms.Timer(this.components);
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
            this.panel.Controls.Add(this.buttonStation);
            this.panel.Controls.Add(this.buttonShip);
            this.panel.Controls.Add(this.buttonReserved);
            this.panel.Controls.Add(this.pbEnergy);
            this.panel.Controls.Add(this.pbWater);
            this.panel.Controls.Add(this.pbFood);
            this.panel.Controls.Add(this.buttonExit);
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
            this.panelMarket.Controls.Add(this.labelCredits);
            this.panelMarket.Controls.Add(this.rpButtonMarketExit);
            this.panelMarket.Controls.Add(this.dataGridViewMarket);
            this.panelMarket.Controls.Add(this.labelMarket);
            this.panelMarket.Location = new System.Drawing.Point(0, 0);
            this.panelMarket.Name = "panelMarket";
            this.panelMarket.Size = new System.Drawing.Size(644, 425);
            this.panelMarket.TabIndex = 14;
            this.panelMarket.Visible = false;
            // 
            // labelCredits
            // 
            this.labelCredits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.labelCredits.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCredits.Location = new System.Drawing.Point(37, 174);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(585, 23);
            this.labelCredits.TabIndex = 9;
            this.labelCredits.Text = "Ваши средства:";
            this.labelCredits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rpButtonMarketExit
            // 
            this.rpButtonMarketExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonMarketExit.DrawBorder = true;
            this.rpButtonMarketExit.Location = new System.Drawing.Point(289, 200);
            this.rpButtonMarketExit.Name = "rpButtonMarketExit";
            this.rpButtonMarketExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonMarketExit.Size = new System.Drawing.Size(63, 23);
            this.rpButtonMarketExit.TabIndex = 7;
            this.rpButtonMarketExit.Text = "Назад";
            this.rpButtonMarketExit.Click += new System.EventHandler(this.RPButtonMarketExit_Click);
            // 
            // dataGridViewMarket
            // 
            this.dataGridViewMarket.AllowUserToAddRows = false;
            this.dataGridViewMarket.AllowUserToDeleteRows = false;
            this.dataGridViewMarket.AllowUserToResizeColumns = false;
            this.dataGridViewMarket.AllowUserToResizeRows = false;
            this.dataGridViewMarket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMarket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridViewMarket.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dataGridViewMarket.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarket.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewMarket.ColumnHeadersHeight = 30;
            this.dataGridViewMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMarket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnDesc,
            this.ColumnPrice,
            this.ColumnStationCount,
            this.ColumnLess,
            this.ColumnCount,
            this.ColumnMore});
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarket.DefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewMarket.EnableHeadersVisualStyles = false;
            this.dataGridViewMarket.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.Location = new System.Drawing.Point(37, 24);
            this.dataGridViewMarket.Name = "dataGridViewMarket";
            this.dataGridViewMarket.ReadOnly = true;
            dataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle43.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMarket.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            this.dataGridViewMarket.RowHeadersVisible = false;
            dataGridViewCellStyle44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.dataGridViewMarket.RowsDefaultCellStyle = dataGridViewCellStyle44;
            this.dataGridViewMarket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMarket.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarket.Size = new System.Drawing.Size(585, 150);
            this.dataGridViewMarket.TabIndex = 2;
            this.dataGridViewMarket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMarket_CellContentClick);
            this.dataGridViewMarket.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMarket_CellDoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnDesc
            // 
            this.ColumnDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDesc.HeaderText = "Описание";
            this.ColumnDesc.Name = "ColumnDesc";
            this.ColumnDesc.ReadOnly = true;
            this.ColumnDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnDesc.Width = 150;
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "Цена";
            this.ColumnPrice.Name = "ColumnPrice";
            this.ColumnPrice.ReadOnly = true;
            this.ColumnPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnStationCount
            // 
            this.ColumnStationCount.HeaderText = "Станция";
            this.ColumnStationCount.Name = "ColumnStationCount";
            this.ColumnStationCount.ReadOnly = true;
            this.ColumnStationCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnLess
            // 
            this.ColumnLess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnLess.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColumnLess.HeaderText = "<";
            this.ColumnLess.Name = "ColumnLess";
            this.ColumnLess.ReadOnly = true;
            this.ColumnLess.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnLess.Text = "<";
            this.ColumnLess.Width = 30;
            // 
            // ColumnCount
            // 
            this.ColumnCount.HeaderText = "Инвентарь";
            this.ColumnCount.Name = "ColumnCount";
            this.ColumnCount.ReadOnly = true;
            this.ColumnCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnMore
            // 
            this.ColumnMore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ColumnMore.HeaderText = ">";
            this.ColumnMore.Name = "ColumnMore";
            this.ColumnMore.ReadOnly = true;
            this.ColumnMore.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnMore.Text = ">";
            this.ColumnMore.UseColumnTextForButtonValue = true;
            this.ColumnMore.Width = 30;
            // 
            // labelMarket
            // 
            this.labelMarket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.labelMarket.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMarket.Location = new System.Drawing.Point(37, 1);
            this.labelMarket.Name = "labelMarket";
            this.labelMarket.Size = new System.Drawing.Size(585, 23);
            this.labelMarket.TabIndex = 1;
            this.labelMarket.Text = "Магазин";
            this.labelMarket.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rpButtonHotel
            // 
            this.rpButtonHotel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonHotel.DrawBorder = true;
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
            this.rpButtonShip.DrawBorder = true;
            this.rpButtonShip.Location = new System.Drawing.Point(289, 24);
            this.rpButtonShip.Name = "rpButtonShip";
            this.rpButtonShip.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonShip.Size = new System.Drawing.Size(63, 23);
            this.rpButtonShip.TabIndex = 12;
            this.rpButtonShip.Text = "Ship";
            this.rpButtonShip.Click += new System.EventHandler(this.RPButtonShip_Click);
            // 
            // rpButtonMarket
            // 
            this.rpButtonMarket.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rpButtonMarket.DrawBorder = true;
            this.rpButtonMarket.Location = new System.Drawing.Point(220, 58);
            this.rpButtonMarket.Name = "rpButtonMarket";
            this.rpButtonMarket.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonMarket.Size = new System.Drawing.Size(63, 23);
            this.rpButtonMarket.TabIndex = 7;
            this.rpButtonMarket.Text = "Market";
            this.rpButtonMarket.Click += new System.EventHandler(this.RPButtonMarket_Click);
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
            this.rpButtonLiving.DrawBorder = true;
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
            this.rpButtonKitchen.DrawBorder = true;
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
            this.rpButtonCockpit.DrawBorder = true;
            this.rpButtonCockpit.Location = new System.Drawing.Point(289, 23);
            this.rpButtonCockpit.Name = "rpButtonCockpit";
            this.rpButtonCockpit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.rpButtonCockpit.Size = new System.Drawing.Size(63, 23);
            this.rpButtonCockpit.TabIndex = 6;
            this.rpButtonCockpit.Text = "Cockpit";
            this.rpButtonCockpit.Click += new System.EventHandler(this.RPButtonCockpit_Click);
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
            // buttonReserved
            // 
            this.buttonReserved.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonReserved.DrawBorder = true;
            this.buttonReserved.Location = new System.Drawing.Point(423, 50);
            this.buttonReserved.Name = "buttonReserved";
            this.buttonReserved.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonReserved.Size = new System.Drawing.Size(63, 23);
            this.buttonReserved.TabIndex = 6;
            this.buttonReserved.Text = "Reserved";
            // 
            // buttonStation
            // 
            this.buttonStation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonStation.DrawBorder = true;
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
            this.buttonShip.DrawBorder = true;
            this.buttonShip.Location = new System.Drawing.Point(354, 50);
            this.buttonShip.Name = "buttonShip";
            this.buttonShip.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonShip.Size = new System.Drawing.Size(63, 23);
            this.buttonShip.TabIndex = 4;
            this.buttonShip.Text = "Ship";
            this.buttonShip.Click += new System.EventHandler(this.ButtonShip_Click);
            // 
            // pbEnergy
            // 
            this.pbEnergy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbEnergy.BackColor = System.Drawing.Color.LightGray;
            this.pbEnergy.BorderColor = System.Drawing.Color.Black;
            this.pbEnergy.BorderWidth = 2;
            this.pbEnergy.ForeColor = System.Drawing.Color.Black;
            this.pbEnergy.Location = new System.Drawing.Point(286, 34);
            this.pbEnergy.MaxValue = 100;
            this.pbEnergy.MinValue = 0;
            this.pbEnergy.Name = "pbEnergy";
            this.pbEnergy.ProgressColor = System.Drawing.Color.BlueViolet;
            this.pbEnergy.ProgressTextType = RPElite.RPProgressBar.RPProgressTextType.Percent;
            this.pbEnergy.ShowProgressText = true;
            this.pbEnergy.Size = new System.Drawing.Size(200, 10);
            this.pbEnergy.TabIndex = 3;
            this.pbEnergy.Text = "Sleep";
            this.pbEnergy.Value = 86;
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
            // buttonExit
            // 
            this.buttonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonExit.DrawBorder = true;
            this.buttonExit.Location = new System.Drawing.Point(354, 265);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.buttonExit.Size = new System.Drawing.Size(63, 23);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Hit me";
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
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
        private RPProgressBar pbEnergy;
        private RPButton buttonShip;
        private RPButton buttonStation;
        private RPButton buttonReserved;
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
        private System.Windows.Forms.Label labelCredits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStationCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnLess;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCount;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnMore;
    }
}

