using PrivateBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivateBox.Forms
{
    public partial class FrmFileEdit : CCWin.CCSkinMain
    {    

        private int fileID;
        private string fileName;
        public FrmFileEdit()
        {
            InitializeComponent();
        }

        public int FileID
        {
            get { return fileID; }
            set { fileID = value; }
        }
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; this.textBox_FileName.Text = fileName; }
        }
        private void btn_saveNode_Click(object sender, EventArgs e)
        {
            FileDBHelper dbHelper = new FileDBHelper();
            if ("".Equals(this.textBox_FilePath.Text.Trim()))
            {
                dbHelper.saveFile(fileID,this.textBox_FileName.Text);
            }
            else
            {
                dbHelper.saveFile(fileID, this.textBox_FileName.Text);
                dbHelper.saveFileData(fileID,File.ReadAllBytes(this.textBox_FilePath.Text.Trim()));
            }
           
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btn_browser_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox_FilePath.Text = this.openFileDialog.FileName;
            }
        }
    }
}
