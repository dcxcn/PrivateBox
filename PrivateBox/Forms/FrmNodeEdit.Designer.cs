using CCWin.SkinControl;

namespace PrivateBox.Forms
{
    partial class FrmNodeEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNodeEdit));
            this.btn_saveNode = new CCWin.SkinControl.SkinButton();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.textBox_NodeName = new CCWin.SkinControl.SkinTextBox();
            this.SuspendLayout();
            // 
            // btn_saveNode
            // 
            this.btn_saveNode.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveNode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_saveNode.DownBack = null;
            this.btn_saveNode.Location = new System.Drawing.Point(165, 95);
            this.btn_saveNode.MouseBack = null;
            this.btn_saveNode.Name = "btn_saveNode";
            this.btn_saveNode.NormlBack = null;
            this.btn_saveNode.Size = new System.Drawing.Size(75, 23);
            this.btn_saveNode.TabIndex = 0;
            this.btn_saveNode.Text = "保存";
            this.btn_saveNode.UseVisualStyleBackColor = true;
            this.btn_saveNode.Click += new System.EventHandler(this.btn_saveNode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "节点";
            // 
            // textBox_NodeName
            // 
            this.textBox_NodeName.BackColor = System.Drawing.Color.Transparent;
            this.textBox_NodeName.DownBack = null;
            this.textBox_NodeName.Icon = null;
            this.textBox_NodeName.IconIsButton = false;
            this.textBox_NodeName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_NodeName.IsPasswordChat = '\0';
            this.textBox_NodeName.IsSystemPasswordChar = false;
            this.textBox_NodeName.Lines = new string[0];
            this.textBox_NodeName.Location = new System.Drawing.Point(60, 42);
            this.textBox_NodeName.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_NodeName.MaxLength = 32767;
            this.textBox_NodeName.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox_NodeName.MouseBack = null;
            this.textBox_NodeName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_NodeName.Multiline = false;
            this.textBox_NodeName.Name = "textBox_NodeName";
            this.textBox_NodeName.NormlBack = null;
            this.textBox_NodeName.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_NodeName.ReadOnly = false;
            this.textBox_NodeName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_NodeName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.textBox_NodeName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NodeName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_NodeName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox_NodeName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox_NodeName.SkinTxt.Name = "BaseText";
            this.textBox_NodeName.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.textBox_NodeName.SkinTxt.TabIndex = 0;
            this.textBox_NodeName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_NodeName.SkinTxt.WaterText = "";
            this.textBox_NodeName.TabIndex = 3;
            this.textBox_NodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_NodeName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_NodeName.WaterText = "";
            this.textBox_NodeName.WordWrap = true;
            // 
            // FrmNodeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 147);
            this.Controls.Add(this.textBox_NodeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_saveNode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNodeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "节点编辑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinButton btn_saveNode;
        private SkinLabel label1;
        private SkinTextBox textBox_NodeName;
    }
}