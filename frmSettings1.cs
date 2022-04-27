using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotFolderPrinterFoxitPdf
{
    public partial class frmSettings1 : Form
    {
        private string configSelectedPrinter = String.Empty;

        public frmSettings1()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.burningFolder1;
            //
            configSelectedPrinter = HFP.GetConfig("selectedPrinter");
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (configSelectedPrinter == String.Empty)
                {
                    configSelectedPrinter = printer;
                    HFP.SetConfig("selectedPrinter", printer);
                }
                cbSettingsSelectedPrinter.Items.Add(printer);
            }
            cbSettingsSelectedPrinter.SelectedIndex = cbSettingsSelectedPrinter.FindStringExact(configSelectedPrinter);
            nudSettingsHotFolderQueueRescanTimeMS.Value = Convert.ToInt32(HFP.GetConfig("queueRescanTimeMS"));
            tbSettingsHotFolderQueueDir.Text = HFP.GetConfig("queueDir");
            tbSettingsHotFolderProcessedDir.Text = HFP.GetConfig("processedDir");
            tbSettingsLogFile.Text = HFP.GetConfig("logFile");
        }

        private void cbSettingsSelectedPrinter_SelectedIndexChanged(object sender, EventArgs e)
        {
            #pragma warning disable CS8604 // Possible null reference argument.
            HFP.SetConfig("selectedPrinter", cbSettingsSelectedPrinter.SelectedItem.ToString());
            #pragma warning restore CS8604 // Possible null reference argument.
        }

        private void btnSettingsHotFolderQueueDirBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                HFP.SetConfig("queueDir", folderBrowserDialog1.SelectedPath);
                tbSettingsHotFolderQueueDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnSettingsHotFolderProcessedDirBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                HFP.SetConfig("processedDir", folderBrowserDialog1.SelectedPath);
                tbSettingsHotFolderProcessedDir.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void nudSettingsHotFolderQueueRescanTimeMS_ValueChanged(object sender, EventArgs e)
        {
            HFP.SetConfig("queueRescanTimeMS", Convert.ToString(nudSettingsHotFolderQueueRescanTimeMS.Value));
        }

        private void btnSettingsLogFileBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                HFP.SetConfig("logFile", saveFileDialog1.FileName);
                tbSettingsLogFile.Text = saveFileDialog1.FileName;
            }
        }

    }

}
