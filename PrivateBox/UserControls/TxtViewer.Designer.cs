namespace PrivateBox.UserControls
{
    partial class TxtViewer
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtfRichTextBox1 = new CCWin.SkinControl.RtfRichTextBox();
            this.SuspendLayout();
            // 
            // rtfRichTextBox1
            // 
            this.rtfRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfRichTextBox1.HiglightColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.White;
            this.rtfRichTextBox1.Location = new System.Drawing.Point(0, 0);
            this.rtfRichTextBox1.Name = "rtfRichTextBox1";
            this.rtfRichTextBox1.Size = new System.Drawing.Size(306, 307);
            this.rtfRichTextBox1.TabIndex = 0;
            this.rtfRichTextBox1.Text = "";
            this.rtfRichTextBox1.TextColor = CCWin.SkinControl.RtfRichTextBox.RtfColor.Black;
            // 
            // TxtViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rtfRichTextBox1);
            this.Name = "TxtViewer";
            this.Size = new System.Drawing.Size(306, 307);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.RtfRichTextBox rtfRichTextBox1;
    }
}
