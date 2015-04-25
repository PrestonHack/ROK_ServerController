using System.IO;
using System.Windows.Forms;
using System;

namespace ROK_ServerController
{
    class ProgramTasks
    {
        public string serverPath { get; set; }
        public string configPath { get; set; }

        public string args { get; set; }

        public decimal resetTime { get; set; }
        public TimeSpan timespan { get; set; }

        public void createConfigFile()
        {
            bool exists = File.Exists("programConfig.cfg");
            try {
                if ((exists) == true)
                {
                    string[] lines = new string[2];
                    lines = File.ReadAllLines("programConfig.cfg");
                    serverPath = lines[0];
                    configPath = lines[1];
                    
                }
                else
                {
                    string[] lines2 = new string[2];
                    lines2[0] = this.serverPath;
                    lines2[1] = this.configPath;
                    if (!string.IsNullOrEmpty(serverPath) && serverPath != " "
                        && !string.IsNullOrEmpty(configPath) && configPath != " ")
                    {
                        File.WriteAllLines("programConfig.cfg", lines2);
                    }
                    else
                    {
                        MessageBox.Show("Unless you want to create a new server configureation, you need to set the path to ROK server and config", "Error");
                    }


                }
            }
            catch
            {
                MessageBox.Show("programConfig file error deleting programConfig.cfg", "Error");                               
                File.Delete("programConfig.cfg");
            }
        }

        public void setRestartTimer(decimal time)
        {
            string[] lines2 = new string[2];
            lines2 = File.ReadAllLines("programConfig.cfg");
            serverPath = lines2[0];
            configPath = lines2[1];
        
            var lines = File.ReadAllLines(configPath);
            lines[8] = "restartTime =" + " '" + time + "'" + "   #0 seconds to disable.";
            File.WriteAllLines(configPath, lines);
            
             
           
           
        }
    }
}
