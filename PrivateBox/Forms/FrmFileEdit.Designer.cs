using CCWin.SkinControl;

namespace PrivateBox.Forms
{
    partial class FrmFileEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFileEdit));
            this.btn_saveFile = new CCWin.SkinControl.SkinButton();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.textBox_FileName = new CCWin.SkinControl.SkinTextBox();
            this.textBox_FilePath = new CCWin.SkinControl.SkinTextBox();
            this.btn_browser = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btn_saveFile
            // 
            this.btn_saveFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_saveFile.DownBack = null;
            this.btn_saveFile.Location = new System.Drawing.Point(334, 136);
            this.btn_saveFile.MouseBack = null;
            this.btn_saveFile.Name = "btn_saveFile";
            this.btn_saveFile.NormlBack = null;
            this.btn_saveFile.Size = new System.Drawing.Size(75, 23);
            this.btn_saveFile.TabIndex = 0;
            this.btn_saveFile.Text = "保存";
            this.btn_saveFile.UseVisualStyleBackColor = true;
            this.btn_saveFile.Click += new System.EventHandler(this.btn_saveNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件名";
            // 
            // textBox_FileName
            // 
            this.textBox_FileName.BackColor = System.Drawing.Color.Transparent;
            this.textBox_FileName.DownBack = null;
            this.textBox_FileName.Icon = null;
            this.textBox_FileName.IconIsButton = false;
            this.textBox_FileName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_FileName.IsPasswordChat = '\0';
            this.textBox_FileName.IsSystemPasswordChar = false;
            this.textBox_FileName.Lines = new string[0];
            this.textBox_FileName.Location = new System.Drawing.Point(60, 42);
            this.textBox_FileName.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_FileName.MaxLength = 32767;
            this.textBox_FileName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox_FileName.MouseBack = null;
            this.textBox_FileName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_FileName.Multiline = false;
            this.textBox_FileName.Name = "textBox_FileName";
            this.textBox_FileName.NormlBack = null;
            this.textBox_FileName.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_FileName.ReadOnly = false;
            this.textBox_FileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_FileName.Size = new System.Drawing.Size(351, 28);
            // 
            // 
            // 
            this.textBox_FileName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FileName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FileName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox_FileName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox_FileName.SkinTxt.Name = "BaseText";
            this.textBox_FileName.SkinTxt.Size = new System.Drawing.Size(341, 18);
            this.textBox_FileName.SkinTxt.TabIndex = 0;
            this.textBox_FileName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_FileName.SkinTxt.WaterText = "";
            this.textBox_FileName.TabIndex = 3;
            this.textBox_FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_FileName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_FileName.WaterText = "";
            this.textBox_FileName.WordWrap = true;
            // 
            // textBox_FilePath
            // 
            this.textBox_FilePath.BackColor = System.Drawing.Color.Transparent;
            this.textBox_FilePath.DownBack = null;
            this.textBox_FilePath.Enabled = false;
            this.textBox_FilePath.Icon = null;
            this.textBox_FilePath.IconIsButton = false;
            this.textBox_FilePath.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_FilePath.IsPasswordChat = '\0';
            this.textBox_FilePath.IsSystemPasswordChar = false;
            this.textBox_FilePath.Lines = new string[0];
            this.textBox_FilePath.Location = new System.Drawing.Point(60, 89);
            this.textBox_FilePath.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_FilePath.MaxLength = 32767;
            this.textBox_FilePath.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox_FilePath.MouseBack = null;
            this.textBox_FilePath.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_FilePath.Multiline = false;
            this.textBox_FilePath.Name = "textBox_FilePath";
            this.textBox_FilePath.NormlBack = null;
            this.textBox_FilePath.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_FilePath.ReadOnly = false;
            this.textBox_FilePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_FilePath.Size = new System.Drawing.Size(268, 28);
            // 
            // 
            // 
            this.textBox_FilePath.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_FilePath.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_FilePath.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox_FilePath.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox_FilePath.SkinTxt.Name = "BaseText";
            this.textBox_FilePath.SkinTxt.Size = new System.Drawing.Size(258, 18);
            this.textBox_FilePath.SkinTxt.TabIndex = 0;
            this.textBox_FilePath.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_FilePath.SkinTxt.WaterText = "";
            this.textBox_FilePath.TabIndex = 4;
            this.textBox_FilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_FilePath.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_FilePath.WaterText = "";
            this.textBox_FilePath.WordWrap = true;
            // 
            // btn_browser
            // 
            this.btn_browser.BackColor = System.Drawing.Color.Transparent;
            this.btn_browser.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_browser.DownBack = null;
            this.btn_browser.Location = new System.Drawing.Point(334, 94);
            this.btn_browser.MouseBack = null;
            this.btn_browser.Name = "btn_browser";
            this.btn_browser.NormlBack = null;
            this.btn_browser.Size = new System.Drawing.Size(77, 23);
            this.btn_browser.TabIndex = 5;
            this.btn_browser.Text = "浏览新文件";
            this.btn_browser.UseVisualStyleBackColor = true;
            this.btn_browser.Click += new System.EventHandler(this.btn_browser_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(13, 96);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(32, 17);
            this.skinLabel1.TabIndex = 6;
            this.skinLabel1.Text = "文件";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // FrmFileEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 175);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.btn_browser);
            this.Controls.Add(this.textBox_FilePath);
            this.Controls.Add(this.textBox_FileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saveFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmFileEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "文件编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinButton btn_saveFile;
        private SkinLabel label1;
        private SkinTextBox textBox_FileName;
        private SkinTextBox textBox_FilePath;
        private SkinButton btn_browser;
        private SkinLabel skinLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}