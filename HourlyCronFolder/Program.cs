using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HourlyCronFolder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>        
        static void Main()
        {            
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new HourlyCronFolder()
            };
            ServiceBase.Run(ServicesToRun);            
        }                        
    }
}
