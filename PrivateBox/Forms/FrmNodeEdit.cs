using PrivateBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivateBox.Forms
{
    public partial class FrmNodeEdit : CCWin.CCSkinMain
    {
        public static int EditMode_ADD = 1;
        public static int EditMode_UPD = 2;        
        private int parentID;
        private int selfID;
        private int editMode = 1;
        private string nodeName;
        public FrmNodeEdit()
        {
            InitializeComponent();
        }
        public int EditMode
        {
            get { return editMode; }
            set { editMode = value; }
        }
        public int ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }
        public int SelfID
        {
            get { return selfID; }
            set { selfID = value; }
        }
        public string NodeName
        {
            get { return nodeName; }
            set { nodeName = value; this.textBox_NodeName.Text = nodeName; }
        }
        private void btn_saveNode_Click(object sender, EventArgs e)
        {
            FileDBHelper dbHelper = new FileDBHelper();
            if (editMode == 1)
            {
                dbHelper.insertFileNode(this.textBox_NodeName.Text, parentID);
            }
            else if (editMode == 2)
            {
                dbHelper.saveFileNode(this.textBox_NodeName.Text, selfID);
                
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
