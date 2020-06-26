namespace PrivateBox.Forms
{
    partial class FrmLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginAdmin));
            this.btn_sure = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.tbox_password = new CCWin.SkinControl.SkinTextBox();
            this.btnJpPwd = new CCWin.SkinControl.SkinButton();
            this.tbox_username = new CCWin.SkinControl.SkinTextBox();
            this.btnId = new CCWin.SkinControl.SkinButton();
            this.tbox_password.SuspendLayout();
            this.tbox_username.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sure
            // 
            this.btn_sure.BackColor = System.Drawing.Color.Transparent;
            this.btn_sure.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_sure.DownBack = null;
            this.btn_sure.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_sure.Location = new System.Drawing.Point(36, 143);
            this.btn_sure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sure.MouseBack = null;
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.NormlBack = null;
            this.btn_sure.Size = new System.Drawing.Size(87, 33);
            this.btn_sure.TabIndex = 3;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = false;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_cancel.Location = new System.Drawing.Point(143, 143);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(87, 33);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tbox_password
            // 
            this.tbox_password.BackColor = System.Drawing.Color.Transparent;
            this.tbox_password.Controls.Add(this.btnJpPwd);
            this.tbox_password.DownBack = null;
            this.tbox_password.Icon = null;
            this.tbox_password.IconIsButton = true;
            this.tbox_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_password.IsPasswordChat = '●';
            this.tbox_password.IsSystemPasswordChar = false;
            this.tbox_password.Lines = new string[0];
            this.tbox_password.Location = new System.Drawing.Point(36, 95);
            this.tbox_password.Margin = new System.Windows.Forms.Padding(0);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.MinimumSize = new System.Drawing.Size(0, 28);
            this.tbox_password.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("tbox_password.MouseBack")));
            this.tbox_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_password.Multiline = true;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("tbox_password.NormlBack")));
            this.tbox_password.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.tbox_password.ReadOnly = false;
            this.tbox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_password.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.tbox_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbox_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbox_password.SkinTxt.Multiline = true;
            this.tbox_password.SkinTxt.Name = "BaseText";
            this.tbox_password.SkinTxt.PasswordChar = '●';
            this.tbox_password.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.tbox_password.SkinTxt.TabIndex = 0;
            this.tbox_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_password.SkinTxt.WaterText = "密码";
            this.tbox_password.TabIndex = 2;
            this.tbox_password.TabStop = true;
            this.tbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbox_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_password.WaterText = "密码";
            this.tbox_password.WordWrap = true;
            // 
            // btnJpPwd
            // 
            this.btnJpPwd.BackColor = System.Drawing.Color.White;
            this.btnJpPwd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnJpPwd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnJpPwd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnJpPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJpPwd.DownBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.DownBack")));
            this.btnJpPwd.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnJpPwd.Location = new System.Drawing.Point(170, 4);
            this.btnJpPwd.Margin = new System.Windows.Forms.Padding(0);
            this.btnJpPwd.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.MouseBack")));
            this.btnJpPwd.Name = "btnJpPwd";
            this.btnJpPwd.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnJpPwd.NormlBack")));
            this.btnJpPwd.Size = new System.Drawing.Size(15, 16);
            this.btnJpPwd.TabIndex = 41;
            this.btnJpPwd.UseVisualStyleBackColor = false;
            this.btnJpPwd.Click += new System.EventHandler(this.btnJpPwd_Click);
            // 
            // tbox_username
            // 
            this.tbox_username.BackColor = System.Drawing.Color.Transparent;
            this.tbox_username.Controls.Add(this.btnId);
            this.tbox_username.DownBack = null;
            this.tbox_username.Icon = null;
            this.tbox_username.IconIsButton = false;
            this.tbox_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_username.IsPasswordChat = '\0';
            this.tbox_username.IsSystemPasswordChar = false;
            this.tbox_username.Lines = new string[0];
            this.tbox_username.Location = new System.Drawing.Point(36, 65);
            this.tbox_username.Margin = new System.Windows.Forms.Padding(0);
            this.tbox_username.MaxLength = 32767;
            this.tbox_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbox_username.MouseBack = ((System.Drawing.Bitmap)(resources.GetObject("tbox_username.MouseBack")));
            this.tbox_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_username.Multiline = true;
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.NormlBack = ((System.Drawing.Bitmap)(resources.GetObject("tbox_username.NormlBack")));
            this.tbox_username.Padding = new System.Windows.Forms.Padding(5, 5, 28, 5);
            this.tbox_username.ReadOnly = false;
            this.tbox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_username.Size = new System.Drawing.Size(194, 30);
            // 
            // 
            // 
            this.tbox_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbox_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbox_username.SkinTxt.Multiline = true;
            this.tbox_username.SkinTxt.Name = "BaseText";
            this.tbox_username.SkinTxt.Size = new System.Drawing.Size(161, 20);
            this.tbox_username.SkinTxt.TabIndex = 0;
            this.tbox_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_username.SkinTxt.WaterText = "用户名";
            this.tbox_username.TabIndex = 1;
            this.tbox_username.TabStop = true;
            this.tbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbox_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_username.WaterText = "用户名";
            this.tbox_username.WordWrap = true;
            // 
            // btnId
            // 
            this.btnId.BackColor = System.Drawing.Color.White;
            this.btnId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btnId.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnId.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnId.DownBack = ((System.Drawing.Image)(resources.GetObject("btnId.DownBack")));
            this.btnId.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnId.IsEnabledDraw = false;
            this.btnId.Location = new System.Drawing.Point(170, 3);
            this.btnId.Margin = new System.Windows.Forms.Padding(0);
            this.btnId.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnId.MouseBack")));
            this.btnId.Name = "btnId";
            this.btnId.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnId.NormlBack")));
            this.btnId.Size = new System.Drawing.Size(22, 24);
            this.btnId.TabIndex = 36;
            this.btnId.TabStop = false;
            this.btnId.UseVisualStyleBackColor = false;
            // 
            // FrmLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 210);
            this.ControlBox = false;
            this.Controls.Add(this.tbox_username);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLoginAdmin";
            this.Radius = 2;
            this.ShadowPalace = global::PrivateBox.Properties.Resources.ShadowPalace;
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.ShowDrawIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入用户名和密码";
            this.tbox_password.ResumeLayout(false);
            this.tbox_password.PerformLayout();
            this.tbox_username.ResumeLayout(false);
            this.tbox_username.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinButton btn_sure;
        private CCWin.SkinControl.SkinButton btn_cancel;
        private CCWin.SkinControl.SkinTextBox tbox_password;
        private CCWin.SkinControl.SkinButton btnJpPwd;
        private CCWin.SkinControl.SkinTextBox tbox_username;
        private CCWin.SkinControl.SkinButton btnId;
    }
}