namespace PrivateBox.Forms
{
    partial class FrmPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlayer));
            this.timMsg = new System.Windows.Forms.Timer(this.components);
            this.timShow = new System.Windows.Forms.Timer(this.components);
            this.timBack = new System.Windows.Forms.Timer(this.components);
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.axPlay = new AxAPlayer3Lib.AxPlayer();
            this.tbValue = new CCWin.SkinControl.SkinTrackBar();
            this.chkPlay = new CCWin.SkinControl.SkinCheckBox();
            this.chkVideoMusic = new CCWin.SkinControl.SkinCheckBox();
            this.btnVideoLeft = new CCWin.SkinControl.SkinButton();
            this.btnClosePlay = new CCWin.SkinControl.SkinButton();
            this.btnVideoRight = new CCWin.SkinControl.SkinButton();
            this.tbMusic = new CCWin.SkinControl.SkinTrackBar();
            this.labTime = new CCWin.SkinControl.SkinLabel();
            this.chkFullScreen = new CCWin.SkinControl.SkinCheckBox();
            this.lblMsg = new CCWin.SkinControl.SkinLabel();
            this.btnOpenVideoFile = new CCWin.SkinControl.SkinButton();
            this.pnlTool = new CCWin.SkinControl.SkinPanel();
            this.axPlayContextMenu = new CCWin.SkinControl.SkinContextMenuStrip();
            this.显示字幕ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.总是在最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放时在最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消最前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.axPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusic)).BeginInit();
            this.pnlTool.SuspendLayout();
            this.axPlayContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timMsg
            // 
            this.timMsg.Interval = 3000;
            this.timMsg.Tick += new System.EventHandler(this.timMsg_Tick);
            // 
            // timShow
            // 
            this.timShow.Enabled = true;
            this.timShow.Interval = 200;
            this.timShow.Tick += new System.EventHandler(this.timShow_Tick);
            // 
            // timBack
            // 
            this.timBack.Enabled = true;
            this.timBack.Interval = 5000;
            // 
            // axPlay
            // 
            this.axPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axPlay.Enabled = true;
            this.axPlay.Location = new System.Drawing.Point(4, 28);
            this.axPlay.Name = "axPlay";
            this.axPlay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axPlay.OcxState")));
            this.axPlay.Size = new System.Drawing.Size(557, 333);
            this.axPlay.TabIndex = 0;
            this.axPlay.OnMessage += new AxAPlayer3Lib._IPlayerEvents_OnMessageEventHandler(this.axPlay_OnMessage);
            this.axPlay.OnStateChanged += new AxAPlayer3Lib._IPlayerEvents_OnStateChangedEventHandler(this.axPlay_OnStateChanged);
            this.axPlay.OnOpenSucceeded += new System.EventHandler(this.axPlay_OnOpenSucceeded);
            this.axPlay.OnSeekCompleted += new AxAPlayer3Lib._IPlayerEvents_OnSeekCompletedEventHandler(this.axPlay_OnSeekCompleted);
            this.axPlay.OnBuffer += new AxAPlayer3Lib._IPlayerEvents_OnBufferEventHandler(this.axPlay_OnBuffer);
            this.axPlay.OnDownloadCodec += new AxAPlayer3Lib._IPlayerEvents_OnDownloadCodecEventHandler(this.axPlay_OnDownloadCodec);
            this.axPlay.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.axPlay_PreviewKeyDown);
            // 
            // tbValue
            // 
            this.tbValue.AutoSize = false;
            this.tbValue.BackColor = System.Drawing.Color.Transparent;
            this.tbValue.Bar = ((System.Drawing.Image)(resources.GetObject("tbValue.Bar")));
            this.tbValue.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.tbValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbValue.Location = new System.Drawing.Point(3, 3);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(551, 10);
            this.tbValue.TabIndex = 0;
            this.tbValue.Track = ((System.Drawing.Image)(resources.GetObject("tbValue.Track")));
            this.tbValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbValue_MouseDown);
            this.tbValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbValue_MouseUp);
            // 
            // chkPlay
            // 
            this.chkPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkPlay.BackColor = System.Drawing.Color.Transparent;
            this.chkPlay.Checked = true;
            this.chkPlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlay.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkPlay.DefaultCheckButtonWidth = 20;
            this.chkPlay.DownBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.DownBack")));
            this.chkPlay.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkPlay.Location = new System.Drawing.Point(243, 17);
            this.chkPlay.MouseBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.MouseBack")));
            this.chkPlay.Name = "chkPlay";
            this.chkPlay.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.NormlBack")));
            this.chkPlay.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.SelectedDownBack")));
            this.chkPlay.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.SelectedMouseBack")));
            this.chkPlay.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("chkPlay.SelectedNormlBack")));
            this.chkPlay.Size = new System.Drawing.Size(24, 24);
            this.chkPlay.TabIndex = 3;
            this.chkPlay.UseVisualStyleBackColor = false;
            this.chkPlay.CheckedChanged += new System.EventHandler(this.chkPlay_CheckedChanged);
            // 
            // chkVideoMusic
            // 
            this.chkVideoMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkVideoMusic.AutoSize = true;
            this.chkVideoMusic.BackColor = System.Drawing.Color.Transparent;
            this.chkVideoMusic.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkVideoMusic.DefaultCheckButtonWidth = 15;
            this.chkVideoMusic.DownBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.DownBack")));
            this.chkVideoMusic.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkVideoMusic.Location = new System.Drawing.Point(307, 22);
            this.chkVideoMusic.MouseBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.MouseBack")));
            this.chkVideoMusic.Name = "chkVideoMusic";
            this.chkVideoMusic.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.NormlBack")));
            this.chkVideoMusic.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.SelectedDownBack")));
            this.chkVideoMusic.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.SelectedMouseBack")));
            this.chkVideoMusic.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("chkVideoMusic.SelectedNormlBack")));
            this.chkVideoMusic.Size = new System.Drawing.Size(15, 14);
            this.chkVideoMusic.TabIndex = 3;
            this.chkVideoMusic.UseVisualStyleBackColor = false;
            this.chkVideoMusic.CheckedChanged += new System.EventHandler(this.chkVideoMusic_CheckedChanged);
            // 
            // btnVideoLeft
            // 
            this.btnVideoLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideoLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnVideoLeft.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnVideoLeft.DownBack = ((System.Drawing.Image)(resources.GetObject("btnVideoLeft.DownBack")));
            this.btnVideoLeft.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnVideoLeft.Location = new System.Drawing.Point(211, 19);
            this.btnVideoLeft.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnVideoLeft.MouseBack")));
            this.btnVideoLeft.Name = "btnVideoLeft";
            this.btnVideoLeft.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnVideoLeft.NormlBack")));
            this.btnVideoLeft.Size = new System.Drawing.Size(24, 20);
            this.btnVideoLeft.TabIndex = 4;
            this.btnVideoLeft.UseVisualStyleBackColor = false;
            this.btnVideoLeft.Click += new System.EventHandler(this.btnVideoLeft_Click);
            // 
            // btnClosePlay
            // 
            this.btnClosePlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClosePlay.BackColor = System.Drawing.Color.Transparent;
            this.btnClosePlay.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnClosePlay.DownBack = ((System.Drawing.Image)(resources.GetObject("btnClosePlay.DownBack")));
            this.btnClosePlay.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnClosePlay.Location = new System.Drawing.Point(181, 19);
            this.btnClosePlay.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnClosePlay.MouseBack")));
            this.btnClosePlay.Name = "btnClosePlay";
            this.btnClosePlay.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnClosePlay.NormlBack")));
            this.btnClosePlay.Size = new System.Drawing.Size(20, 20);
            this.btnClosePlay.TabIndex = 4;
            this.btnClosePlay.UseVisualStyleBackColor = false;
            this.btnClosePlay.Click += new System.EventHandler(this.btnClosePlay_Click);
            // 
            // btnVideoRight
            // 
            this.btnVideoRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVideoRight.BackColor = System.Drawing.Color.Transparent;
            this.btnVideoRight.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnVideoRight.DownBack = ((System.Drawing.Image)(resources.GetObject("btnVideoRight.DownBack")));
            this.btnVideoRight.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnVideoRight.Location = new System.Drawing.Point(275, 19);
            this.btnVideoRight.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnVideoRight.MouseBack")));
            this.btnVideoRight.Name = "btnVideoRight";
            this.btnVideoRight.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnVideoRight.NormlBack")));
            this.btnVideoRight.Size = new System.Drawing.Size(24, 20);
            this.btnVideoRight.TabIndex = 4;
            this.btnVideoRight.UseVisualStyleBackColor = false;
            this.btnVideoRight.Click += new System.EventHandler(this.btnVideoRight_Click);
            // 
            // tbMusic
            // 
            this.tbMusic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMusic.AutoSize = false;
            this.tbMusic.BackColor = System.Drawing.Color.Transparent;
            this.tbMusic.BackRectangle = new System.Drawing.Rectangle(1, 1, 1, 1);
            this.tbMusic.Bar = ((System.Drawing.Image)(resources.GetObject("tbMusic.Bar")));
            this.tbMusic.BarStyle = CCWin.SkinControl.HSLTrackBarStyle.Img;
            this.tbMusic.Location = new System.Drawing.Point(330, 24);
            this.tbMusic.Name = "tbMusic";
            this.tbMusic.Size = new System.Drawing.Size(45, 10);
            this.tbMusic.TabIndex = 2;
            this.tbMusic.Track = ((System.Drawing.Image)(resources.GetObject("tbMusic.Track")));
            this.tbMusic.Value = 100;
            this.tbMusic.ValueChanged += new System.EventHandler(this.tbMusic_ValueChanged);
            // 
            // labTime
            // 
            this.labTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labTime.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.labTime.BackColor = System.Drawing.Color.Transparent;
            this.labTime.BorderColor = System.Drawing.Color.White;
            this.labTime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.labTime.Location = new System.Drawing.Point(6, 22);
            this.labTime.Name = "labTime";
            this.labTime.Size = new System.Drawing.Size(117, 17);
            this.labTime.TabIndex = 1;
            this.labTime.Tag = "00:00:00 / 00:00:00";
            this.labTime.Text = "00:00:00 / 00:00:00";
            this.labTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chkFullScreen.BackColor = System.Drawing.Color.Transparent;
            this.chkFullScreen.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.chkFullScreen.DefaultCheckButtonWidth = 20;
            this.chkFullScreen.DownBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.DownBack")));
            this.chkFullScreen.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkFullScreen.Location = new System.Drawing.Point(527, 18);
            this.chkFullScreen.MouseBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.MouseBack")));
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.NormlBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.NormlBack")));
            this.chkFullScreen.SelectedDownBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.SelectedDownBack")));
            this.chkFullScreen.SelectedMouseBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.SelectedMouseBack")));
            this.chkFullScreen.SelectedNormlBack = ((System.Drawing.Image)(resources.GetObject("chkFullScreen.SelectedNormlBack")));
            this.chkFullScreen.Size = new System.Drawing.Size(24, 24);
            this.chkFullScreen.TabIndex = 5;
            this.chkFullScreen.UseVisualStyleBackColor = false;
            this.chkFullScreen.CheckedChanged += new System.EventHandler(this.chkFullScreen_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.Color.Transparent;
            this.lblMsg.BorderColor = System.Drawing.Color.White;
            this.lblMsg.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg.Location = new System.Drawing.Point(125, 22);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(32, 17);
            this.lblMsg.TabIndex = 8;
            this.lblMsg.Tag = "搜播";
            this.lblMsg.Text = "搜播";
            this.lblMsg.Visible = false;
            // 
            // btnOpenVideoFile
            // 
            this.btnOpenVideoFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenVideoFile.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenVideoFile.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOpenVideoFile.DownBack = ((System.Drawing.Image)(resources.GetObject("btnOpenVideoFile.DownBack")));
            this.btnOpenVideoFile.DrawType = CCWin.SkinControl.DrawStyle.Img;
            this.btnOpenVideoFile.Location = new System.Drawing.Point(501, 20);
            this.btnOpenVideoFile.MouseBack = ((System.Drawing.Image)(resources.GetObject("btnOpenVideoFile.MouseBack")));
            this.btnOpenVideoFile.Name = "btnOpenVideoFile";
            this.btnOpenVideoFile.NormlBack = ((System.Drawing.Image)(resources.GetObject("btnOpenVideoFile.NormlBack")));
            this.btnOpenVideoFile.Size = new System.Drawing.Size(20, 20);
            this.btnOpenVideoFile.TabIndex = 9;
            this.btnOpenVideoFile.UseVisualStyleBackColor = false;
            this.btnOpenVideoFile.Click += new System.EventHandler(this.btnOpenVideoFile_Click);
            // 
            // pnlTool
            // 
            this.pnlTool.BackColor = System.Drawing.Color.Transparent;
            this.pnlTool.Controls.Add(this.btnOpenVideoFile);
            this.pnlTool.Controls.Add(this.lblMsg);
            this.pnlTool.Controls.Add(this.chkFullScreen);
            this.pnlTool.Controls.Add(this.labTime);
            this.pnlTool.Controls.Add(this.tbMusic);
            this.pnlTool.Controls.Add(this.btnVideoRight);
            this.pnlTool.Controls.Add(this.btnClosePlay);
            this.pnlTool.Controls.Add(this.btnVideoLeft);
            this.pnlTool.Controls.Add(this.chkVideoMusic);
            this.pnlTool.Controls.Add(this.chkPlay);
            this.pnlTool.Controls.Add(this.tbValue);
            this.pnlTool.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTool.DownBack = null;
            this.pnlTool.Location = new System.Drawing.Point(4, 313);
            this.pnlTool.MouseBack = null;
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.NormlBack = null;
            this.pnlTool.Padding = new System.Windows.Forms.Padding(3);
            this.pnlTool.Size = new System.Drawing.Size(557, 48);
            this.pnlTool.TabIndex = 8;
            // 
            // axPlayContextMenu
            // 
            this.axPlayContextMenu.Arrow = System.Drawing.Color.Black;
            this.axPlayContextMenu.Back = System.Drawing.Color.White;
            this.axPlayContextMenu.BackRadius = 4;
            this.axPlayContextMenu.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.axPlayContextMenu.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(204)))));
            this.axPlayContextMenu.Fore = System.Drawing.Color.Black;
            this.axPlayContextMenu.HoverFore = System.Drawing.Color.White;
            this.axPlayContextMenu.ItemAnamorphosis = false;
            this.axPlayContextMenu.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.axPlayContextMenu.ItemBorderShow = false;
            this.axPlayContextMenu.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.axPlayContextMenu.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.axPlayContextMenu.ItemRadius = 4;
            this.axPlayContextMenu.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.axPlayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示字幕ToolStripMenuItem,
            this.在最前ToolStripMenuItem});
            this.axPlayContextMenu.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.axPlayContextMenu.Name = "SoTypeMenu";
            this.axPlayContextMenu.RadiusStyle = CCWin.SkinClass.RoundStyle.None;
            this.axPlayContextMenu.Size = new System.Drawing.Size(153, 70);
            this.axPlayContextMenu.SkinAllColor = true;
            this.axPlayContextMenu.TitleAnamorphosis = false;
            this.axPlayContextMenu.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(208)))), ((int)(((byte)(255)))));
            this.axPlayContextMenu.TitleRadius = 4;
            this.axPlayContextMenu.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.None;
            // 
            // 显示字幕ToolStripMenuItem
            // 
            this.显示字幕ToolStripMenuItem.Name = "显示字幕ToolStripMenuItem";
            this.显示字幕ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.显示字幕ToolStripMenuItem.Text = "显示字幕";
            this.显示字幕ToolStripMenuItem.Click += new System.EventHandler(this.显示字幕ToolStripMenuItem_Click);
            // 
            // 在最前ToolStripMenuItem
            // 
            this.在最前ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.总是在最前ToolStripMenuItem,
            this.播放时在最前ToolStripMenuItem,
            this.取消最前ToolStripMenuItem});
            this.在最前ToolStripMenuItem.Name = "在最前ToolStripMenuItem";
            this.在最前ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.在最前ToolStripMenuItem.Text = "在最前";
            // 
            // 总是在最前ToolStripMenuItem
            // 
            this.总是在最前ToolStripMenuItem.CheckOnClick = true;
            this.总是在最前ToolStripMenuItem.Name = "总是在最前ToolStripMenuItem";
            this.总是在最前ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.总是在最前ToolStripMenuItem.Text = "总是在最前";
            this.总是在最前ToolStripMenuItem.Click += new System.EventHandler(this.总是在最前ToolStripMenuItem_Click);
            // 
            // 播放时在最前ToolStripMenuItem
            // 
            this.播放时在最前ToolStripMenuItem.CheckOnClick = true;
            this.播放时在最前ToolStripMenuItem.Name = "播放时在最前ToolStripMenuItem";
            this.播放时在最前ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.播放时在最前ToolStripMenuItem.Text = "播放时在最前";
            this.播放时在最前ToolStripMenuItem.Click += new System.EventHandler(this.播放时在最前ToolStripMenuItem_Click);
            // 
            // 取消最前ToolStripMenuItem
            // 
            this.取消最前ToolStripMenuItem.Name = "取消最前ToolStripMenuItem";
            this.取消最前ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.取消最前ToolStripMenuItem.Text = "取消最前";
            this.取消最前ToolStripMenuItem.Click += new System.EventHandler(this.取消最前ToolStripMenuItem_Click);
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 365);
            this.Controls.Add(this.pnlTool);
            this.Controls.Add(this.axPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlayer";
            ((System.ComponentModel.ISupportInitialize)(this.axPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusic)).EndInit();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            this.axPlayContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timMsg;
        private System.Windows.Forms.Timer timShow;
        private System.Windows.Forms.Timer timBack;
        private System.Windows.Forms.ToolTip ToolTip;
        private AxAPlayer3Lib.AxPlayer axPlay;
        private CCWin.SkinControl.SkinTrackBar tbValue;
        private CCWin.SkinControl.SkinCheckBox chkPlay;
        private CCWin.SkinControl.SkinCheckBox chkVideoMusic;
        private CCWin.SkinControl.SkinButton btnVideoLeft;
        private CCWin.SkinControl.SkinButton btnClosePlay;
        private CCWin.SkinControl.SkinButton btnVideoRight;
        private CCWin.SkinControl.SkinTrackBar tbMusic;
        private CCWin.SkinControl.SkinLabel labTime;
        private CCWin.SkinControl.SkinCheckBox chkFullScreen;
        private CCWin.SkinControl.SkinLabel lblMsg;
        private CCWin.SkinControl.SkinButton btnOpenVideoFile;
        private CCWin.SkinControl.SkinPanel pnlTool;
        private CCWin.SkinControl.SkinContextMenuStrip axPlayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem 显示字幕ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 总是在最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放时在最前ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消最前ToolStripMenuItem;
    }
}
