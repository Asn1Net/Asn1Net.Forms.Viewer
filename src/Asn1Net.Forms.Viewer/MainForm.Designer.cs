namespace Net.Asn1.Forms.Viewer
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMennu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.toolStripLabeFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabelSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.pMainBody = new System.Windows.Forms.Panel();
            this.asn1TreeView1 = new Net.Asn1.Forms.TreeView.Asn1TreeView();
            this.Asn1Icons = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsOpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsReadContent = new System.Windows.Forms.ToolStripButton();
            this.tsParseEncapsulatedData = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainMennu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.pMainBody.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMennu
            // 
            this.mainMennu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMennu.Location = new System.Drawing.Point(0, 0);
            this.mainMennu.Name = "mainMennu";
            this.mainMennu.Size = new System.Drawing.Size(786, 24);
            this.mainMennu.TabIndex = 0;
            this.mainMennu.Text = "mainMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabeFileName,
            this.toolStripLabelSize});
            this.statusBar.Location = new System.Drawing.Point(0, 489);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(786, 24);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // toolStripLabeFileName
            // 
            this.toolStripLabeFileName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripLabeFileName.Name = "toolStripLabeFileName";
            this.toolStripLabeFileName.Size = new System.Drawing.Size(670, 19);
            this.toolStripLabeFileName.Spring = true;
            // 
            // toolStripLabelSize
            // 
            this.toolStripLabelSize.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.toolStripLabelSize.Name = "toolStripLabelSize";
            this.toolStripLabelSize.Size = new System.Drawing.Size(101, 19);
            this.toolStripLabelSize.Text = "                              ";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.pMainBody);
            this.mainPanel.Controls.Add(this.toolStrip1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(786, 465);
            this.mainPanel.TabIndex = 2;
            // 
            // pMainBody
            // 
            this.pMainBody.Controls.Add(this.asn1TreeView1);
            this.pMainBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMainBody.Location = new System.Drawing.Point(0, 25);
            this.pMainBody.Name = "pMainBody";
            this.pMainBody.Size = new System.Drawing.Size(786, 440);
            this.pMainBody.TabIndex = 2;
            // 
            // asn1TreeView1
            // 
            this.asn1TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.asn1TreeView1.EncapsulatedDataParsing = false;
            this.asn1TreeView1.ImageIndex = 0;
            this.asn1TreeView1.ImageList = this.Asn1Icons;
            this.asn1TreeView1.Location = new System.Drawing.Point(0, 0);
            this.asn1TreeView1.Name = "asn1TreeView1";
            this.asn1TreeView1.ReadContent = false;
            this.asn1TreeView1.SelectedImageIndex = 0;
            this.asn1TreeView1.Size = new System.Drawing.Size(786, 440);
            this.asn1TreeView1.TabIndex = 0;
            // 
            // Asn1Icons
            // 
            this.Asn1Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Asn1Icons.ImageStream")));
            this.Asn1Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.Asn1Icons.Images.SetKeyName(0, "Other.ico");
            this.Asn1Icons.Images.SetKeyName(1, "01_Boolean.ico");
            this.Asn1Icons.Images.SetKeyName(2, "02_Integer.ico");
            this.Asn1Icons.Images.SetKeyName(3, "03_BitString.ico");
            this.Asn1Icons.Images.SetKeyName(4, "04_OctetString.ico");
            this.Asn1Icons.Images.SetKeyName(5, "05_Null.ico");
            this.Asn1Icons.Images.SetKeyName(6, "06_ObjectIdentifier.ico");
            this.Asn1Icons.Images.SetKeyName(7, "07_ObjectDescriptor.ico");
            this.Asn1Icons.Images.SetKeyName(8, "08_External.ico");
            this.Asn1Icons.Images.SetKeyName(9, "09_Real.ico");
            this.Asn1Icons.Images.SetKeyName(10, "10_Enumerated.ico");
            this.Asn1Icons.Images.SetKeyName(11, "11_EmbeddedPdv.ico");
            this.Asn1Icons.Images.SetKeyName(12, "12_Utf8String.ico");
            this.Asn1Icons.Images.SetKeyName(13, "13_RelativeOid.ico");
            this.Asn1Icons.Images.SetKeyName(14, "Other.ico");
            this.Asn1Icons.Images.SetKeyName(15, "Other.ico");
            this.Asn1Icons.Images.SetKeyName(16, "16_Sequence.ico");
            this.Asn1Icons.Images.SetKeyName(17, "17_Set.ico");
            this.Asn1Icons.Images.SetKeyName(18, "18_NumericString.ico");
            this.Asn1Icons.Images.SetKeyName(19, "19_PrintableString.ico");
            this.Asn1Icons.Images.SetKeyName(20, "20_T61String.ico");
            this.Asn1Icons.Images.SetKeyName(21, "21_VideotexString.ico");
            this.Asn1Icons.Images.SetKeyName(22, "22_Ia5String.ico");
            this.Asn1Icons.Images.SetKeyName(23, "23_UtcTime.ico");
            this.Asn1Icons.Images.SetKeyName(24, "24_GeneralizedTime.ico");
            this.Asn1Icons.Images.SetKeyName(25, "25_GraphicString.ico");
            this.Asn1Icons.Images.SetKeyName(26, "26_VisibleString.ico");
            this.Asn1Icons.Images.SetKeyName(27, "27_GeneralString.ico");
            this.Asn1Icons.Images.SetKeyName(28, "28_UniversalString.ico");
            this.Asn1Icons.Images.SetKeyName(29, "29_CharacterString.ico");
            this.Asn1Icons.Images.SetKeyName(30, "30_BmpString.ico");
            this.Asn1Icons.Images.SetKeyName(31, "31_LongForm.ico");
            this.Asn1Icons.Images.SetKeyName(32, "ContextSpecific.ico");
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpenFile,
            this.toolStripSeparator1,
            this.tsReadContent,
            this.tsParseEncapsulatedData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(786, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsOpenFile
            // 
            this.tsOpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("tsOpenFile.Image")));
            this.tsOpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpenFile.Name = "tsOpenFile";
            this.tsOpenFile.Size = new System.Drawing.Size(23, 22);
            this.tsOpenFile.Text = "Open ASN.1 file";
            this.tsOpenFile.Click += new System.EventHandler(this.tsOpenFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsReadContent
            // 
            this.tsReadContent.Checked = true;
            this.tsReadContent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsReadContent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsReadContent.Image = ((System.Drawing.Image)(resources.GetObject("tsReadContent.Image")));
            this.tsReadContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReadContent.Name = "tsReadContent";
            this.tsReadContent.Size = new System.Drawing.Size(23, 22);
            this.tsReadContent.Text = "Read content of ASN.1 nodes";
            this.tsReadContent.ToolTipText = "Read content of ASN.1 nodes";
            this.tsReadContent.Click += new System.EventHandler(this.tsReadContent_Click);
            // 
            // tsParseEncapsulatedData
            // 
            this.tsParseEncapsulatedData.Checked = true;
            this.tsParseEncapsulatedData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsParseEncapsulatedData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsParseEncapsulatedData.Image = ((System.Drawing.Image)(resources.GetObject("tsParseEncapsulatedData.Image")));
            this.tsParseEncapsulatedData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsParseEncapsulatedData.Name = "tsParseEncapsulatedData";
            this.tsParseEncapsulatedData.Size = new System.Drawing.Size(23, 22);
            this.tsParseEncapsulatedData.Text = "Parse encapsulated data";
            this.tsParseEncapsulatedData.ToolTipText = "Parse encapsulated data";
            this.tsParseEncapsulatedData.Click += new System.EventHandler(this.tsParseEncapsulatedData_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Der Files (*.der;*.req;*.asn1)|*.der;*.req;*.asn1|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 513);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMennu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMennu;
            this.Name = "MainForm";
            this.Text = "Asn1Viewer";
            this.mainMennu.ResumeLayout(false);
            this.mainMennu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.pMainBody.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMennu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabeFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLabelSize;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private TreeView.Asn1TreeView asn1TreeView1;
        private System.Windows.Forms.ImageList Asn1Icons;
        private System.Windows.Forms.Panel pMainBody;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsOpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsReadContent;
        private System.Windows.Forms.ToolStripButton tsParseEncapsulatedData;
    }
}

