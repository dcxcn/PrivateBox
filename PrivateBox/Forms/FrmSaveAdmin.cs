using CCWin;
using PrivateBox.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace PrivateBox.Forms
{
    public partial class FrmSaveAdmin : CCWin.CCSkinMain
    {
        private Boolean isSuccess = false;
        public FrmSaveAdmin()
        {
            InitializeComponent();
        }
        public Boolean ISSuccess
        {
            get { return isSuccess; }            
        }
        private void btn_sure_Click(object sender, EventArgs e)
        {
            String adminName = this.tbox_username.Text.Trim();
            String adminPwd = this.tbox_password.Text.Trim();
            if ("".Equals(adminName) || "".Equals(adminPwd))
            {
                MessageBoxEx.Show("请填写完整！   ");
            }
            else
            {
                System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(Encoding.Default.GetBytes(adminPwd));
                string md5Pwd = BitConverter.ToString(output).Replace("-", "").ToLower();
                FileDBHelper fbh = new FileDBHelper();
                fbh.saveUserAndPwd(adminName, md5Pwd);
                if (fbh.GetSucces())
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;                  
                }
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
