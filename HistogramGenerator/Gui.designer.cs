namespace HistogramGenerator
{
    /// <summary>
    /// GUI
    /// </summary>
    partial class Gui
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
            this.txtInput_Window = new System.Windows.Forms.TextBox();
            this.Input_Data_label = new System.Windows.Forms.Label();
            this.H_Decimal_label = new System.Windows.Forms.Label();
            this.H_NoDecimals = new System.Windows.Forms.Button();
            this.H_1Decimal = new System.Windows.Forms.Button();
            this.H_2Decimals = new System.Windows.Forms.Button();
            this.H_3Decimals = new System.Windows.Forms.Button();
            this.V_Decimal_label = new System.Windows.Forms.Label();
            this.Number_of_Ticks = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.NumberofTicks_label = new System.Windows.Forms.Label();
            this.Tick_Interval_label = new System.Windows.Forms.Label();
            this.Tick_Interval_TextBox = new System.Windows.Forms.TextBox();
            this.Label_Start_label = new System.Windows.Forms.Label();
            this.Label_Stop_label = new System.Windows.Forms.Label();
            this.Label_Start_textBox = new System.Windows.Forms.TextBox();
            this.Label_Stop_textBox = new System.Windows.Forms.TextBox();
            this.Update_Histogram = new System.Windows.Forms.Button();
            this.Number_of_Bins_label = new System.Windows.Forms.Label();
            this.Number_of_Bins = new System.Windows.Forms.HScrollBar();
            this.LcL_textBox = new System.Windows.Forms.TextBox();
            this.LcL_label = new System.Windows.Forms.Label();
            this.UcL_textBox = new System.Windows.Forms.TextBox();
            this.UcL_label = new System.Windows.Forms.Label();
            this.V_3Decimals = new System.Windows.Forms.Button();
            this.V_2Decimals = new System.Windows.Forms.Button();
            this.V_1Decimals = new System.Windows.Forms.Button();
            this.V_0Decimals = new System.Windows.Forms.Button();
            this.ViewFullscreen = new System.Windows.Forms.Button();
            this.Input_Data_Button = new System.Windows.Forms.Button();
            this.HistoGram_pictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataTest = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTesterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTextFieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gibsonBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloKittyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barlabel = new System.Windows.Forms.Label();
            this.ticklabe = new System.Windows.Forms.Label();
            this.panelOptions1 = new System.Windows.Forms.Panel();
            this.panelOptions2 = new System.Windows.Forms.Panel();
            this.advancedOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.HistoGram_pictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelOptions1.SuspendLayout();
            this.panelOptions2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput_Window
            // 
            this.txtInput_Window.Location = new System.Drawing.Point(8, 50);
            this.txtInput_Window.Multiline = true;
            this.txtInput_Window.Name = "txtInput_Window";
            this.txtInput_Window.Size = new System.Drawing.Size(156, 250);
            this.txtInput_Window.TabIndex = 2;
            // 
            // Input_Data_label
            // 
            this.Input_Data_label.AutoSize = true;
            this.Input_Data_label.Location = new System.Drawing.Point(5, 34);
            this.Input_Data_label.Name = "Input_Data_label";
            this.Input_Data_label.Size = new System.Drawing.Size(57, 13);
            this.Input_Data_label.TabIndex = 3;
            this.Input_Data_label.Text = "Input Data";
            // 
            // H_Decimal_label
            // 
            this.H_Decimal_label.AutoSize = true;
            this.H_Decimal_label.Location = new System.Drawing.Point(4, 9);
            this.H_Decimal_label.Name = "H_Decimal_label";
            this.H_Decimal_label.Size = new System.Drawing.Size(129, 13);
            this.H_Decimal_label.TabIndex = 6;
            this.H_Decimal_label.Text = "Horizonal Label Decimals:";
            // 
            // H_NoDecimals
            // 
            this.H_NoDecimals.Location = new System.Drawing.Point(134, 6);
            this.H_NoDecimals.Name = "H_NoDecimals";
            this.H_NoDecimals.Size = new System.Drawing.Size(23, 23);
            this.H_NoDecimals.TabIndex = 7;
            this.H_NoDecimals.Text = "0";
            this.H_NoDecimals.UseVisualStyleBackColor = true;
            this.H_NoDecimals.Click += new System.EventHandler(this.H_NoDecimals_Click);
            // 
            // H_1Decimal
            // 
            this.H_1Decimal.Location = new System.Drawing.Point(163, 6);
            this.H_1Decimal.Name = "H_1Decimal";
            this.H_1Decimal.Size = new System.Drawing.Size(23, 23);
            this.H_1Decimal.TabIndex = 8;
            this.H_1Decimal.Text = "1";
            this.H_1Decimal.UseVisualStyleBackColor = true;
            this.H_1Decimal.Click += new System.EventHandler(this.H_1Decimal_Click);
            // 
            // H_2Decimals
            // 
            this.H_2Decimals.Location = new System.Drawing.Point(193, 6);
            this.H_2Decimals.Name = "H_2Decimals";
            this.H_2Decimals.Size = new System.Drawing.Size(23, 23);
            this.H_2Decimals.TabIndex = 9;
            this.H_2Decimals.Text = "2";
            this.H_2Decimals.UseVisualStyleBackColor = true;
            this.H_2Decimals.Click += new System.EventHandler(this.H_2Decimals_Click);
            // 
            // H_3Decimals
            // 
            this.H_3Decimals.Location = new System.Drawing.Point(222, 6);
            this.H_3Decimals.Name = "H_3Decimals";
            this.H_3Decimals.Size = new System.Drawing.Size(23, 23);
            this.H_3Decimals.TabIndex = 10;
            this.H_3Decimals.Text = "3";
            this.H_3Decimals.UseVisualStyleBackColor = true;
            this.H_3Decimals.Click += new System.EventHandler(this.H_3Decimals_Click);
            // 
            // V_Decimal_label
            // 
            this.V_Decimal_label.AutoSize = true;
            this.V_Decimal_label.Location = new System.Drawing.Point(4, 36);
            this.V_Decimal_label.Name = "V_Decimal_label";
            this.V_Decimal_label.Size = new System.Drawing.Size(120, 13);
            this.V_Decimal_label.TabIndex = 11;
            this.V_Decimal_label.Text = "Vertical Label Decimals:";
            // 
            // Number_of_Ticks
            // 
            this.Number_of_Ticks.LargeChange = 1;
            this.Number_of_Ticks.Location = new System.Drawing.Point(277, 486);
            this.Number_of_Ticks.Maximum = 20;
            this.Number_of_Ticks.Minimum = 3;
            this.Number_of_Ticks.Name = "Number_of_Ticks";
            this.Number_of_Ticks.Size = new System.Drawing.Size(345, 17);
            this.Number_of_Ticks.TabIndex = 16;
            this.Number_of_Ticks.Value = 3;
            this.Number_of_Ticks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Number_of_Ticks_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Options";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NumberofTicks_label
            // 
            this.NumberofTicks_label.AutoSize = true;
            this.NumberofTicks_label.Location = new System.Drawing.Point(189, 486);
            this.NumberofTicks_label.Name = "NumberofTicks_label";
            this.NumberofTicks_label.Size = new System.Drawing.Size(85, 13);
            this.NumberofTicks_label.TabIndex = 18;
            this.NumberofTicks_label.Text = "Number of Ticks";
            // 
            // Tick_Interval_label
            // 
            this.Tick_Interval_label.AutoSize = true;
            this.Tick_Interval_label.Location = new System.Drawing.Point(6, 34);
            this.Tick_Interval_label.Name = "Tick_Interval_label";
            this.Tick_Interval_label.Size = new System.Drawing.Size(69, 13);
            this.Tick_Interval_label.TabIndex = 19;
            this.Tick_Interval_label.Text = "Tick Interval:";
            // 
            // Tick_Interval_TextBox
            // 
            this.Tick_Interval_TextBox.Location = new System.Drawing.Point(70, 28);
            this.Tick_Interval_TextBox.Name = "Tick_Interval_TextBox";
            this.Tick_Interval_TextBox.Size = new System.Drawing.Size(95, 20);
            this.Tick_Interval_TextBox.TabIndex = 20;
            this.Tick_Interval_TextBox.TextChanged += new System.EventHandler(this.Tick_Interval_TextBox_TextChanged_1);
            // 
            // Label_Start_label
            // 
            this.Label_Start_label.AutoSize = true;
            this.Label_Start_label.Location = new System.Drawing.Point(6, 104);
            this.Label_Start_label.Name = "Label_Start_label";
            this.Label_Start_label.Size = new System.Drawing.Size(61, 13);
            this.Label_Start_label.TabIndex = 22;
            this.Label_Start_label.Text = "Label Start:";
            // 
            // Label_Stop_label
            // 
            this.Label_Stop_label.AutoSize = true;
            this.Label_Stop_label.Location = new System.Drawing.Point(9, 130);
            this.Label_Stop_label.Name = "Label_Stop_label";
            this.Label_Stop_label.Size = new System.Drawing.Size(61, 13);
            this.Label_Stop_label.TabIndex = 23;
            this.Label_Stop_label.Text = "Label Stop:";
            // 
            // Label_Start_textBox
            // 
            this.Label_Start_textBox.Location = new System.Drawing.Point(67, 101);
            this.Label_Start_textBox.Name = "Label_Start_textBox";
            this.Label_Start_textBox.Size = new System.Drawing.Size(98, 20);
            this.Label_Start_textBox.TabIndex = 25;
            // 
            // Label_Stop_textBox
            // 
            this.Label_Stop_textBox.Location = new System.Drawing.Point(67, 124);
            this.Label_Stop_textBox.Name = "Label_Stop_textBox";
            this.Label_Stop_textBox.Size = new System.Drawing.Size(98, 20);
            this.Label_Stop_textBox.TabIndex = 26;
            // 
            // Update_Histogram
            // 
            this.Update_Histogram.Location = new System.Drawing.Point(26, 178);
            this.Update_Histogram.Name = "Update_Histogram";
            this.Update_Histogram.Size = new System.Drawing.Size(113, 23);
            this.Update_Histogram.TabIndex = 28;
            this.Update_Histogram.Text = "Update ";
            this.Update_Histogram.UseVisualStyleBackColor = true;
            this.Update_Histogram.Click += new System.EventHandler(this.Update_Histogram_Click);
            // 
            // Number_of_Bins_label
            // 
            this.Number_of_Bins_label.AutoSize = true;
            this.Number_of_Bins_label.Location = new System.Drawing.Point(189, 464);
            this.Number_of_Bins_label.Name = "Number_of_Bins_label";
            this.Number_of_Bins_label.Size = new System.Drawing.Size(79, 13);
            this.Number_of_Bins_label.TabIndex = 32;
            this.Number_of_Bins_label.Text = "Number of Bins";
            // 
            // Number_of_Bins
            // 
            this.Number_of_Bins.LargeChange = 1;
            this.Number_of_Bins.Location = new System.Drawing.Point(271, 460);
            this.Number_of_Bins.Maximum = 20;
            this.Number_of_Bins.Minimum = 3;
            this.Number_of_Bins.Name = "Number_of_Bins";
            this.Number_of_Bins.Size = new System.Drawing.Size(351, 17);
            this.Number_of_Bins.TabIndex = 31;
            this.Number_of_Bins.Value = 3;
            this.Number_of_Bins.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Number_of_Bins_Scroll);
            // 
            // LcL_textBox
            // 
            this.LcL_textBox.Location = new System.Drawing.Point(101, 49);
            this.LcL_textBox.Name = "LcL_textBox";
            this.LcL_textBox.Size = new System.Drawing.Size(64, 20);
            this.LcL_textBox.TabIndex = 34;
            this.LcL_textBox.TextChanged += new System.EventHandler(this.LcL_textBox_TextChanged_1);
            // 
            // LcL_label
            // 
            this.LcL_label.AutoSize = true;
            this.LcL_label.Location = new System.Drawing.Point(6, 59);
            this.LcL_label.Name = "LcL_label";
            this.LcL_label.Size = new System.Drawing.Size(88, 13);
            this.LcL_label.TabIndex = 33;
            this.LcL_label.Text = "Lower Class Limit";
            // 
            // UcL_textBox
            // 
            this.UcL_textBox.Location = new System.Drawing.Point(92, 73);
            this.UcL_textBox.Name = "UcL_textBox";
            this.UcL_textBox.Size = new System.Drawing.Size(73, 20);
            this.UcL_textBox.TabIndex = 36;
            this.UcL_textBox.TextChanged += new System.EventHandler(this.UcL_textBox_TextChanged_1);
            // 
            // UcL_label
            // 
            this.UcL_label.AutoSize = true;
            this.UcL_label.Location = new System.Drawing.Point(6, 79);
            this.UcL_label.Name = "UcL_label";
            this.UcL_label.Size = new System.Drawing.Size(88, 13);
            this.UcL_label.TabIndex = 35;
            this.UcL_label.Text = "Upper Class Limit";
            // 
            // V_3Decimals
            // 
            this.V_3Decimals.Location = new System.Drawing.Point(222, 32);
            this.V_3Decimals.Name = "V_3Decimals";
            this.V_3Decimals.Size = new System.Drawing.Size(23, 23);
            this.V_3Decimals.TabIndex = 40;
            this.V_3Decimals.Text = "3";
            this.V_3Decimals.UseVisualStyleBackColor = true;
            this.V_3Decimals.Click += new System.EventHandler(this.V_3Decimals_Click);
            // 
            // V_2Decimals
            // 
            this.V_2Decimals.Location = new System.Drawing.Point(193, 32);
            this.V_2Decimals.Name = "V_2Decimals";
            this.V_2Decimals.Size = new System.Drawing.Size(23, 23);
            this.V_2Decimals.TabIndex = 39;
            this.V_2Decimals.Text = "2";
            this.V_2Decimals.UseVisualStyleBackColor = true;
            this.V_2Decimals.Click += new System.EventHandler(this.V_2Decimals_Click);
            // 
            // V_1Decimals
            // 
            this.V_1Decimals.Location = new System.Drawing.Point(163, 32);
            this.V_1Decimals.Name = "V_1Decimals";
            this.V_1Decimals.Size = new System.Drawing.Size(23, 23);
            this.V_1Decimals.TabIndex = 38;
            this.V_1Decimals.Text = "1";
            this.V_1Decimals.UseVisualStyleBackColor = true;
            this.V_1Decimals.Click += new System.EventHandler(this.V_1Decimals_Click);
            // 
            // V_0Decimals
            // 
            this.V_0Decimals.Location = new System.Drawing.Point(134, 32);
            this.V_0Decimals.Name = "V_0Decimals";
            this.V_0Decimals.Size = new System.Drawing.Size(23, 23);
            this.V_0Decimals.TabIndex = 37;
            this.V_0Decimals.Text = "0";
            this.V_0Decimals.UseVisualStyleBackColor = true;
            this.V_0Decimals.Click += new System.EventHandler(this.V_0Decimals_Click);
            // 
            // ViewFullscreen
            // 
            this.ViewFullscreen.Location = new System.Drawing.Point(86, 306);
            this.ViewFullscreen.Name = "ViewFullscreen";
            this.ViewFullscreen.Size = new System.Drawing.Size(78, 23);
            this.ViewFullscreen.TabIndex = 41;
            this.ViewFullscreen.Text = "Fullscreen";
            this.ViewFullscreen.UseVisualStyleBackColor = true;
            this.ViewFullscreen.Click += new System.EventHandler(this.ViewFullscreen_Click);
            // 
            // Input_Data_Button
            // 
            this.Input_Data_Button.Location = new System.Drawing.Point(8, 306);
            this.Input_Data_Button.Name = "Input_Data_Button";
            this.Input_Data_Button.Size = new System.Drawing.Size(72, 23);
            this.Input_Data_Button.TabIndex = 42;
            this.Input_Data_Button.Text = "Input Data";
            this.Input_Data_Button.UseVisualStyleBackColor = true;
            this.Input_Data_Button.Click += new System.EventHandler(this.Input_Data_Button_Click);
            // 
            // HistoGram_pictureBox
            // 
            this.HistoGram_pictureBox.BackgroundImage = global::HistogramGenerator.Properties.Resources.common_wombat_head;
            this.HistoGram_pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HistoGram_pictureBox.Location = new System.Drawing.Point(192, 15);
            this.HistoGram_pictureBox.Name = "HistoGram_pictureBox";
            this.HistoGram_pictureBox.Size = new System.Drawing.Size(577, 435);
            this.HistoGram_pictureBox.TabIndex = 43;
            this.HistoGram_pictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.testToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.dataToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.dataToolStripMenuItem.Text = "Data";
            this.dataToolStripMenuItem.Click += new System.EventHandler(this.dataToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.howToUseToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // howToUseToolStripMenuItem
            // 
            this.howToUseToolStripMenuItem.Name = "howToUseToolStripMenuItem";
            this.howToUseToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.howToUseToolStripMenuItem.Text = "How to Use";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DataTest,
            this.imageTesterToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // DataTest
            // 
            this.DataTest.Name = "DataTest";
            this.DataTest.Size = new System.Drawing.Size(152, 22);
            this.DataTest.Text = "Data Tester";
            this.DataTest.Click += new System.EventHandler(this.DataTest_Click);
            // 
            // imageTesterToolStripMenuItem
            // 
            this.imageTesterToolStripMenuItem.Name = "imageTesterToolStripMenuItem";
            this.imageTesterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.imageTesterToolStripMenuItem.Text = "Image Tester";
            this.imageTesterToolStripMenuItem.Click += new System.EventHandler(this.imageTesterToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearTextFieldToolStripMenuItem,
            this.randomDataToolStripMenuItem,
            this.viewReportToolStripMenuItem,
            this.setThemeToolStripMenuItem,
            this.advancedOptionsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // clearTextFieldToolStripMenuItem
            // 
            this.clearTextFieldToolStripMenuItem.Name = "clearTextFieldToolStripMenuItem";
            this.clearTextFieldToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.clearTextFieldToolStripMenuItem.Text = "Clear Text Field";
            this.clearTextFieldToolStripMenuItem.Click += new System.EventHandler(this.clearTextFieldToolStripMenuItem_Click);
            // 
            // randomDataToolStripMenuItem
            // 
            this.randomDataToolStripMenuItem.Name = "randomDataToolStripMenuItem";
            this.randomDataToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.randomDataToolStripMenuItem.Text = "Random Data";
            this.randomDataToolStripMenuItem.Click += new System.EventHandler(this.randomDataToolStripMenuItem_Click);
            // 
            // viewReportToolStripMenuItem
            // 
            this.viewReportToolStripMenuItem.Name = "viewReportToolStripMenuItem";
            this.viewReportToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.viewReportToolStripMenuItem.Text = "View Report";
            this.viewReportToolStripMenuItem.Click += new System.EventHandler(this.viewReportToolStripMenuItem_Click);
            // 
            // setThemeToolStripMenuItem
            // 
            this.setThemeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gibsonBlueToolStripMenuItem,
            this.helloKittyToolStripMenuItem,
            this.vSUToolStripMenuItem});
            this.setThemeToolStripMenuItem.Name = "setThemeToolStripMenuItem";
            this.setThemeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.setThemeToolStripMenuItem.Text = "Set Theme";
            // 
            // gibsonBlueToolStripMenuItem
            // 
            this.gibsonBlueToolStripMenuItem.Name = "gibsonBlueToolStripMenuItem";
            this.gibsonBlueToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.gibsonBlueToolStripMenuItem.Text = "Gibson Blue";
            this.gibsonBlueToolStripMenuItem.Click += new System.EventHandler(this.gibsonBlueToolStripMenuItem_Click);
            // 
            // helloKittyToolStripMenuItem
            // 
            this.helloKittyToolStripMenuItem.Name = "helloKittyToolStripMenuItem";
            this.helloKittyToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.helloKittyToolStripMenuItem.Text = "Hello Kitty";
            this.helloKittyToolStripMenuItem.Click += new System.EventHandler(this.helloKittyToolStripMenuItem_Click);
            // 
            // vSUToolStripMenuItem
            // 
            this.vSUToolStripMenuItem.Name = "vSUToolStripMenuItem";
            this.vSUToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.vSUToolStripMenuItem.Text = "VSU";
            this.vSUToolStripMenuItem.Click += new System.EventHandler(this.vSUToolStripMenuItem_Click);
            // 
            // barlabel
            // 
            this.barlabel.AutoSize = true;
            this.barlabel.Location = new System.Drawing.Point(631, 464);
            this.barlabel.Name = "barlabel";
            this.barlabel.Size = new System.Drawing.Size(41, 13);
            this.barlabel.TabIndex = 50;
            this.barlabel.Text = "Default";
            // 
            // ticklabe
            // 
            this.ticklabe.AutoSize = true;
            this.ticklabe.Location = new System.Drawing.Point(631, 486);
            this.ticklabe.Name = "ticklabe";
            this.ticklabe.Size = new System.Drawing.Size(13, 13);
            this.ticklabe.TabIndex = 51;
            this.ticklabe.Text = "6";
            // 
            // panelOptions1
            // 
            this.panelOptions1.Controls.Add(this.UcL_textBox);
            this.panelOptions1.Controls.Add(this.LcL_textBox);
            this.panelOptions1.Controls.Add(this.Label_Stop_textBox);
            this.panelOptions1.Controls.Add(this.Label_Start_textBox);
            this.panelOptions1.Controls.Add(this.Tick_Interval_TextBox);
            this.panelOptions1.Controls.Add(this.UcL_label);
            this.panelOptions1.Controls.Add(this.label5);
            this.panelOptions1.Controls.Add(this.Tick_Interval_label);
            this.panelOptions1.Controls.Add(this.Label_Start_label);
            this.panelOptions1.Controls.Add(this.Update_Histogram);
            this.panelOptions1.Controls.Add(this.Label_Stop_label);
            this.panelOptions1.Controls.Add(this.LcL_label);
            this.panelOptions1.Location = new System.Drawing.Point(6, 349);
            this.panelOptions1.Name = "panelOptions1";
            this.panelOptions1.Size = new System.Drawing.Size(180, 208);
            this.panelOptions1.TabIndex = 52;
            this.panelOptions1.Visible = false;
            // 
            // panelOptions2
            // 
            this.panelOptions2.Controls.Add(this.V_3Decimals);
            this.panelOptions2.Controls.Add(this.V_2Decimals);
            this.panelOptions2.Controls.Add(this.V_1Decimals);
            this.panelOptions2.Controls.Add(this.V_0Decimals);
            this.panelOptions2.Controls.Add(this.V_Decimal_label);
            this.panelOptions2.Controls.Add(this.H_3Decimals);
            this.panelOptions2.Controls.Add(this.H_2Decimals);
            this.panelOptions2.Controls.Add(this.H_1Decimal);
            this.panelOptions2.Controls.Add(this.H_NoDecimals);
            this.panelOptions2.Controls.Add(this.H_Decimal_label);
            this.panelOptions2.Location = new System.Drawing.Point(185, 501);
            this.panelOptions2.Name = "panelOptions2";
            this.panelOptions2.Size = new System.Drawing.Size(401, 63);
            this.panelOptions2.TabIndex = 53;
            this.panelOptions2.Visible = false;
            // 
            // advancedOptionsToolStripMenuItem
            // 
            this.advancedOptionsToolStripMenuItem.Name = "advancedOptionsToolStripMenuItem";
            this.advancedOptionsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.advancedOptionsToolStripMenuItem.Text = "Advanced Options";
            this.advancedOptionsToolStripMenuItem.Click += new System.EventHandler(this.advancedOptionsToolStripMenuItem_Click);
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 564);
            this.Controls.Add(this.panelOptions2);
            this.Controls.Add(this.panelOptions1);
            this.Controls.Add(this.ticklabe);
            this.Controls.Add(this.barlabel);
            this.Controls.Add(this.HistoGram_pictureBox);
            this.Controls.Add(this.Input_Data_Button);
            this.Controls.Add(this.ViewFullscreen);
            this.Controls.Add(this.Number_of_Bins_label);
            this.Controls.Add(this.Number_of_Bins);
            this.Controls.Add(this.NumberofTicks_label);
            this.Controls.Add(this.Number_of_Ticks);
            this.Controls.Add(this.Input_Data_label);
            this.Controls.Add(this.txtInput_Window);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gui";
            this.Text = "Fighting Wombats Histogram Generator";
            this.Load += new System.EventHandler(this.Gui_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoGram_pictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelOptions1.ResumeLayout(false);
            this.panelOptions1.PerformLayout();
            this.panelOptions2.ResumeLayout(false);
            this.panelOptions2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput_Window;
        private System.Windows.Forms.Label Input_Data_label;
        private System.Windows.Forms.Label H_Decimal_label;
        private System.Windows.Forms.Button H_NoDecimals;
        private System.Windows.Forms.Button H_1Decimal;
        private System.Windows.Forms.Button H_2Decimals;
        private System.Windows.Forms.Button H_3Decimals;
        private System.Windows.Forms.Label V_Decimal_label;
        private System.Windows.Forms.HScrollBar Number_of_Ticks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumberofTicks_label;
        private System.Windows.Forms.Label Tick_Interval_label;
        private System.Windows.Forms.TextBox Tick_Interval_TextBox;
        private System.Windows.Forms.Label Label_Start_label;
        private System.Windows.Forms.Label Label_Stop_label;
        private System.Windows.Forms.TextBox Label_Start_textBox;
        private System.Windows.Forms.TextBox Label_Stop_textBox;
        private System.Windows.Forms.Button Update_Histogram;
        private System.Windows.Forms.Label Number_of_Bins_label;
        private System.Windows.Forms.HScrollBar Number_of_Bins;
        private System.Windows.Forms.TextBox LcL_textBox;
        private System.Windows.Forms.Label LcL_label;
        private System.Windows.Forms.TextBox UcL_textBox;
        private System.Windows.Forms.Label UcL_label;
        private System.Windows.Forms.Button V_3Decimals;
        private System.Windows.Forms.Button V_2Decimals;
        private System.Windows.Forms.Button V_1Decimals;
        private System.Windows.Forms.Button V_0Decimals;
        private System.Windows.Forms.Button ViewFullscreen;
        private System.Windows.Forms.Button Input_Data_Button;
        private System.Windows.Forms.PictureBox HistoGram_pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataTest;
        private System.Windows.Forms.ToolStripMenuItem imageTesterToolStripMenuItem;
        private System.Windows.Forms.Label barlabel;
        private System.Windows.Forms.Label ticklabe;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearTextFieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gibsonBlueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helloKittyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vSUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedOptionsToolStripMenuItem;
        private System.Windows.Forms.Panel panelOptions1;
        private System.Windows.Forms.Panel panelOptions2;
    }
}

