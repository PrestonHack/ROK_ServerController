namespace ROK_ServerController
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageServerSettings = new System.Windows.Forms.TabPage();
            this.checkBoxAutoRestart = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.checkBoxRestart = new System.Windows.Forms.CheckBox();
            this.numericUpDownMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownHours = new System.Windows.Forms.NumericUpDown();
            this.labelTillReset = new System.Windows.Forms.Label();
            this.maskedTextBoxPerfTimer = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkBoxEnableStop = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOpenConfig = new System.Windows.Forms.Button();
            this.btnConfigPath = new System.Windows.Forms.Button();
            this.btnServerPath = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.tabPageChart = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.performanceTimer = new System.Windows.Forms.Timer(this.components);
            this.openFileDialogMain = new System.Windows.Forms.OpenFileDialog();
            this.resetClock = new System.Windows.Forms.Timer(this.components);
            this.checkBoxAlarm = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPageServerSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageServerSettings);
            this.tabControl1.Controls.Add(this.tabPageChart);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 411);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageServerSettings
            // 
            this.tabPageServerSettings.Controls.Add(this.checkBoxAlarm);
            this.tabPageServerSettings.Controls.Add(this.checkBoxAutoRestart);
            this.tabPageServerSettings.Controls.Add(this.label2);
            this.tabPageServerSettings.Controls.Add(this.btnSetTime);
            this.tabPageServerSettings.Controls.Add(this.labelMinutes);
            this.tabPageServerSettings.Controls.Add(this.labelHours);
            this.tabPageServerSettings.Controls.Add(this.checkBoxRestart);
            this.tabPageServerSettings.Controls.Add(this.numericUpDownMinutes);
            this.tabPageServerSettings.Controls.Add(this.numericUpDownHours);
            this.tabPageServerSettings.Controls.Add(this.labelTillReset);
            this.tabPageServerSettings.Controls.Add(this.maskedTextBoxPerfTimer);
            this.tabPageServerSettings.Controls.Add(this.label1);
            this.tabPageServerSettings.Controls.Add(this.groupBox1);
            this.tabPageServerSettings.Controls.Add(this.checkBoxEnableStop);
            this.tabPageServerSettings.Controls.Add(this.btnExit);
            this.tabPageServerSettings.Controls.Add(this.btnOpenConfig);
            this.tabPageServerSettings.Controls.Add(this.btnConfigPath);
            this.tabPageServerSettings.Controls.Add(this.btnServerPath);
            this.tabPageServerSettings.Controls.Add(this.btnStop);
            this.tabPageServerSettings.Controls.Add(this.btnStart);
            this.tabPageServerSettings.Controls.Add(this.textBoxDisplay);
            this.tabPageServerSettings.Location = new System.Drawing.Point(4, 25);
            this.tabPageServerSettings.Name = "tabPageServerSettings";
            this.tabPageServerSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServerSettings.Size = new System.Drawing.Size(776, 382);
            this.tabPageServerSettings.TabIndex = 0;
            this.tabPageServerSettings.Text = "ServerSettings";
            this.tabPageServerSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoRestart
            // 
            this.checkBoxAutoRestart.AutoSize = true;
            this.checkBoxAutoRestart.Location = new System.Drawing.Point(276, 349);
            this.checkBoxAutoRestart.Name = "checkBoxAutoRestart";
            this.checkBoxAutoRestart.Size = new System.Drawing.Size(100, 20);
            this.checkBoxAutoRestart.TabIndex = 22;
            this.checkBoxAutoRestart.Text = "Auto Restart";
            this.checkBoxAutoRestart.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Server Will Reset In: ";
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(8, 243);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(75, 23);
            this.btnSetTime.TabIndex = 20;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Visible = false;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(67, 304);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(54, 16);
            this.labelMinutes.TabIndex = 19;
            this.labelMinutes.Text = "Minutes";
            this.labelMinutes.Visible = false;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(67, 278);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(44, 16);
            this.labelHours.TabIndex = 18;
            this.labelHours.Text = "Hours";
            this.labelHours.Visible = false;
            // 
            // checkBoxRestart
            // 
            this.checkBoxRestart.AutoSize = true;
            this.checkBoxRestart.Location = new System.Drawing.Point(9, 323);
            this.checkBoxRestart.Name = "checkBoxRestart";
            this.checkBoxRestart.Size = new System.Drawing.Size(154, 20);
            this.checkBoxRestart.TabIndex = 17;
            this.checkBoxRestart.Text = "Change Restart Time";
            this.checkBoxRestart.UseVisualStyleBackColor = true;
            this.checkBoxRestart.CheckedChanged += new System.EventHandler(this.checkBoxRestart_CheckedChanged);
            // 
            // numericUpDownMinutes
            // 
            this.numericUpDownMinutes.Location = new System.Drawing.Point(8, 298);
            this.numericUpDownMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownMinutes.Name = "numericUpDownMinutes";
            this.numericUpDownMinutes.ReadOnly = true;
            this.numericUpDownMinutes.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownMinutes.TabIndex = 15;
            this.numericUpDownMinutes.Visible = false;
            this.numericUpDownMinutes.Click += new System.EventHandler(this.numericUpDownMinutes_Click);
            // 
            // numericUpDownHours
            // 
            this.numericUpDownHours.Location = new System.Drawing.Point(8, 272);
            this.numericUpDownHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numericUpDownHours.Name = "numericUpDownHours";
            this.numericUpDownHours.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownHours.TabIndex = 14;
            this.numericUpDownHours.Visible = false;
            this.numericUpDownHours.Click += new System.EventHandler(this.numericUpDownHours_Click);
            // 
            // labelTillReset
            // 
            this.labelTillReset.AutoSize = true;
            this.labelTillReset.ForeColor = System.Drawing.Color.Red;
            this.labelTillReset.Location = new System.Drawing.Point(354, 300);
            this.labelTillReset.Name = "labelTillReset";
            this.labelTillReset.Size = new System.Drawing.Size(117, 16);
            this.labelTillReset.TabIndex = 13;
            this.labelTillReset.Text = "No Time Selected";
            // 
            // maskedTextBoxPerfTimer
            // 
            this.maskedTextBoxPerfTimer.Location = new System.Drawing.Point(9, 345);
            this.maskedTextBoxPerfTimer.Mask = "0000";
            this.maskedTextBoxPerfTimer.Name = "maskedTextBoxPerfTimer";
            this.maskedTextBoxPerfTimer.Size = new System.Drawing.Size(40, 22);
            this.maskedTextBoxPerfTimer.TabIndex = 12;
            this.maskedTextBoxPerfTimer.Text = "1000";
            this.maskedTextBoxPerfTimer.TextChanged += new System.EventHandler(this.maskedTextBoxPerfTimer_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Performance Timer in milliseconds";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBox1);
            this.groupBox1.Location = new System.Drawing.Point(556, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 236);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Start up arguments";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "-batchmode",
            "-nographics",
            "-silent-crashes",
            "-nolog",
            "-logfile"});
            this.checkedListBox1.Location = new System.Drawing.Point(3, 18);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(206, 215);
            this.checkedListBox1.TabIndex = 8;
            // 
            // checkBoxEnableStop
            // 
            this.checkBoxEnableStop.AutoSize = true;
            this.checkBoxEnableStop.Location = new System.Drawing.Point(667, 267);
            this.checkBoxEnableStop.Name = "checkBoxEnableStop";
            this.checkBoxEnableStop.Size = new System.Drawing.Size(101, 20);
            this.checkBoxEnableStop.TabIndex = 7;
            this.checkBoxEnableStop.Text = "Enable Stop";
            this.checkBoxEnableStop.UseVisualStyleBackColor = true;
            this.checkBoxEnableStop.CheckedChanged += new System.EventHandler(this.checkBoxEnableStop_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(666, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 35);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnOpenConfig
            // 
            this.btnOpenConfig.Location = new System.Drawing.Point(558, 341);
            this.btnOpenConfig.Name = "btnOpenConfig";
            this.btnOpenConfig.Size = new System.Drawing.Size(102, 35);
            this.btnOpenConfig.TabIndex = 5;
            this.btnOpenConfig.Text = "Open Config";
            this.btnOpenConfig.UseVisualStyleBackColor = true;
            this.btnOpenConfig.Click += new System.EventHandler(this.btnOpenConfig_Click);
            // 
            // btnConfigPath
            // 
            this.btnConfigPath.Location = new System.Drawing.Point(666, 300);
            this.btnConfigPath.Name = "btnConfigPath";
            this.btnConfigPath.Size = new System.Drawing.Size(102, 35);
            this.btnConfigPath.TabIndex = 4;
            this.btnConfigPath.Text = "Config Path";
            this.btnConfigPath.UseVisualStyleBackColor = true;
            this.btnConfigPath.Click += new System.EventHandler(this.btnConfigPath_Click);
            // 
            // btnServerPath
            // 
            this.btnServerPath.Location = new System.Drawing.Point(558, 300);
            this.btnServerPath.Name = "btnServerPath";
            this.btnServerPath.Size = new System.Drawing.Size(102, 35);
            this.btnServerPath.TabIndex = 3;
            this.btnServerPath.Text = "Server Path";
            this.btnServerPath.UseVisualStyleBackColor = true;
            this.btnServerPath.Click += new System.EventHandler(this.btnServerPath_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Enabled = false;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(666, 259);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 35);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Visible = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(558, 259);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxDisplay.Location = new System.Drawing.Point(9, 7);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(541, 236);
            this.textBoxDisplay.TabIndex = 0;
            // 
            // tabPageChart
            // 
            this.tabPageChart.Controls.Add(this.chart1);
            this.tabPageChart.Location = new System.Drawing.Point(4, 25);
            this.tabPageChart.Name = "tabPageChart";
            this.tabPageChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChart.Size = new System.Drawing.Size(776, 382);
            this.tabPageChart.TabIndex = 1;
            this.tabPageChart.Text = "Performance Chart";
            this.tabPageChart.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(770, 376);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // performanceTimer
            // 
            this.performanceTimer.Enabled = true;
            this.performanceTimer.Interval = 500;
            this.performanceTimer.Tick += new System.EventHandler(this.performanceTimer_Tick);
            // 
            // openFileDialogMain
            // 
            this.openFileDialogMain.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogMain_FileOk);
            // 
            // resetClock
            // 
            this.resetClock.Interval = 1000;
            this.resetClock.Tick += new System.EventHandler(this.resetClock_Tick);
            // 
            // checkBoxAlarm
            // 
            this.checkBoxAlarm.AutoSize = true;
            this.checkBoxAlarm.Location = new System.Drawing.Point(383, 349);
            this.checkBoxAlarm.Name = "checkBoxAlarm";
            this.checkBoxAlarm.Size = new System.Drawing.Size(142, 20);
            this.checkBoxAlarm.TabIndex = 23;
            this.checkBoxAlarm.Text = "Sound Crash Alarm";
            this.checkBoxAlarm.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Reign of Kings Server Controller";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageServerSettings.ResumeLayout(false);
            this.tabPageServerSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHours)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabPageChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageServerSettings;
        private System.Windows.Forms.TabPage tabPageChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckBox checkBoxEnableStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOpenConfig;
        private System.Windows.Forms.Button btnConfigPath;
        private System.Windows.Forms.Button btnServerPath;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer performanceTimer;
        private System.Windows.Forms.OpenFileDialog openFileDialogMain;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPerfTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownHours;
        private System.Windows.Forms.Label labelTillReset;
        private System.Windows.Forms.CheckBox checkBoxRestart;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxAutoRestart;
        private System.Windows.Forms.Timer resetClock;
        private System.Windows.Forms.CheckBox checkBoxAlarm;
    }
}

