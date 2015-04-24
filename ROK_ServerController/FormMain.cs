using System;
using System.Media;
using System.Diagnostics;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ROK_ServerController
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }
        PerformanceCounters counters = new PerformanceCounters();
        ProgramTasks tasks = new ProgramTasks();
        bool startClicked = false;


        private void FormMain_Load(object sender, EventArgs e)
        {
            performanceTimer.Start();
        }
        private void checkBoxEnableStop_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxEnableStop.Visible = false;
            btnStop.Visible = true;
            btnStop.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Process[] rok = Process.GetProcessesByName("ROK");
            foreach (Process p in rok)
            {
                p.Kill();
            }
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            tasks.createConfigFile();
            var args = getArgs(checkedListBox1);
            tasks.args = args;
            Process.Start(tasks.serverPath, tasks.args);
            resetClock.Enabled = true;
            resetClock.Start();            
            calculateTime();
            labelTillReset.ForeColor = Color.Black;
            startClicked = true;

        }

        private void calculateTime()
        {
            TimeSpan span = new TimeSpan(Convert.ToInt16(numericUpDownHours.Value), Convert.ToInt16(numericUpDownMinutes.Value), 0);
            tasks.timespan = span;
           
            Process[] runningProcess = Process.GetProcessesByName("ROK");

           
            if (runningProcess.Length <= 0)
            { 
           
                if (checkBoxAutoRestart.Checked == true) 
                {
                    tasks.createConfigFile();
                    Process.Start(tasks.serverPath, tasks.args);
                    labelTillReset.Text = tasks.timespan.ToString();
                    resetClock.Enabled = false;
                    resetClock.Stop();
                    resetClock.Enabled = true;
                    resetClock.Start();

                }
            }
        }

        private void btnServerPath_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
        }
        private void btnConfigPath_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
        }

        private void btnOpenConfig_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            Process.Start(openFileDialogMain.FileName);
        }
        private string getArgs(CheckedListBox checkedList)
        {           
            string args = null;
            foreach (string s in checkedList.CheckedItems)
            {
                args += " " + s;
            }

            return args;
        }      

        private void maskedTextBoxPerfTimer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                performanceTimer.Interval = Convert.ToInt16(maskedTextBoxPerfTimer.Text);
            }
            catch { }
        }

        private void performanceTimer_Tick(object sender, EventArgs e)
        {
            Process[] runningProcess = Process.GetProcessesByName("ROK");
            if (runningProcess.Length > 0)
            {
                counters.makeCounters();
                textBoxDisplay.Text =
                    "Server path: " + tasks.serverPath + Environment.NewLine +
                    "Configuration path: " + tasks.configPath + Environment.NewLine +
                    "Running with Start up args: " + getArgs(checkedListBox1) + Environment.NewLine +
                    "Server is using: " + Math.Round(counters.CPU, 2, MidpointRounding.AwayFromZero) + "% of CPU" + Environment.NewLine +
                    "Server is using: " + counters.usedRAM.ToString("N1") + "MB of system RAM" + Environment.NewLine +
                    "System RAM free: " + counters.availableRAM.ToString("N1") + "MB" + Environment.NewLine +
                    "Is server responsive: " + runningProcess[0].Responding;
               
                updateChart(chart1);
            }
            else
            {
                textBoxDisplay.Text = "Server response: OFFLINE!";

                if (checkBoxAutoRestart.Checked == true && startClicked == true)
                {
                    if (checkBoxAlarm.Checked == true)
                    {
                        SoundPlayer alarm = new SoundPlayer(Properties.Resources.alarm);
                        alarm.PlaySync();
                    }
                    calculateTime();
                }
                
            }
        }

        private void createChart(Chart c)
        {
            c.ChartAreas[0].Name = "Performance";
            c.Series[0].Name = "CPU%";
            c.Series[1].Name = "RAM%";
            c.Series[0].ChartType = SeriesChartType.Line;
            c.Series[1].ChartType = SeriesChartType.Line;
            c.ChartAreas[0].AxisX.ScrollBar.Size = 10;
            c.ChartAreas[0].CursorX.AutoScroll = true;
            c.ChartAreas[0].AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll;
            c.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;
            c.Series[0].BorderWidth = 2;
            c.Series[1].BorderWidth = 2;



        }
        private void updateChart(Chart pChart = null)
        {
            var time = DateTime.Now;
            //chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Interval = 5;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            var minDate = DateTime.Now.Subtract(TimeSpan.FromSeconds(30));            
            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = time.ToOADate();
            chart1.Series[0].Points.AddXY(time, counters.CPU);
      
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";
            
            //chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Interval = 5;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chart1.ChartAreas[0].AxisX.Minimum = minDate.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = time.ToOADate();
            chart1.Series[1].Points.AddXY(time, counters.ramPercent);

            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm:ss";

        }     

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                createChart(chart1);
            }
        }

        private void openFileDialogMain_FileOk(object sender, CancelEventArgs e)
        { 
            if (openFileDialogMain.FileName.Contains("ROK.exe"))
            {
                tasks.serverPath = openFileDialogMain.FileName;
            }
            else if (openFileDialogMain.FileName.Contains(".cfg"))
            {
                tasks.configPath = openFileDialogMain.FileName;
            }
            else
            {
                MessageBox.Show("Server File must be ROK.exe and Config Files end in .cfg", "Invalid Selection");
            }
            tasks.createConfigFile();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Process[] rok = Process.GetProcessesByName("ROK");
            foreach (Process p in rok)
            {
                try
                {
                    p.Kill();
                    textBoxDisplay.Clear();
                    counters.CPU = 0;
                }
                catch { }
            }
            textBoxDisplay.Clear();
            startClicked = false;
            resetClock.Enabled = false;
            resetClock.Stop();
            tasks.timespan = TimeSpan.Zero;
            labelTillReset.Text = tasks.timespan.ToString();


        }

        private void checkBoxRestart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRestart.Checked)
            {
                labelHours.Visible = true;
                labelMinutes.Visible = true;
                btnSetTime.Visible = true;
                numericUpDownHours.Visible = true;
                numericUpDownMinutes.Visible = true;
                label2.Visible = true;
                labelTillReset.Visible = true;

            }
            else
            {
                labelHours.Visible = false;
                labelMinutes.Visible = false;
                btnSetTime.Visible = false;
                numericUpDownHours.Visible = false;
                numericUpDownMinutes.Visible = false;
                label2.Visible = false;
                labelTillReset.Visible = false;
            }
            
        }
        private void setResetTime()
        {
           
            decimal hours = numericUpDownHours.Value;
            decimal minutes = numericUpDownMinutes.Value;
            if (numericUpDownHours.Value > 0 || numericUpDownMinutes.Value > 0)
            {
                decimal time = (hours * 3600) + ((minutes * 60) - 9);
                tasks.resetTime = time;

            }
        }

        private void numericUpDownHours_Click(object sender, EventArgs e)
        {
            try
            {
                setResetTime();
                tasks.setRestartTimer(tasks.resetTime);
            }
            catch
            {
                MessageBox.Show("You need to set Server and Config paths first", "Error");
            }
        }

        private void numericUpDownMinutes_Click(object sender, EventArgs e)
        {
            try
            {
                setResetTime();
                tasks.setRestartTimer(tasks.resetTime);
            }
            catch
            {
                MessageBox.Show("You need to set Server and Config paths first", "Error");
            }
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            tasks.setRestartTimer(tasks.resetTime);
            labelTillReset.Text = "Time Set!";
        }

        private void resetClock_Tick(object sender, EventArgs e)
        {
            TimeSpan second = new TimeSpan(0, 0, 1);
            tasks.timespan = tasks.timespan.Subtract(second);
            labelTillReset.Text = tasks.timespan.ToString();
            if (tasks.timespan <= TimeSpan.Zero)
            {
                if (checkBoxAutoRestart.Checked == true)
                {
                    calculateTime();
                }

            }
            


        }
    }
}
