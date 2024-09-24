namespace HotFolderPrinterFoxitPdf
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (Mutex mutex = new Mutex(false, "Global\\" + "cf7efcce-b3c6-45ad-af0b-3b505db145dd"))
            {
                if (!mutex.WaitOne(0, false))
                {
                    //MessageBox.Show("Instance already running");
                    return;
                }
                Application.Run(new frmMainForm1());
            }


        }
    }
}