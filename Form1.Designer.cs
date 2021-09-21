
namespace Unique_Converter
{
    partial class UniqueConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label LengthConversion;
            System.Windows.Forms.Label TemperatureConversion;
            System.Windows.Forms.Label AreaConversion;
            this.TopPanel = new System.Windows.Forms.Panel();
            this.MaximizeBtn = new System.Windows.Forms.Button();
            this.AppName = new System.Windows.Forms.Label();
            this.AppCloseBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lengthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LengthPanel = new System.Windows.Forms.Panel();
            this.LengthConvertBtn = new System.Windows.Forms.Button();
            this.LengthResultTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ToLengthComboBox = new System.Windows.Forms.ComboBox();
            this.FromLengthComboBox = new System.Windows.Forms.ComboBox();
            this.TemperaturePanel = new System.Windows.Forms.Panel();
            this.TemperatureConvertBtn = new System.Windows.Forms.Button();
            this.TemperatureResultTextBox = new System.Windows.Forms.TextBox();
            this.TemperatureTextBox = new System.Windows.Forms.TextBox();
            this.ToTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.FromTemperatureComboBox = new System.Windows.Forms.ComboBox();
            this.AreaPanel = new System.Windows.Forms.Panel();
            this.AreaConvertBtn = new System.Windows.Forms.Button();
            this.AreaResultTextBox = new System.Windows.Forms.TextBox();
            this.AreaTextBox = new System.Windows.Forms.TextBox();
            this.ToAreaComboBox = new System.Windows.Forms.ComboBox();
            this.FromAreaComboBox = new System.Windows.Forms.ComboBox();
            LengthConversion = new System.Windows.Forms.Label();
            TemperatureConversion = new System.Windows.Forms.Label();
            AreaConversion = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.LengthPanel.SuspendLayout();
            this.TemperaturePanel.SuspendLayout();
            this.AreaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LengthConversion
            // 
            LengthConversion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            LengthConversion.AutoSize = true;
            LengthConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            LengthConversion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            LengthConversion.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LengthConversion.ForeColor = System.Drawing.Color.Black;
            LengthConversion.Location = new System.Drawing.Point(322, 40);
            LengthConversion.Name = "LengthConversion";
            LengthConversion.Size = new System.Drawing.Size(221, 39);
            LengthConversion.TabIndex = 0;
            LengthConversion.Text = "Length Converter";
            // 
            // TemperatureConversion
            // 
            TemperatureConversion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            TemperatureConversion.AutoSize = true;
            TemperatureConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            TemperatureConversion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            TemperatureConversion.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TemperatureConversion.ForeColor = System.Drawing.Color.Black;
            TemperatureConversion.Location = new System.Drawing.Point(297, 55);
            TemperatureConversion.Name = "TemperatureConversion";
            TemperatureConversion.Size = new System.Drawing.Size(282, 39);
            TemperatureConversion.TabIndex = 8;
            TemperatureConversion.Text = "Temperature Converter";
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.MaximizeBtn);
            this.TopPanel.Controls.Add(this.AppName);
            this.TopPanel.Controls.Add(this.AppCloseBtn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(877, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // MaximizeBtn
            // 
            this.MaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.MaximizeBtn.FlatAppearance.BorderSize = 0;
            this.MaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeBtn.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBtn.Location = new System.Drawing.Point(724, 3);
            this.MaximizeBtn.Name = "MaximizeBtn";
            this.MaximizeBtn.Size = new System.Drawing.Size(72, 44);
            this.MaximizeBtn.TabIndex = 2;
            this.MaximizeBtn.Text = "X";
            this.MaximizeBtn.UseVisualStyleBackColor = false;
            this.MaximizeBtn.Click += new System.EventHandler(this.MaximizeBtn_Click);
            this.MaximizeBtn.MouseLeave += new System.EventHandler(this.MaximizeBtn_MouseLeave);
            this.MaximizeBtn.MouseHover += new System.EventHandler(this.MaximizeBtn_MouseHover);
            // 
            // AppName
            // 
            this.AppName.AutoSize = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppName.ForeColor = System.Drawing.Color.Black;
            this.AppName.Location = new System.Drawing.Point(15, 9);
            this.AppName.Name = "AppName";
            this.AppName.Size = new System.Drawing.Size(226, 29);
            this.AppName.TabIndex = 1;
            this.AppName.Text = "Unique Converter";
            // 
            // AppCloseBtn
            // 
            this.AppCloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AppCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.AppCloseBtn.FlatAppearance.BorderSize = 0;
            this.AppCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AppCloseBtn.ForeColor = System.Drawing.Color.Black;
            this.AppCloseBtn.Location = new System.Drawing.Point(802, 3);
            this.AppCloseBtn.Name = "AppCloseBtn";
            this.AppCloseBtn.Size = new System.Drawing.Size(72, 44);
            this.AppCloseBtn.TabIndex = 0;
            this.AppCloseBtn.Text = "X";
            this.AppCloseBtn.UseVisualStyleBackColor = false;
            this.AppCloseBtn.Click += new System.EventHandler(this.AppCloseBtn_Click);
            this.AppCloseBtn.MouseLeave += new System.EventHandler(this.AppCloseBtn_MouseLeave);
            this.AppCloseBtn.MouseHover += new System.EventHandler(this.AppCloseBtn_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lengthToolStripMenuItem,
            this.temperatureToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.volumeToolStripMenuItem,
            this.weightToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 36);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lengthToolStripMenuItem
            // 
            this.lengthToolStripMenuItem.Name = "lengthToolStripMenuItem";
            this.lengthToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.lengthToolStripMenuItem.Text = "Length";
            this.lengthToolStripMenuItem.Click += new System.EventHandler(this.lengthToolStripMenuItem_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(126, 32);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.areaToolStripMenuItem_Click);
            // 
            // volumeToolStripMenuItem
            // 
            this.volumeToolStripMenuItem.Name = "volumeToolStripMenuItem";
            this.volumeToolStripMenuItem.Size = new System.Drawing.Size(88, 32);
            this.volumeToolStripMenuItem.Text = "Volume";
            // 
            // weightToolStripMenuItem
            // 
            this.weightToolStripMenuItem.Name = "weightToolStripMenuItem";
            this.weightToolStripMenuItem.Size = new System.Drawing.Size(84, 32);
            this.weightToolStripMenuItem.Text = "Weight";
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(66, 32);
            this.timeToolStripMenuItem.Text = "Time";
            // 
            // LengthPanel
            // 
            this.LengthPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LengthPanel.Controls.Add(this.LengthConvertBtn);
            this.LengthPanel.Controls.Add(this.LengthResultTextBox);
            this.LengthPanel.Controls.Add(this.LengthTextBox);
            this.LengthPanel.Controls.Add(this.ToLengthComboBox);
            this.LengthPanel.Controls.Add(this.FromLengthComboBox);
            this.LengthPanel.Controls.Add(LengthConversion);
            this.LengthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LengthPanel.Location = new System.Drawing.Point(0, 86);
            this.LengthPanel.Name = "LengthPanel";
            this.LengthPanel.Size = new System.Drawing.Size(877, 442);
            this.LengthPanel.TabIndex = 2;
            // 
            // LengthConvertBtn
            // 
            this.LengthConvertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LengthConvertBtn.BackColor = System.Drawing.Color.Black;
            this.LengthConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthConvertBtn.ForeColor = System.Drawing.Color.White;
            this.LengthConvertBtn.Location = new System.Drawing.Point(335, 307);
            this.LengthConvertBtn.Name = "LengthConvertBtn";
            this.LengthConvertBtn.Size = new System.Drawing.Size(192, 62);
            this.LengthConvertBtn.TabIndex = 6;
            this.LengthConvertBtn.Text = "Convert";
            this.LengthConvertBtn.UseVisualStyleBackColor = false;
            this.LengthConvertBtn.Click += new System.EventHandler(this.LengthConvertBtn_Click);
            // 
            // LengthResultTextBox
            // 
            this.LengthResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LengthResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthResultTextBox.Location = new System.Drawing.Point(142, 237);
            this.LengthResultTextBox.Name = "LengthResultTextBox";
            this.LengthResultTextBox.ReadOnly = true;
            this.LengthResultTextBox.Size = new System.Drawing.Size(584, 37);
            this.LengthResultTextBox.TabIndex = 0;
            this.LengthResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LengthTextBox.BackColor = System.Drawing.Color.White;
            this.LengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthTextBox.Location = new System.Drawing.Point(322, 177);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(221, 32);
            this.LengthTextBox.TabIndex = 3;
            this.LengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToLengthComboBox
            // 
            this.ToLengthComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToLengthComboBox.BackColor = System.Drawing.Color.White;
            this.ToLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToLengthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToLengthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLengthComboBox.ForeColor = System.Drawing.Color.Black;
            this.ToLengthComboBox.FormattingEnabled = true;
            this.ToLengthComboBox.Items.AddRange(new object[] {
            "Kilometre",
            "Meter",
            "Centimeter",
            "Millimetre",
            "Micrometres",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.ToLengthComboBox.Location = new System.Drawing.Point(502, 107);
            this.ToLengthComboBox.Name = "ToLengthComboBox";
            this.ToLengthComboBox.Size = new System.Drawing.Size(186, 34);
            this.ToLengthComboBox.TabIndex = 2;
            // 
            // FromLengthComboBox
            // 
            this.FromLengthComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromLengthComboBox.BackColor = System.Drawing.Color.White;
            this.FromLengthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromLengthComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromLengthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromLengthComboBox.ForeColor = System.Drawing.Color.Black;
            this.FromLengthComboBox.FormattingEnabled = true;
            this.FromLengthComboBox.Items.AddRange(new object[] {
            "Kilometre",
            "Meter",
            "Centimeter",
            "Millimetre",
            "Micrometres",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.FromLengthComboBox.Location = new System.Drawing.Point(179, 107);
            this.FromLengthComboBox.Name = "FromLengthComboBox";
            this.FromLengthComboBox.Size = new System.Drawing.Size(186, 34);
            this.FromLengthComboBox.TabIndex = 1;
            // 
            // TemperaturePanel
            // 
            this.TemperaturePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TemperaturePanel.Controls.Add(this.TemperatureConvertBtn);
            this.TemperaturePanel.Controls.Add(this.TemperatureResultTextBox);
            this.TemperaturePanel.Controls.Add(this.TemperatureTextBox);
            this.TemperaturePanel.Controls.Add(this.ToTemperatureComboBox);
            this.TemperaturePanel.Controls.Add(this.FromTemperatureComboBox);
            this.TemperaturePanel.Controls.Add(TemperatureConversion);
            this.TemperaturePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TemperaturePanel.Location = new System.Drawing.Point(0, 86);
            this.TemperaturePanel.Name = "TemperaturePanel";
            this.TemperaturePanel.Size = new System.Drawing.Size(877, 442);
            this.TemperaturePanel.TabIndex = 7;
            // 
            // TemperatureConvertBtn
            // 
            this.TemperatureConvertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureConvertBtn.BackColor = System.Drawing.Color.Black;
            this.TemperatureConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureConvertBtn.ForeColor = System.Drawing.Color.White;
            this.TemperatureConvertBtn.Location = new System.Drawing.Point(337, 322);
            this.TemperatureConvertBtn.Name = "TemperatureConvertBtn";
            this.TemperatureConvertBtn.Size = new System.Drawing.Size(192, 62);
            this.TemperatureConvertBtn.TabIndex = 12;
            this.TemperatureConvertBtn.Text = "Convert";
            this.TemperatureConvertBtn.UseVisualStyleBackColor = false;
            this.TemperatureConvertBtn.Click += new System.EventHandler(this.TemperatureConvertBtn_Click);
            // 
            // TemperatureResultTextBox
            // 
            this.TemperatureResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureResultTextBox.Location = new System.Drawing.Point(144, 252);
            this.TemperatureResultTextBox.Name = "TemperatureResultTextBox";
            this.TemperatureResultTextBox.ReadOnly = true;
            this.TemperatureResultTextBox.Size = new System.Drawing.Size(584, 37);
            this.TemperatureResultTextBox.TabIndex = 7;
            this.TemperatureResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TemperatureTextBox
            // 
            this.TemperatureTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TemperatureTextBox.BackColor = System.Drawing.Color.White;
            this.TemperatureTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureTextBox.Location = new System.Drawing.Point(324, 192);
            this.TemperatureTextBox.Name = "TemperatureTextBox";
            this.TemperatureTextBox.Size = new System.Drawing.Size(221, 32);
            this.TemperatureTextBox.TabIndex = 11;
            this.TemperatureTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToTemperatureComboBox
            // 
            this.ToTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToTemperatureComboBox.BackColor = System.Drawing.Color.White;
            this.ToTemperatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToTemperatureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToTemperatureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTemperatureComboBox.ForeColor = System.Drawing.Color.Black;
            this.ToTemperatureComboBox.FormattingEnabled = true;
            this.ToTemperatureComboBox.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit",
            "Rankine",
            "Reaumur",
            "Triple Point Of Water"});
            this.ToTemperatureComboBox.Location = new System.Drawing.Point(504, 122);
            this.ToTemperatureComboBox.Name = "ToTemperatureComboBox";
            this.ToTemperatureComboBox.Size = new System.Drawing.Size(186, 34);
            this.ToTemperatureComboBox.TabIndex = 10;
            // 
            // FromTemperatureComboBox
            // 
            this.FromTemperatureComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromTemperatureComboBox.BackColor = System.Drawing.Color.White;
            this.FromTemperatureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromTemperatureComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromTemperatureComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTemperatureComboBox.ForeColor = System.Drawing.Color.Black;
            this.FromTemperatureComboBox.FormattingEnabled = true;
            this.FromTemperatureComboBox.Items.AddRange(new object[] {
            "Celsius",
            "Kelvin",
            "Fahrenheit",
            "Rankine",
            "Reaumur",
            "Triple Point Of Water"});
            this.FromTemperatureComboBox.Location = new System.Drawing.Point(181, 122);
            this.FromTemperatureComboBox.Name = "FromTemperatureComboBox";
            this.FromTemperatureComboBox.Size = new System.Drawing.Size(186, 34);
            this.FromTemperatureComboBox.TabIndex = 9;
            // 
            // AreaPanel
            // 
            this.AreaPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AreaPanel.Controls.Add(this.AreaConvertBtn);
            this.AreaPanel.Controls.Add(this.AreaResultTextBox);
            this.AreaPanel.Controls.Add(this.AreaTextBox);
            this.AreaPanel.Controls.Add(this.ToAreaComboBox);
            this.AreaPanel.Controls.Add(this.FromAreaComboBox);
            this.AreaPanel.Controls.Add(AreaConversion);
            this.AreaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AreaPanel.Location = new System.Drawing.Point(0, 86);
            this.AreaPanel.Name = "AreaPanel";
            this.AreaPanel.Size = new System.Drawing.Size(877, 442);
            this.AreaPanel.TabIndex = 3;
            // 
            // AreaConvertBtn
            // 
            this.AreaConvertBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AreaConvertBtn.BackColor = System.Drawing.Color.Black;
            this.AreaConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaConvertBtn.ForeColor = System.Drawing.Color.White;
            this.AreaConvertBtn.Location = new System.Drawing.Point(335, 307);
            this.AreaConvertBtn.Name = "AreaConvertBtn";
            this.AreaConvertBtn.Size = new System.Drawing.Size(192, 62);
            this.AreaConvertBtn.TabIndex = 6;
            this.AreaConvertBtn.Text = "Convert";
            this.AreaConvertBtn.UseVisualStyleBackColor = false;
            this.AreaConvertBtn.Click += new System.EventHandler(this.AreaConvertBtn_Click);
            // 
            // AreaResultTextBox
            // 
            this.AreaResultTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AreaResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaResultTextBox.Location = new System.Drawing.Point(142, 237);
            this.AreaResultTextBox.Name = "AreaResultTextBox";
            this.AreaResultTextBox.ReadOnly = true;
            this.AreaResultTextBox.Size = new System.Drawing.Size(584, 37);
            this.AreaResultTextBox.TabIndex = 0;
            this.AreaResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AreaTextBox
            // 
            this.AreaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AreaTextBox.BackColor = System.Drawing.Color.White;
            this.AreaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaTextBox.Location = new System.Drawing.Point(322, 177);
            this.AreaTextBox.Name = "AreaTextBox";
            this.AreaTextBox.Size = new System.Drawing.Size(221, 32);
            this.AreaTextBox.TabIndex = 3;
            this.AreaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ToAreaComboBox
            // 
            this.ToAreaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ToAreaComboBox.BackColor = System.Drawing.Color.White;
            this.ToAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToAreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToAreaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToAreaComboBox.ForeColor = System.Drawing.Color.Black;
            this.ToAreaComboBox.FormattingEnabled = true;
            this.ToAreaComboBox.Items.AddRange(new object[] {
            "Kilometre",
            "Meter",
            "Centimeter",
            "Millimetre",
            "Micrometres",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.ToAreaComboBox.Location = new System.Drawing.Point(502, 107);
            this.ToAreaComboBox.Name = "ToAreaComboBox";
            this.ToAreaComboBox.Size = new System.Drawing.Size(186, 34);
            this.ToAreaComboBox.TabIndex = 2;
            // 
            // FromAreaComboBox
            // 
            this.FromAreaComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FromAreaComboBox.BackColor = System.Drawing.Color.White;
            this.FromAreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FromAreaComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FromAreaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromAreaComboBox.ForeColor = System.Drawing.Color.Black;
            this.FromAreaComboBox.FormattingEnabled = true;
            this.FromAreaComboBox.Items.AddRange(new object[] {
            "Kilometre",
            "Meter",
            "Centimeter",
            "Millimetre",
            "Micrometres",
            "Nanometre",
            "Mile",
            "Yard",
            "Foot",
            "Inch",
            "Nautical Mile"});
            this.FromAreaComboBox.Location = new System.Drawing.Point(179, 107);
            this.FromAreaComboBox.Name = "FromAreaComboBox";
            this.FromAreaComboBox.Size = new System.Drawing.Size(186, 34);
            this.FromAreaComboBox.TabIndex = 1;
            // 
            // AreaConversion
            // 
            AreaConversion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            AreaConversion.AutoSize = true;
            AreaConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            AreaConversion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            AreaConversion.Font = new System.Drawing.Font("Monotype Corsiva", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            AreaConversion.ForeColor = System.Drawing.Color.Black;
            AreaConversion.Location = new System.Drawing.Point(330, 40);
            AreaConversion.Name = "AreaConversion";
            AreaConversion.Size = new System.Drawing.Size(194, 39);
            AreaConversion.TabIndex = 0;
            AreaConversion.Text = "Area Converter";
            // 
            // UniqueConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(877, 528);
            this.Controls.Add(this.AreaPanel);
            this.Controls.Add(this.TemperaturePanel);
            this.Controls.Add(this.LengthPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UniqueConverter";
            this.Text = "Unique Converter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.LengthPanel.ResumeLayout(false);
            this.LengthPanel.PerformLayout();
            this.TemperaturePanel.ResumeLayout(false);
            this.TemperaturePanel.PerformLayout();
            this.AreaPanel.ResumeLayout(false);
            this.AreaPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lengthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.Button AppCloseBtn;
        private System.Windows.Forms.Panel LengthPanel;
        private System.Windows.Forms.Label AppName;
        private System.Windows.Forms.Button MaximizeBtn;
        private System.Windows.Forms.ComboBox FromLengthComboBox;
        private System.Windows.Forms.ComboBox ToLengthComboBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox LengthResultTextBox;
        private System.Windows.Forms.Button LengthConvertBtn;
        private System.Windows.Forms.Panel TemperaturePanel;
        private System.Windows.Forms.Button TemperatureConvertBtn;
        private System.Windows.Forms.TextBox TemperatureResultTextBox;
        private System.Windows.Forms.TextBox TemperatureTextBox;
        private System.Windows.Forms.ComboBox ToTemperatureComboBox;
        private System.Windows.Forms.ComboBox FromTemperatureComboBox;
        private System.Windows.Forms.Panel AreaPanel;
        private System.Windows.Forms.Button AreaConvertBtn;
        private System.Windows.Forms.TextBox AreaResultTextBox;
        private System.Windows.Forms.TextBox AreaTextBox;
        private System.Windows.Forms.ComboBox ToAreaComboBox;
        private System.Windows.Forms.ComboBox FromAreaComboBox;
    }
}

