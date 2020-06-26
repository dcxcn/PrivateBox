namespace PrivateBox.UserControls
{
    partial class PicViewer
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
            this.kpImageViewer1 = new PrivateBox.UserControls.KpImageViewer();
            this.SuspendLayout();
            // 
            // kpImageViewer1
            // 
            this.kpImageViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.kpImageViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kpImageViewer1.GifAnimation = true;
            this.kpImageViewer1.Image = null;
            this.kpImageViewer1.Location = new System.Drawing.Point(0, 0);
            this.kpImageViewer1.MenuColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MenuPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.MinimumSize = new System.Drawing.Size(454, 145);
            this.kpImageViewer1.Name = "kpImageViewer1";
            this.kpImageViewer1.NavigationPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.NavigationTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.OpenButton = false;
            this.kpImageViewer1.PreviewButton = false;
            this.kpImageViewer1.PreviewPanelColor = System.Drawing.Color.LightSteelBlue;
            this.kpImageViewer1.PreviewText = "预览";
            this.kpImageViewer1.PreviewTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kpImageViewer1.Rotation = 0;
            this.kpImageViewer1.ShowPreview = true;
            this.kpImageViewer1.Size = new System.Drawing.Size(570, 287);
            this.kpImageViewer1.TabIndex = 0;
            this.kpImageViewer1.TextColor = System.Drawing.SystemColors.ButtonHighlight;
            // 
            // PicViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.kpImageViewer1);
            this.Name = "PicViewer";
            this.Size = new System.Drawing.Size(570, 287);
            this.ResumeLayout(false);

        }

        #endregion

        private KpImageViewer kpImageViewer1;
    }
}
