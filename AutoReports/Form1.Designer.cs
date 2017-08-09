namespace AutoReports
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radioButtonLocal = new System.Windows.Forms.RadioButton();
            this.radioButtonITG = new System.Windows.Forms.RadioButton();
            this.radioButtonProd = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroButtonEjecutar = new MetroFramework.Controls.MetroButton();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCargar = new MetroFramework.Controls.MetroButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.QueryTextBox = new MetroFramework.Controls.MetroTextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroRadioButton5 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonLocal
            // 
            this.radioButtonLocal.AutoSize = true;
            this.radioButtonLocal.Checked = true;
            this.radioButtonLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonLocal.Location = new System.Drawing.Point(12, 50);
            this.radioButtonLocal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonLocal.Name = "radioButtonLocal";
            this.radioButtonLocal.Size = new System.Drawing.Size(51, 17);
            this.radioButtonLocal.TabIndex = 3;
            this.radioButtonLocal.TabStop = true;
            this.radioButtonLocal.Text = "Local";
            this.radioButtonLocal.UseVisualStyleBackColor = true;
            this.radioButtonLocal.CheckedChanged += new System.EventHandler(this.radioButtonProd_CheckedChanged);
            // 
            // radioButtonITG
            // 
            this.radioButtonITG.AutoSize = true;
            this.radioButtonITG.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonITG.Location = new System.Drawing.Point(12, 72);
            this.radioButtonITG.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonITG.Name = "radioButtonITG";
            this.radioButtonITG.Size = new System.Drawing.Size(43, 17);
            this.radioButtonITG.TabIndex = 4;
            this.radioButtonITG.Text = "ITG";
            this.radioButtonITG.UseVisualStyleBackColor = true;
            this.radioButtonITG.CheckedChanged += new System.EventHandler(this.radioButtonProd_CheckedChanged);
            // 
            // radioButtonProd
            // 
            this.radioButtonProd.AutoSize = true;
            this.radioButtonProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonProd.Location = new System.Drawing.Point(12, 29);
            this.radioButtonProd.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.radioButtonProd.Name = "radioButtonProd";
            this.radioButtonProd.Size = new System.Drawing.Size(79, 17);
            this.radioButtonProd.TabIndex = 5;
            this.radioButtonProd.Text = "Producción";
            this.radioButtonProd.UseVisualStyleBackColor = true;
            this.radioButtonProd.CheckedChanged += new System.EventHandler(this.radioButtonProd_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.toolStripProgressBar1,
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(14, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(868, 35);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.DropDownButtonWidth = 0;
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(25, 33);
            this.toolStripSplitButton1.Text = "toolStripSplitButton1";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton2.DropDownButtonWidth = 1;
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(26, 33);
            this.toolStripSplitButton2.Text = "toolStripSplitButton2";
            this.toolStripSplitButton2.ButtonClick += new System.EventHandler(this.toolStripSplitButton2_ButtonClick);
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(74, 29);
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(81, 30);
            this.StatusLabel1.Text = "Conectando...";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Controls.Add(this.radioButtonLocal);
            this.panel1.Controls.Add(this.radioButtonProd);
            this.panel1.Controls.Add(this.radioButtonITG);
            this.panel1.Location = new System.Drawing.Point(10, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 97);
            this.panel1.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 4);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(80, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Servidor DB";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.metroButtonEjecutar);
            this.panel3.Controls.Add(this.metroButtonGuardar);
            this.panel3.Controls.Add(this.metroButtonCargar);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 358);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(866, 106);
            this.panel3.TabIndex = 9;
            // 
            // metroButtonEjecutar
            // 
            this.metroButtonEjecutar.Location = new System.Drawing.Point(124, 18);
            this.metroButtonEjecutar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButtonEjecutar.Name = "metroButtonEjecutar";
            this.metroButtonEjecutar.Size = new System.Drawing.Size(106, 69);
            this.metroButtonEjecutar.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroButtonEjecutar.TabIndex = 0;
            this.metroButtonEjecutar.Text = "Ejecutar";
            this.metroButtonEjecutar.UseSelectable = true;
            this.metroButtonEjecutar.UseStyleColors = true;
            this.metroButtonEjecutar.Click += new System.EventHandler(this.metroButtonEjecutar_Click);
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.Location = new System.Drawing.Point(244, 55);
            this.metroButtonGuardar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(106, 32);
            this.metroButtonGuardar.TabIndex = 10;
            this.metroButtonGuardar.Text = "Guardar Script";
            this.metroButtonGuardar.UseSelectable = true;
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
            // 
            // metroButtonCargar
            // 
            this.metroButtonCargar.Location = new System.Drawing.Point(244, 18);
            this.metroButtonCargar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButtonCargar.Name = "metroButtonCargar";
            this.metroButtonCargar.Size = new System.Drawing.Size(106, 29);
            this.metroButtonCargar.TabIndex = 9;
            this.metroButtonCargar.Text = "Cargar Script";
            this.metroButtonCargar.UseSelectable = true;
            this.metroButtonCargar.Click += new System.EventHandler(this.metroButtonCargar_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.metroTabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(866, 464);
            this.panel4.TabIndex = 11;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(864, 362);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.UseStyleColors = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel7);
            this.tabPage1.Controls.Add(this.panel6);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(856, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reports";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.QueryTextBox);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(687, 320);
            this.panel7.TabIndex = 1;
            // 
            // QueryTextBox
            // 
            // 
            // 
            // 
            this.QueryTextBox.CustomButton.Image = null;
            this.QueryTextBox.CustomButton.Location = new System.Drawing.Point(373, 2);
            this.QueryTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryTextBox.CustomButton.Name = "";
            this.QueryTextBox.CustomButton.Size = new System.Drawing.Size(315, 315);
            this.QueryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QueryTextBox.CustomButton.TabIndex = 1;
            this.QueryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QueryTextBox.CustomButton.UseSelectable = true;
            this.QueryTextBox.CustomButton.Visible = false;
            this.QueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QueryTextBox.Lines = new string[] {
        "Query"};
            this.QueryTextBox.Location = new System.Drawing.Point(0, 0);
            this.QueryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.QueryTextBox.MaxLength = 32767;
            this.QueryTextBox.Multiline = true;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.PasswordChar = '\0';
            this.QueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QueryTextBox.SelectedText = "";
            this.QueryTextBox.SelectionLength = 0;
            this.QueryTextBox.SelectionStart = 0;
            this.QueryTextBox.ShortcutsEnabled = true;
            this.QueryTextBox.Size = new System.Drawing.Size(687, 320);
            this.QueryTextBox.TabIndex = 11;
            this.QueryTextBox.Text = "Query";
            this.QueryTextBox.UseSelectable = true;
            this.QueryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QueryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(687, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 320);
            this.panel6.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.metroDateTime1);
            this.panel2.Controls.Add(this.metroRadioButton5);
            this.panel2.Controls.Add(this.metroRadioButton4);
            this.panel2.Controls.Add(this.metroRadioButton3);
            this.panel2.Controls.Add(this.metroRadioButton2);
            this.panel2.Controls.Add(this.metroRadioButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 320);
            this.panel2.TabIndex = 10;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Checked = false;
            this.metroDateTime1.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime1.Location = new System.Drawing.Point(14, 127);
            this.metroDateTime1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 25);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.ShowCheckBox = true;
            this.metroDateTime1.Size = new System.Drawing.Size(114, 25);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroDateTime1.TabIndex = 17;
            this.metroDateTime1.UseStyleColors = true;
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroRadioButton5
            // 
            this.metroRadioButton5.AutoSize = true;
            this.metroRadioButton5.Location = new System.Drawing.Point(14, 106);
            this.metroRadioButton5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroRadioButton5.Name = "metroRadioButton5";
            this.metroRadioButton5.Size = new System.Drawing.Size(71, 15);
            this.metroRadioButton5.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroRadioButton5.TabIndex = 16;
            this.metroRadioButton5.Text = "LogTrace";
            this.metroRadioButton5.UseSelectable = true;
            this.metroRadioButton5.UseStyleColors = true;
            this.metroRadioButton5.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton4
            // 
            this.metroRadioButton4.AutoSize = true;
            this.metroRadioButton4.Location = new System.Drawing.Point(14, 87);
            this.metroRadioButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroRadioButton4.Name = "metroRadioButton4";
            this.metroRadioButton4.Size = new System.Drawing.Size(109, 15);
            this.metroRadioButton4.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroRadioButton4.TabIndex = 15;
            this.metroRadioButton4.Text = "Rules Applies To";
            this.metroRadioButton4.UseSelectable = true;
            this.metroRadioButton4.UseStyleColors = true;
            this.metroRadioButton4.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton3
            // 
            this.metroRadioButton3.AutoSize = true;
            this.metroRadioButton3.Location = new System.Drawing.Point(14, 68);
            this.metroRadioButton3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroRadioButton3.Name = "metroRadioButton3";
            this.metroRadioButton3.Size = new System.Drawing.Size(107, 15);
            this.metroRadioButton3.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroRadioButton3.TabIndex = 14;
            this.metroRadioButton3.Text = "Rules Affects To";
            this.metroRadioButton3.UseSelectable = true;
            this.metroRadioButton3.UseStyleColors = true;
            this.metroRadioButton3.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(14, 49);
            this.metroRadioButton2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(70, 15);
            this.metroRadioButton2.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroRadioButton2.TabIndex = 13;
            this.metroRadioButton2.Text = "Products";
            this.metroRadioButton2.UseSelectable = true;
            this.metroRadioButton2.UseStyleColors = true;
            this.metroRadioButton2.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(14, 30);
            this.metroRadioButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(99, 15);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroRadioButton1.TabIndex = 12;
            this.metroRadioButton1.Text = "Weekly Report";
            this.metroRadioButton1.UseSelectable = true;
            this.metroRadioButton1.UseStyleColors = true;
            this.metroRadioButton1.CheckedChanged += new System.EventHandler(this.metroRadioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Query";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(14, 49);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(868, 466);
            this.panel5.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(896, 566);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(14, 49, 14, 16);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.Style = MetroFramework.MetroColorStyle.Brown;
            this.Text = "AutoReports";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.RadioButton radioButtonLocal;
        public System.Windows.Forms.RadioButton radioButtonITG;
        public System.Windows.Forms.RadioButton radioButtonProd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton metroButtonEjecutar;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonCargar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroTextBox QueryTextBox;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton4;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton3;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private System.Windows.Forms.Label label1;
    }
}

