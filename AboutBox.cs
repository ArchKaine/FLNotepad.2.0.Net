// A text editor for people who like to mod Freelancer
// Copyright (C) 2005  Brian E Turner
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.
using System;
using System.ComponentModel;
using System.Windows.Forms;
using SearchableControls;

namespace FLNotePad
{
    /// <summary>
    /// Summary description for WinForm.
    /// </summary>
    public class AboutBox : Form
    {
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button2;
        private Button button1;
        private TabPage tabPage4;
        private TabPage tabPage3;
        private TabPage tabPage2;
        private TabPage tabPage1;
        private TabControl tabControl1;
        private SearchableRichTextBox searchableRichTextBox4;
        private SearchableRichTextBox searchableRichTextBox3;
        private SearchableRichTextBox searchableRichTextBox2;
        private SearchableRichTextBox srtb;
        public ImageList imageList1;
        private IContainer components;

        public AboutBox() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBox));
            this.searchableRichTextBox2 = new SearchableControls.SearchableRichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.srtb = new SearchableControls.SearchableRichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.searchableRichTextBox3 = new SearchableControls.SearchableRichTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.searchableRichTextBox4 = new SearchableControls.SearchableRichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchableRichTextBox2
            // 
            this.searchableRichTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchableRichTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.searchableRichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchableRichTextBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchableRichTextBox2.Location = new System.Drawing.Point(5, 4);
            this.searchableRichTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.searchableRichTextBox2.Name = "searchableRichTextBox2";
            this.searchableRichTextBox2.ReadOnly = true;
            this.searchableRichTextBox2.Size = new System.Drawing.Size(574, 288);
            this.searchableRichTextBox2.TabIndex = 0;
            this.searchableRichTextBox2.Text = resources.GetString("searchableRichTextBox2.Text");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.srtb);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(584, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Location = new System.Drawing.Point(453, 301);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 27);
            this.button5.TabIndex = 2;
            this.button5.Text = "Program Info...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(255, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "MISC01.ICO");
            this.imageList1.Images.SetKeyName(1, "green_save.ico");
            this.imageList1.Images.SetKeyName(2, "red_save.ico");
            // 
            // srtb
            // 
            this.srtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.srtb.BackColor = System.Drawing.SystemColors.Window;
            this.srtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.srtb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srtb.Location = new System.Drawing.Point(5, 4);
            this.srtb.Margin = new System.Windows.Forms.Padding(0);
            this.srtb.Name = "srtb";
            this.srtb.ReadOnly = true;
            this.srtb.Size = new System.Drawing.Size(574, 288);
            this.srtb.TabIndex = 0;
            this.srtb.TabStop = false;
            this.srtb.Text = resources.GetString("srtb.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.searchableRichTextBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(584, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "License";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(255, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.searchableRichTextBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(584, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Author";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(255, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 1;
            this.button3.Text = "OK";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchableRichTextBox3
            // 
            this.searchableRichTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchableRichTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchableRichTextBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchableRichTextBox3.Location = new System.Drawing.Point(5, 4);
            this.searchableRichTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.searchableRichTextBox3.Name = "searchableRichTextBox3";
            this.searchableRichTextBox3.Size = new System.Drawing.Size(574, 288);
            this.searchableRichTextBox3.TabIndex = 0;
            this.searchableRichTextBox3.Text = resources.GetString("searchableRichTextBox3.Text");
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.searchableRichTextBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(584, 335);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Release Notes";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(255, 297);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "OK";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // searchableRichTextBox4
            // 
            this.searchableRichTextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.searchableRichTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.searchableRichTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchableRichTextBox4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchableRichTextBox4.Location = new System.Drawing.Point(5, 4);
            this.searchableRichTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.searchableRichTextBox4.Name = "searchableRichTextBox4";
            this.searchableRichTextBox4.ReadOnly = true;
            this.searchableRichTextBox4.Size = new System.Drawing.Size(574, 288);
            this.searchableRichTextBox4.TabIndex = 0;
            this.searchableRichTextBox4.Text = resources.GetString("searchableRichTextBox4.Text");
            // 
            // AboutBox
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AboutBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private void button1_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void button2_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void button3_Click(object sender, System.EventArgs e) {
            Close();
        }

        private void button4_Click(object sender, EventArgs e) {
            Close();
        }

        private void button5_Click(object sender, EventArgs e) {
            AboutBox1 ab2 = new AboutBox1();
            ab2.Show();
        }

    }
}
