using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace HotFolderPrinterFoxitPdf
{
    internal class FoxitPdfPrinter
    {
        public static Boolean PrintPDF(string pdfFileName, string foxitPdfExecutable, string printerName)
        {
            try
            {
                Process proc = new Process();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                proc.StartInfo.Verb = "print";
                proc.StartInfo.FileName = foxitPdfExecutable;
                proc.StartInfo.Arguments = String.Format(@"/t ""{0}"" ""{1}""", pdfFileName, printerName);
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                if (proc.HasExited == false)
                {
                    proc.WaitForExit(10000);
                }
                proc.EnableRaisingEvents = true;
                proc.Close();
                //KillAdobe("AcroRd32");
                return true;
            }
            catch
            {
                return false;
            }
        }

        //For whatever reason, sometimes adobe likes to be a stage 5 clinger.
        //So here we kill it with fire.
        //private static bool KillAdobe(string name)
        //{
        //    foreach (Process clsProcess in Process.GetProcesses().Where(clsProcess => clsProcess.ProcessName.StartsWith(name)))
        //    {
        //        clsProcess.Kill();
        //        return true;
        //    }
        //    return false;
        //}
    
    }
}
