using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivateBox
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrivateBox.MainForm());
        }
    }

    class Register
    {
        public void RegisterDll(string strDll)
        {
            Process p = new Process();
            p.StartInfo.FileName = "Regsvr32.exe";

            p.StartInfo.Arguments = " /s " + strDll;
            p.Start();            
            p.Close();
        }
    }
}
