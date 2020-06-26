namespace PrivateBox.Forms
{
    partial class FrmSaveAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSaveAdmin));
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tbox_username = new CCWin.SkinControl.SkinTextBox();
            this.tbox_password = new CCWin.SkinControl.SkinTextBox();
            this.btn_sure = new CCWin.SkinControl.SkinButton();
            this.btn_cancel = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(20, 40);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "用户名";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.Transparent;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(20, 82);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(32, 17);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "密码";
            // 
            // tbox_username
            // 
            this.tbox_username.BackColor = System.Drawing.Color.Transparent;
            this.tbox_username.DownBack = null;
            this.tbox_username.Icon = null;
            this.tbox_username.IconIsButton = false;
            this.tbox_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_username.IsPasswordChat = '\0';
            this.tbox_username.IsSystemPasswordChar = false;
            this.tbox_username.Lines = new string[0];
            this.tbox_username.Location = new System.Drawing.Point(67, 29);
            this.tbox_username.Margin = new System.Windows.Forms.Padding(0);
            this.tbox_username.MaxLength = 32767;
            this.tbox_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbox_username.MouseBack = null;
            this.tbox_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_username.Multiline = false;
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.NormlBack = null;
            this.tbox_username.Padding = new System.Windows.Forms.Padding(5);
            this.tbox_username.ReadOnly = false;
            this.tbox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_username.Size = new System.Drawing.Size(158, 28);
            // 
            // 
            // 
            this.tbox_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbox_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbox_username.SkinTxt.Name = "BaseText";
            this.tbox_username.SkinTxt.Size = new System.Drawing.Size(148, 18);
            this.tbox_username.SkinTxt.TabIndex = 0;
            this.tbox_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_username.SkinTxt.WaterText = "";
            this.tbox_username.TabIndex = 2;
            this.tbox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbox_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_username.WaterText = "";
            this.tbox_username.WordWrap = true;
            // 
            // tbox_password
            // 
            this.tbox_password.BackColor = System.Drawing.Color.Transparent;
            this.tbox_password.DownBack = null;
            this.tbox_password.Icon = null;
            this.tbox_password.IconIsButton = false;
            this.tbox_password.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_password.IsPasswordChat = '\0';
            this.tbox_password.IsSystemPasswordChar = false;
            this.tbox_password.Lines = new string[0];
            this.tbox_password.Location = new System.Drawing.Point(67, 71);
            this.tbox_password.Margin = new System.Windows.Forms.Padding(0);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.MinimumSize = new System.Drawing.Size(28, 28);
            this.tbox_password.MouseBack = null;
            this.tbox_password.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tbox_password.Multiline = false;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.NormlBack = null;
            this.tbox_password.Padding = new System.Windows.Forms.Padding(5);
            this.tbox_password.ReadOnly = false;
            this.tbox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_password.Size = new System.Drawing.Size(158, 28);
            // 
            // 
            // 
            this.tbox_password.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_password.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_password.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tbox_password.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tbox_password.SkinTxt.Name = "BaseText";
            this.tbox_password.SkinTxt.Size = new System.Drawing.Size(148, 18);
            this.tbox_password.SkinTxt.TabIndex = 0;
            this.tbox_password.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_password.SkinTxt.WaterText = "";
            this.tbox_password.TabIndex = 3;
            this.tbox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbox_password.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tbox_password.WaterText = "";
            this.tbox_password.WordWrap = true;
            // 
            // btn_sure
            // 
            this.btn_sure.BackColor = System.Drawing.Color.Transparent;
            this.btn_sure.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_sure.DownBack = null;
            this.btn_sure.Location = new System.Drawing.Point(67, 111);
            this.btn_sure.MouseBack = null;
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.NormlBack = null;
            this.btn_sure.Size = new System.Drawing.Size(75, 23);
            this.btn_sure.TabIndex = 4;
            this.btn_sure.Text = "确定";
            this.btn_sure.UseVisualStyleBackColor = false;
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_cancel.DownBack = null;
            this.btn_cancel.Location = new System.Drawing.Point(150, 111);
            this.btn_cancel.MouseBack = null;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NormlBack = null;
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FrmSaveAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 150);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_sure);
            this.Controls.Add(this.tbox_password);
            this.Controls.Add(this.tbox_username);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSaveAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "请输入用户密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox tbox_username;
        private CCWin.SkinControl.SkinTextBox tbox_password;
        private CCWin.SkinControl.SkinButton btn_sure;
        private CCWin.SkinControl.SkinButton btn_cancel;
    }
}