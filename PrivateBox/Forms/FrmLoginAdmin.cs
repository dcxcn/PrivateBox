using CCWin.SkinControl;
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
    public partial class FrmLoginAdmin : CCWin.CCSkinMain
    {
        private Boolean isAdmin = false;
        public FrmLoginAdmin()
        {
            InitializeComponent();
        }
        public Boolean ISAdmin
        {
            get { return isAdmin; }            
        }
        private void btn_sure_Click(object sender, EventArgs e)
        {
            String adminName = this.tbox_username.Text.Trim();
            String adminPwd = this.tbox_password.Text.Trim();
            if ("".Equals(adminName) || "".Equals(adminPwd))
            {
                MessageBox.Show("请填写完整！");
            }
            else
            {
                System.Security.Cryptography.MD5 md5 = new MD5CryptoServiceProvider();
                byte[] output = md5.ComputeHash(Encoding.Default.GetBytes(adminPwd));
                string md5Pwd = BitConverter.ToString(output).Replace("-", "").ToLower();

                String commandText_count = string.Format("SELECT count(*) count FROM FileAdmin where admin_name ='{0}' and admin_pwd='{1}'", adminName, md5Pwd);
                dBHelper helper = new dBHelper(DBSource.ConnectionStringPBox);
                if (helper.Load(commandText_count, "") == true)
                {
                    DataTable dt_count = helper.DataSet.Tables[0];
                    int count = int.Parse(dt_count.Rows[0]["count"].ToString());
                    if (count > 0)
                    {
                        isAdmin = true;
                        DBSource.ISAdmin = isAdmin;
                        DBSource.AdminName = adminName;
                    }
                    else
                    {
                        isAdmin = false;
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnJpPwd_Click(object sender, EventArgs e)
        {
            PassKey pass = new PassKey(this.Left + tbox_password.Left - 25, this.Top + tbox_password.Bottom + 1, tbox_password.SkinTxt);
            pass.Show(this);
        }
    }
}
