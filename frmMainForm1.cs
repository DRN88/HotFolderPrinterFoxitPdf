using System.Threading.Tasks;

namespace HotFolderPrinterFoxitPdf
{
    public partial class frmMainForm1 : Form
    {
        private bool allowShowDisplay = false;
        private bool active = false;
        private System.Threading.Timer? timer;

        public frmMainForm1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.burningFolder1;
            notifyIcon1.Icon = Properties.Resources.burningFolder1;
            //
            active = Convert.ToBoolean(HFP.GetConfig("active"));
            activeToolStripMenuItem.Checked = active;
            timer = new System.Threading.Timer((c) => ScanQueueDirAndPrintPDFDocuments(), null, 0, Convert.ToInt32(HFP.GetConfig("queueRescanTimeMS")));
            HFP.LogWriteLine("App Start.");
        }

        protected override void SetVisibleCore(bool value)
        {
            base.SetVisibleCore(allowShowDisplay ? value : allowShowDisplay);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void activeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (active)
            {
                active = false;
                activeToolStripMenuItem.Checked = false;
                HFP.SetConfig("active", "false");
            }
            else
            {
                active = true;
                activeToolStripMenuItem.Checked = true;
                HFP.SetConfig("active", "true");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings1 frmSettings = new frmSettings1();
            frmSettings.ShowDialog();
        }

        private void ScanQueueDirAndPrintPDFDocuments()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ScanQueueDirAndPrintPDFDocuments));
            }
            else
            {
                if (active)
                {
                    lTimerLastRanAt.Text = DateTime.Now.ToString();
                    // 1. Scan queue dir for pdf files
                    HFP.LogWriteLine("Scanning queue dir for pdf files.");
                    string[] pdfFileList = Directory.GetFiles(HFP.GetConfig("queueDir"), "*.pdf", SearchOption.TopDirectoryOnly);
                    foreach (string pdfFile in pdfFileList) {
                        string processedPdf = Path.Combine(HFP.GetConfig("processedDir"), Path.GetFileName(pdfFile));
                        // 2. Print pdf files
                        HFP.LogWriteLine("Printing pdf file: " + pdfFile);
                        FoxitPdfPrinter.PrintPDF(pdfFile, HFP.GetConfig("foxitPdfReaderExecutable"), HFP.GetConfig("selectedPrinter"));
                        if (File.Exists(processedPdf))
                        {
                            HFP.LogWriteLine("Delete processed pdf file" + processedPdf);
                            File.Delete(processedPdf);
                        }
                        HFP.LogWriteLine("Moving pdf file to processed folder: " + pdfFile);
                        File.Move(pdfFile, processedPdf);
                    }
                }
            }
        }

        private void showProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (allowShowDisplay)
            {
                allowShowDisplay = false;
                SetVisibleCore(false);
            }
            else
            {
                allowShowDisplay = true;
                SetVisibleCore(true);
            }
        }
    }
}