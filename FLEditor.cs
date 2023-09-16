using System;
using System.IO;
using System.Windows.Forms;
using FLNotePad;
using SearchableControls;
using System.Threading;
using System.Linq;

namespace FLNotePad
{
    public partial class FLEditor : Form
    {
        public FLEditor() {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                openFile(openFileDialog1.FileName);
            }
        }
        public void openFile(string FileNameAndPath)
        {
            switch (Path.GetExtension(FileNameAndPath).ToLower())
            {
                case ".rtf":
                    foreach (int i in Enumerable.Range(0, 10))
                    {
                        toolStripProgressBar2.Increment(10);
                        System.Threading.Thread.Sleep(10);
                    }
                    try
                    {
                        srtb.LoadFile(FileNameAndPath, RichTextBoxStreamType.RichText);
                    }
                    catch (Exception ex)
                    {
                        // Handle the error.
                    }
                    foreach (int i in Enumerable.Range(10, 0))
                    {
                        toolStripProgressBar2.Increment(-10);
                        System.Threading.Thread.Sleep(10);
                    }
                    break;
                case ".fl":
                    if (FileNameAndPath.Contains("DataStorm.fl"))
                    {
                        srtb.Text = "We're sorry, but attempting to open a DataStorm file in this will not work, please try something else.";
                    }
                    else
                    {
                        //SavedGame sg = new SavedGame();
                        Flcodec sg = new Flcodec();
                        try
                        {
                            this.srtb.Text = sg.Load(FileNameAndPath);
                        }
                        catch (Exception ex)
                        {
                            // Handle the error.
                        }
                    }
                    foreach (int i in Enumerable.Range(10, 0))
                    {
                        toolStripProgressBar2.Increment(-10);
                        System.Threading.Thread.Sleep(10);
                    }
                    break;
                default:
                    foreach (int i in Enumerable.Range(1, 10))
                    {
                        toolStripProgressBar2.Increment(10);
                        System.Threading.Thread.Sleep(10);
                    }
                    try
                    {
                        this.srtb.LoadFile(FileNameAndPath, RichTextBoxStreamType.PlainText);
                    }
                    catch (Exception ex)
                    {
                        // Handle the error.
                    }
                    foreach (int i in Enumerable.Range(10, 0))
                    {
                        toolStripProgressBar2.Increment(-10);
                        System.Threading.Thread.Sleep(10);
                    }
                    break;
            }

            srtb.Modified = false;
            UpdateStatusBar(FileNameAndPath);
            DocumentFileName = FileNameAndPath;
        }



        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e) {
            FLEditor editor = new FLEditor();
            editor.Show();
            srtb.Modified = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (DocumentFileName.Length == 0 || DocumentFileName.ToString().Contains("newFile")) {
                SaveAs(DocumentFileName);
            }
            else {
                for (int i = 1; i <= 10; i++) {
                    toolStripProgressBar2.Increment(10);
                    System.Threading.Thread.Sleep(10);
                }
                SaveDocument(DocumentFileName);
                for (int i = 10; i >= 0; i--) {
                    toolStripProgressBar2.Increment(-10);
                    System.Threading.Thread.Sleep(10);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveAs(DocumentFileName);
        }

        public void SaveDocument(string FileNameAndPath) {
            if (Path.GetExtension(FileNameAndPath).IndexOf("rtf") >= 1) {
                try {
                    srtb.SaveFile(FileNameAndPath, RichTextBoxStreamType.RichText);
                }
                catch (System.UnauthorizedAccessException) {
                    MessageBox.Show("File is Read-Only. Please correct that, and try saving again.");
                    srtb.Modified = true;
                    //System.Threading.Thread.Sleep(5000);
                }
            }
            else {
                try {
                    srtb.SaveFile(FileNameAndPath, RichTextBoxStreamType.PlainText);
                }
                catch {
                    MessageBox.Show("File is Read-Only. Please correct that, and try saving again.");
                    srtb.Modified = true;
                    //System.Threading.Thread.Sleep(5000);
                }
            }
            srtb.Modified = false;
            UpdateStatusBar(FileNameAndPath);
            DocumentFileName = FileNameAndPath;
        }

        public bool UpdateStatusBar(string FileNameAndPath) {
            this.Text = Path.GetFileName(FileNameAndPath) + (" - Freelancer Notepad.NET 2.0");
            toolStripStatusLabel1.Text = ("File Name: " + FileNameAndPath.ToString());
            toolStripStatusLabel2.Text = ("Document Size(bytes): " + srtb.TextLength.ToString());
            return true;
        }

        public bool SaveAs(string FileNameAndPath) {
            saveFileDialog1.FileName = FileNameAndPath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                SaveDocument(saveFileDialog1.FileName);
                return true;
            }
            else {
                return false;
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                this.printPreviewDialog1.ShowDialog();
            }
            catch {

                MessageBox.Show("You appear not to have a printer installed.\n Try again when you have one installed.");
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e) {
            try {
                this.printPreviewDialog1.ShowDialog();
            }
            catch {

                MessageBox.Show("You appear not to have a printer installed.\n Try again when you have one installed.");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (srtb.CanUndo) {
                srtb.Undo();
                if (srtb.CanUndo == false) {
                    srtb.Modified = false;
                }
                else {
                    srtb.Modified = true;
                }
            }
            else {
                srtb.Modified = false;
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e) {
            if (srtb.CanRedo) {
                srtb.Redo();
                srtb.Modified = true;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.Cut();
            srtb.Modified = true;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.Copy();
            srtb.Modified = true;
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.Paste();
            srtb.Modified = true;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void newToolStripButton_Click(object sender, EventArgs e) {
            newToolStripMenuItem.PerformClick();
        }

        private void openToolStripButton_Click(object sender, EventArgs e) {
            openToolStripMenuItem.PerformClick();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            saveToolStripMenuItem.PerformClick();
        }

        private void printToolStripButton_Click(object sender, EventArgs e) {
            printToolStripMenuItem.PerformClick();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e) {
            cutToolStripMenuItem.PerformClick();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e) {
            copyToolStripMenuItem.PerformClick();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e) {
            pasteToolStripMenuItem.PerformClick();
        }

        private void helpToolStripButton_Click(object sender, EventArgs e) {
            aboutToolStripMenuItem.PerformClick();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.SelectAll();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e) {
            //
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (srtb.Modified) {
                DialogResult Result = MessageBox.Show(this.Text + " has been modified. Save Changes?",
                                                      this.Text, MessageBoxButtons.YesNoCancel);
                if (Result == DialogResult.Yes) {
                    if (DocumentFileName.Length == 0) {
                        e.Cancel = !SaveAs(DocumentFileName);
                    }
                    else {
                        SaveDocument(DocumentFileName);
                    }
                }
                else if (Result == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }

        private void wrapToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.WordWrap = !srtb.WordWrap;
            if (srtb.WordWrap) {
                srtb.ScrollBars = RichTextBoxScrollBars.Vertical;
            }
            else {
                srtb.ScrollBars = RichTextBoxScrollBars.Both;
            }
            wrapToolStripMenuItem.Checked = srtb.WordWrap;
        }

        private void fontToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (fontDialog1.ShowDialog() == DialogResult.OK) {
                srtb.SelectionFont = fontDialog1.Font;
                srtb.Modified = true;
            }
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e) {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                srtb.SelectionColor = colorDialog1.Color;
                srtb.Modified = true;
            }
        }

        private void leftAlignToolStripMenuItem1_Click(object sender, EventArgs e) {
            srtb.SelectionAlignment = HorizontalAlignment.Left;
            //srtb.Modified = true;
            justificationToolStripButton1.Image = leftJustifyToolStripMenuItem.Image;
        }

        private void centerAlignToolStripMenuItem1_Click(object sender, EventArgs e) {
            srtb.SelectionAlignment = HorizontalAlignment.Center;
            //srtb.Modified = true;
            justificationToolStripButton1.Image = centerJustifyToolStripMenuItem2.Image;
        }

        private void rightAlignToolStripMenuItem1_Click(object sender, EventArgs e) {
            srtb.SelectionAlignment = HorizontalAlignment.Right;
            //srtb.Modified = true;
            justificationToolStripButton1.Image = rightJustifyToolStripMenuItem3.Image;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            srtb.Modified = true;
            if (e.Data.GetDataPresent(DataFormats.Text) ||
                e.Data.GetDataPresent(DataFormats.Rtf)) //||
                //e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Copy;
            else if
                (e.Data.GetDataPresent(DataFormats.Bitmap) ||
                 e.Data.GetDataPresent(DataFormats.Tiff) ||
                 e.Data.GetDataPresent(DataFormats.Dib))
                e.Effect = DragDropEffects.Copy;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            int i;
            String s;

            // Get start position to drop the text.
            i = srtb.SelectionStart;
            s = srtb.Text.Substring(i);
            srtb.Text = srtb.Text.Substring(0, i);

            // Drop the text on to the RichTextBox.
            srtb.Text = srtb.Text +
                e.Data.GetData(DataFormats.Text).ToString();
            srtb.Text = srtb.Text + s;
            srtb.Modified = true;
        }

        private void openInNewWindowToolStripMenuItem1_Click(object sender, EventArgs e) {
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                multiOpen(openFileDialog1.FileNames);
            }
        }

        private void srtb_ModifiedChanged(object sender, EventArgs e) {
            if (!srtb.Modified) {
                toolStripStatusLabel3.Text = ("Unmodified");
                toolStripStatusLabel3.ForeColor = System.Drawing.Color.Cyan;
                toolStripStatusLabel2.Text = ("Document Size(bytes): " + srtb.TextLength.ToString());

            }
            else {
                toolStripStatusLabel3.Text = ("Modified");
                toolStripStatusLabel3.ForeColor = System.Drawing.Color.LimeGreen;
                toolStripStatusLabel2.Text = ("Document Size(bytes): " + srtb.TextLength.ToString());

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            MessageBox.Show("Printing functionality is not yet fully enabled.\n Try copying your text to another editor, and print from there.");
        }

        private void idsEditorToolStripMenuItem_Click(object sender, EventArgs e) {
            XMLConverter IdsEditor = new XMLConverter();
            IdsEditor.Show();
        }

        private void srtb_TextChanged(object sender, EventArgs e) {
            toolStripStatusLabel2.Text = ("Document Size(bytes): " + srtb.TextLength.ToString());
        }

        public void multiOpen(string[] args) {
            foreach (string file in args) {
                FLEditor Document = new FLEditor();
                Document.openFile(file);
                Document.Show();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            srtb.Modified = false;
            srtb.Clear();
            this.Text = "newFile" + " - Freelancer Notepad.NET 2.0";
            toolStripStatusLabel1.Text = ("File Name: " + "newFile (please save as a real file)");
            toolStripStatusLabel2.Text = ("Document Size(bytes): " + srtb.TextLength.ToString());
            toolStripStatusLabel3.Text = ("Unmodified");
            toolStripStatusLabel3.ForeColor = System.Drawing.Color.Cyan;
        }

        private void leftJustifyToolStripMenuItem_Click(object sender, EventArgs e) {
            leftAlignToolStripMenuItem1.PerformClick();
        }

        private void centerJustifyToolStripMenuItem_Click(object sender, EventArgs e) {
            centerAlignToolStripMenuItem1.PerformClick();
        }

        private void rightJustifyToolStripMenuItem_Click(object sender, EventArgs e) {
            rightAlignToolStripMenuItem1.PerformClick();
        }
    }
}
