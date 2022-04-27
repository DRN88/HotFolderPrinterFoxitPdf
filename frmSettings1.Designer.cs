namespace HotFolderPrinterFoxitPdf
{
    partial class frmSettings1
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
            this.cbSettingsSelectedPrinter = new System.Windows.Forms.ComboBox();
            this.lSettingsSelectedPrinter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSettingsLogFileBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSettingsLogFile = new System.Windows.Forms.TextBox();
            this.btnSettingsHotFolderProcessedDirBrowse = new System.Windows.Forms.Button();
            this.btnSettingsHotFolderQueueDirBrowse = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSettingsHotFolderProcessedDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSettingsHotFolderQueueDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudSettingsHotFolderQueueRescanTimeMS = new System.Windows.Forms.NumericUpDown();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsHotFolderQueueRescanTimeMS)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSettingsSelectedPrinter
            // 
            this.cbSettingsSelectedPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSettingsSelectedPrinter.FormattingEnabled = true;
            this.cbSettingsSelectedPrinter.Location = new System.Drawing.Point(211, 22);
            this.cbSettingsSelectedPrinter.Name = "cbSettingsSelectedPrinter";
            this.cbSettingsSelectedPrinter.Size = new System.Drawing.Size(539, 23);
            this.cbSettingsSelectedPrinter.TabIndex = 0;
            this.cbSettingsSelectedPrinter.SelectedIndexChanged += new System.EventHandler(this.cbSettingsSelectedPrinter_SelectedIndexChanged);
            // 
            // lSettingsSelectedPrinter
            // 
            this.lSettingsSelectedPrinter.Location = new System.Drawing.Point(116, 22);
            this.lSettingsSelectedPrinter.Name = "lSettingsSelectedPrinter";
            this.lSettingsSelectedPrinter.Size = new System.Drawing.Size(89, 23);
            this.lSettingsSelectedPrinter.TabIndex = 1;
            this.lSettingsSelectedPrinter.Text = "Selected Printer";
            this.lSettingsSelectedPrinter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSettingsLogFileBrowse);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbSettingsLogFile);
            this.groupBox1.Controls.Add(this.btnSettingsHotFolderProcessedDirBrowse);
            this.groupBox1.Controls.Add(this.btnSettingsHotFolderQueueDirBrowse);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbSettingsHotFolderProcessedDir);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSettingsHotFolderQueueDir);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudSettingsHotFolderQueueRescanTimeMS);
            this.groupBox1.Controls.Add(this.lSettingsSelectedPrinter);
            this.groupBox1.Controls.Add(this.cbSettingsSelectedPrinter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(762, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // btnSettingsLogFileBrowse
            // 
            this.btnSettingsLogFileBrowse.Location = new System.Drawing.Point(675, 138);
            this.btnSettingsLogFileBrowse.Name = "btnSettingsLogFileBrowse";
            this.btnSettingsLogFileBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsLogFileBrowse.TabIndex = 15;
            this.btnSettingsLogFileBrowse.Text = "Browse";
            this.btnSettingsLogFileBrowse.UseVisualStyleBackColor = true;
            this.btnSettingsLogFileBrowse.Click += new System.EventHandler(this.btnSettingsLogFileBrowse_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(153, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 23);
            this.label5.TabIndex = 14;
            this.label5.Text = "Log File";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSettingsLogFile
            // 
            this.tbSettingsLogFile.Location = new System.Drawing.Point(211, 138);
            this.tbSettingsLogFile.Name = "tbSettingsLogFile";
            this.tbSettingsLogFile.ReadOnly = true;
            this.tbSettingsLogFile.Size = new System.Drawing.Size(458, 23);
            this.tbSettingsLogFile.TabIndex = 13;
            // 
            // btnSettingsHotFolderProcessedDirBrowse
            // 
            this.btnSettingsHotFolderProcessedDirBrowse.Location = new System.Drawing.Point(675, 108);
            this.btnSettingsHotFolderProcessedDirBrowse.Name = "btnSettingsHotFolderProcessedDirBrowse";
            this.btnSettingsHotFolderProcessedDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsHotFolderProcessedDirBrowse.TabIndex = 11;
            this.btnSettingsHotFolderProcessedDirBrowse.Text = "Browse";
            this.btnSettingsHotFolderProcessedDirBrowse.UseVisualStyleBackColor = true;
            this.btnSettingsHotFolderProcessedDirBrowse.Click += new System.EventHandler(this.btnSettingsHotFolderProcessedDirBrowse_Click);
            // 
            // btnSettingsHotFolderQueueDirBrowse
            // 
            this.btnSettingsHotFolderQueueDirBrowse.Location = new System.Drawing.Point(675, 80);
            this.btnSettingsHotFolderQueueDirBrowse.Name = "btnSettingsHotFolderQueueDirBrowse";
            this.btnSettingsHotFolderQueueDirBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsHotFolderQueueDirBrowse.TabIndex = 10;
            this.btnSettingsHotFolderQueueDirBrowse.Text = "Browse";
            this.btnSettingsHotFolderQueueDirBrowse.UseVisualStyleBackColor = true;
            this.btnSettingsHotFolderQueueDirBrowse.Click += new System.EventHandler(this.btnSettingsHotFolderQueueDirBrowse_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(70, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "HotFolder Processed Dir";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSettingsHotFolderProcessedDir
            // 
            this.tbSettingsHotFolderProcessedDir.Location = new System.Drawing.Point(211, 109);
            this.tbSettingsHotFolderProcessedDir.Name = "tbSettingsHotFolderProcessedDir";
            this.tbSettingsHotFolderProcessedDir.ReadOnly = true;
            this.tbSettingsHotFolderProcessedDir.Size = new System.Drawing.Size(458, 23);
            this.tbSettingsHotFolderProcessedDir.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "HotFolder Queue Dir";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSettingsHotFolderQueueDir
            // 
            this.tbSettingsHotFolderQueueDir.Location = new System.Drawing.Point(211, 80);
            this.tbSettingsHotFolderQueueDir.Name = "tbSettingsHotFolderQueueDir";
            this.tbSettingsHotFolderQueueDir.ReadOnly = true;
            this.tbSettingsHotFolderQueueDir.Size = new System.Drawing.Size(458, 23);
            this.tbSettingsHotFolderQueueDir.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(371, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Range: 10s - 1h. App restart required if changed.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "HotFolder Queue Rescan Time MS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudSettingsHotFolderQueueRescanTimeMS
            // 
            this.nudSettingsHotFolderQueueRescanTimeMS.Location = new System.Drawing.Point(211, 51);
            this.nudSettingsHotFolderQueueRescanTimeMS.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.nudSettingsHotFolderQueueRescanTimeMS.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSettingsHotFolderQueueRescanTimeMS.Name = "nudSettingsHotFolderQueueRescanTimeMS";
            this.nudSettingsHotFolderQueueRescanTimeMS.Size = new System.Drawing.Size(154, 23);
            this.nudSettingsHotFolderQueueRescanTimeMS.TabIndex = 3;
            this.nudSettingsHotFolderQueueRescanTimeMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSettingsHotFolderQueueRescanTimeMS.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSettingsHotFolderQueueRescanTimeMS.ValueChanged += new System.EventHandler(this.nudSettingsHotFolderQueueRescanTimeMS_ValueChanged);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSettings1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSettings1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HotFolder Printer Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSettingsHotFolderQueueRescanTimeMS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox cbSettingsSelectedPrinter;
        private Label lSettingsSelectedPrinter;
        private GroupBox groupBox1;
        private Label label1;
        private NumericUpDown nudSettingsHotFolderQueueRescanTimeMS;
        private Label label2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label4;
        private TextBox tbSettingsHotFolderProcessedDir;
        private Label label3;
        private TextBox tbSettingsHotFolderQueueDir;
        private Button btnSettingsHotFolderProcessedDirBrowse;
        private Button btnSettingsHotFolderQueueDirBrowse;
        private Button btnSettingsLogFileBrowse;
        private Label label5;
        private TextBox tbSettingsLogFile;
        private ContextMenuStrip contextMenuStrip1;
        private SaveFileDialog saveFileDialog1;
    }
}