/*
 *  Asn1Net.Forms.Viewer - GUI application for visualization of ASN.1 objects. 
 *	Implemented using Windows.Forms. Uses Asn1TreeView to do the visualization. 
 *	Part of Asn1Net utilities.
 *  Copyright (c) 2014-2015 Peter Polacko
 *  Author: Peter Polacko <peter.polacko+asn1net@gmail.com>
 *
 *  Licensing for open source projects:
 *  Asn1Net.Forms.Viewer is available under the terms of the GNU Affero General 
 *  Public License version 3 as published by the Free Software Foundation.
 *  Please see <http://www.gnu.org/licenses/agpl-3.0.html> for more details.
 *
 */

using System;
using System.IO;
using System.Windows.Forms;

namespace Net.Asn1.Forms.Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            asn1TreeView1.ReadContent = tsReadContent.Checked;
            asn1TreeView1.EncapsulatedDataParsing = tsParseEncapsulatedData.Checked;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;


            var fileName = openFileDialog.FileName;
            toolStripLabeFileName.Text = String.Format("File Name : {0}", fileName);

            var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            toolStripLabelSize.Text = String.Format("Size: {0} bytes", fs.Length);

            asn1TreeView1.LoadContent(fs);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var aboutBox = new AboutBox())
            {
                aboutBox.ShowDialog(this);
            }
        }

        private void tsOpenFile_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void tsReadContent_Click(object sender, EventArgs e)
        {
            tsReadContent.Checked = !tsReadContent.Checked;
            asn1TreeView1.ReadContent = tsReadContent.Checked;
        }

        private void tsParseEncapsulatedData_Click(object sender, EventArgs e)
        {
            tsParseEncapsulatedData.Checked = !tsParseEncapsulatedData.Checked;
            asn1TreeView1.EncapsulatedDataParsing = tsParseEncapsulatedData.Checked;
        }

        
    }
}
