using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Toolkit;

namespace HourlyCronFolder
{
    public partial class HourlyCronFolder : ServiceBase
    {        
        public HourlyCronFolder()
        {                        
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {            
            RunCronFolder();
            // Set up timer
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000*60;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected override void OnStop()
        {
        }

        public void OnTimer(object sender, System.Timers.ElapsedEventArgs args)
        {
            RunCronFolder();
        }

        public void RunCronFolder()
        {            
            string folderPath;
            string[] files;
            try
            {
                folderPath = ("C:\\Cron");                
                files = Directory.GetFiles(folderPath);
                Directory.SetCurrentDirectory(folderPath);               

                foreach (string file in files)
                {
                    // the name of the application to launch
                    String applicationName = file;

                    // launch the application
                    ApplicationLoader.PROCESS_INFORMATION procInfo;
                    ApplicationLoader.StartProcessAndBypassUAC(applicationName, out procInfo);                    
                }
            }
            catch { }            
        }
    }
}
