using CCWin.SkinControl;

namespace PrivateBox
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("根目录");
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            CCWin.CmSysButton cmSysButton1 = new CCWin.CmSysButton();
            this.contextMenuStripGridView = new CCWin.SkinControl.SkinContextMenuStrip();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer3 = new CCWin.SkinControl.SkinSplitContainer();
            this.ckBox_showFname = new CCWin.SkinControl.SkinCheckBox();
            this.textBox_search = new CCWin.SkinControl.SkinTextBox();
            this.btn_newPBox = new CCWin.SkinControl.SkinButton();
            this.btn_openPBox = new CCWin.SkinControl.SkinButton();
            this.splitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.treeView_nav = new CCWin.SkinControl.SkinTreeView();
            this.splitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skinSplitContainer_DataGridView = new CCWin.SkinControl.SkinSplitContainer();
            this.imgLoadding = new System.Windows.Forms.PictureBox();
            this.dataGridView_FileList = new CCWin.SkinControl.SkinDataGridView();
            this.file_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file_nodeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagerControl1 = new PrivateBox.UserControls.PagerControl();
            this.tabControl_Viewer = new CCWin.SkinControl.SkinTabControl();
            this.contextMenuStrip_nav = new CCWin.SkinControl.SkinContextMenuStrip();
            this.添加节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上移节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下移节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除节点ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_PBox = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStrip_SysBtn1 = new CCWin.SkinControl.SkinContextMenuStrip();
            this.设置密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收缩空间ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置文件关联ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清理缓存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog_File = new System.Windows.Forms.SaveFileDialog();
            this.contextMenuStripGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer_DataGridView)).BeginInit();
            this.skinSplitContainer_DataGridView.Panel1.SuspendLayout();
            this.skinSplitContainer_DataGridView.Panel2.SuspendLayout();
            this.skinSplitContainer_DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FileList)).BeginInit();
            this.contextMenuStrip_nav.SuspendLayout();
            this.contextMenuStrip_SysBtn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripGridView
            // 
            this.contextMenuStripGridView.Arrow = System.Drawing.Color.Black;
            this.contextMenuStripGridView.Back = System.Drawing.Color.White;
            this.contextMenuStripGridView.BackRadius = 4;
            this.contextMenuStripGridView.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.contextMenuStripGridView.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.contextMenuStripGridView.Fore = System.Drawing.Color.Black;
            this.contextMenuStripGridView.HoverFore = System.Drawing.Color.White;
            this.contextMenuStripGridView.ItemAnamorphosis = true;
            this.contextMenuStripGridView.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStripGridView.ItemBorderShow = true;
            this.contextMenuStripGridView.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStripGridView.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStripGridView.ItemRadius = 4;
            this.contextMenuStripGridView.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStripGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改ToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.contextMenuStripGridView.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStripGridView.Name = "contextMenuStripGridView";
            this.contextMenuStripGridView.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStripGridView.Size = new System.Drawing.Size(113, 70);
            this.contextMenuStripGridView.SkinAllColor = true;
            this.contextMenuStripGridView.TitleAnamorphosis = true;
            this.contextMenuStripGridView.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.contextMenuStripGridView.TitleRadius = 4;
            this.contextMenuStripGridView.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteToolStripMenuItem.Text = "删除";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "另存为";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(4, 28);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ckBox_showFname);
            this.splitContainer3.Panel1.Controls.Add(this.textBox_search);
            this.splitContainer3.Panel1.Controls.Add(this.btn_newPBox);
            this.splitContainer3.Panel1.Controls.Add(this.btn_openPBox);
            this.splitContainer3.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(808, 448);
            this.splitContainer3.SplitterDistance = 40;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 1;
            // 
            // ckBox_showFname
            // 
            this.ckBox_showFname.AutoSize = true;
            this.ckBox_showFname.BackColor = System.Drawing.Color.Transparent;
            this.ckBox_showFname.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.ckBox_showFname.DownBack = null;
            this.ckBox_showFname.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ckBox_showFname.Location = new System.Drawing.Point(120, 10);
            this.ckBox_showFname.MouseBack = null;
            this.ckBox_showFname.Name = "ckBox_showFname";
            this.ckBox_showFname.NormlBack = null;
            this.ckBox_showFname.SelectedDownBack = null;
            this.ckBox_showFname.SelectedMouseBack = null;
            this.ckBox_showFname.SelectedNormlBack = null;
            this.ckBox_showFname.Size = new System.Drawing.Size(87, 21);
            this.ckBox_showFname.TabIndex = 8;
            this.ckBox_showFname.Text = "显示文件名";
            this.ckBox_showFname.UseVisualStyleBackColor = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search.BackColor = System.Drawing.Color.Transparent;
            this.textBox_search.DownBack = null;
            this.textBox_search.Icon = null;
            this.textBox_search.IconIsButton = false;
            this.textBox_search.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_search.IsPasswordChat = '\0';
            this.textBox_search.IsSystemPasswordChar = false;
            this.textBox_search.Lines = new string[0];
            this.textBox_search.Location = new System.Drawing.Point(438, 5);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(0);
            this.textBox_search.MaxLength = 32767;
            this.textBox_search.MinimumSize = new System.Drawing.Size(28, 28);
            this.textBox_search.MouseBack = null;
            this.textBox_search.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.NormlBack = null;
            this.textBox_search.Padding = new System.Windows.Forms.Padding(5);
            this.textBox_search.ReadOnly = false;
            this.textBox_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox_search.Size = new System.Drawing.Size(369, 30);
            // 
            // 
            // 
            this.textBox_search.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_search.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_search.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.textBox_search.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.textBox_search.SkinTxt.Multiline = true;
            this.textBox_search.SkinTxt.Name = "BaseText";
            this.textBox_search.SkinTxt.Size = new System.Drawing.Size(359, 20);
            this.textBox_search.SkinTxt.TabIndex = 0;
            this.textBox_search.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_search.SkinTxt.WaterText = "请输入搜索文件名";
            this.textBox_search.TabIndex = 7;
            this.textBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_search.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.textBox_search.WaterText = "请输入搜索文件名";
            this.textBox_search.WordWrap = true;
            // 
            // btn_newPBox
            // 
            this.btn_newPBox.BackColor = System.Drawing.Color.Transparent;
            this.btn_newPBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_newPBox.DownBack = null;
            this.btn_newPBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_newPBox.Location = new System.Drawing.Point(57, 3);
            this.btn_newPBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_newPBox.MouseBack = null;
            this.btn_newPBox.Name = "btn_newPBox";
            this.btn_newPBox.NormlBack = null;
            this.btn_newPBox.Size = new System.Drawing.Size(48, 33);
            this.btn_newPBox.TabIndex = 6;
            this.btn_newPBox.Text = "新增";
            this.btn_newPBox.UseVisualStyleBackColor = false;
            this.btn_newPBox.Click += new System.EventHandler(this.btn_newPBox_Click);
            // 
            // btn_openPBox
            // 
            this.btn_openPBox.BackColor = System.Drawing.Color.Transparent;
            this.btn_openPBox.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_openPBox.DownBack = null;
            this.btn_openPBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_openPBox.Location = new System.Drawing.Point(3, 3);
            this.btn_openPBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_openPBox.MouseBack = null;
            this.btn_openPBox.Name = "btn_openPBox";
            this.btn_openPBox.NormlBack = null;
            this.btn_openPBox.Size = new System.Drawing.Size(48, 33);
            this.btn_openPBox.TabIndex = 4;
            this.btn_openPBox.Text = "打开";
            this.btn_openPBox.UseVisualStyleBackColor = false;
            this.btn_openPBox.Click += new System.EventHandler(this.btn_openPBox_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.treeView_nav);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(808, 402);
            this.splitContainer2.SplitterDistance = 153;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 1;
            // 
            // treeView_nav
            // 
            this.treeView_nav.AllowDrop = true;
            this.treeView_nav.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_nav.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView_nav.Location = new System.Drawing.Point(0, 0);
            this.treeView_nav.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView_nav.Name = "treeView_nav";
            treeNode1.Name = "节点0";
            treeNode1.Tag = "0";
            treeNode1.Text = "根目录";
            this.treeView_nav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView_nav.Size = new System.Drawing.Size(153, 402);
            this.treeView_nav.TabIndex = 2;
            this.treeView_nav.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_nav_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.skinSplitContainer_DataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl_Viewer);
            this.splitContainer1.Size = new System.Drawing.Size(650, 402);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 0;
            // 
            // skinSplitContainer_DataGridView
            // 
            this.skinSplitContainer_DataGridView.CollapsePanel = CCWin.SkinControl.CollapsePanel.None;
            this.skinSplitContainer_DataGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer_DataGridView.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.skinSplitContainer_DataGridView.IsSplitterFixed = true;
            this.skinSplitContainer_DataGridView.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer_DataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.skinSplitContainer_DataGridView.Name = "skinSplitContainer_DataGridView";
            this.skinSplitContainer_DataGridView.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer_DataGridView.Panel1
            // 
            this.skinSplitContainer_DataGridView.Panel1.Controls.Add(this.imgLoadding);
            this.skinSplitContainer_DataGridView.Panel1.Controls.Add(this.dataGridView_FileList);
            // 
            // skinSplitContainer_DataGridView.Panel2
            // 
            this.skinSplitContainer_DataGridView.Panel2.Controls.Add(this.pagerControl1);
            this.skinSplitContainer_DataGridView.Size = new System.Drawing.Size(650, 199);
            this.skinSplitContainer_DataGridView.SplitterDistance = 136;
            this.skinSplitContainer_DataGridView.SplitterWidth = 6;
            this.skinSplitContainer_DataGridView.TabIndex = 0;
            // 
            // imgLoadding
            // 
            this.imgLoadding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgLoadding.BackColor = System.Drawing.Color.Transparent;
            this.imgLoadding.Image = ((System.Drawing.Image)(resources.GetObject("imgLoadding.Image")));
            this.imgLoadding.Location = new System.Drawing.Point(212, 13);
            this.imgLoadding.Name = "imgLoadding";
            this.imgLoadding.Size = new System.Drawing.Size(135, 134);
            this.imgLoadding.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLoadding.TabIndex = 18;
            this.imgLoadding.TabStop = false;
            this.imgLoadding.Visible = false;
            // 
            // dataGridView_FileList
            // 
            this.dataGridView_FileList.AllowUserToAddRows = false;
            this.dataGridView_FileList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dataGridView_FileList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_FileList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_FileList.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView_FileList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_FileList.ColumnFont = null;
            this.dataGridView_FileList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_FileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_FileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.file_id,
            this.file_name,
            this.file_type,
            this.file_size,
            this.file_nodeid});
            this.dataGridView_FileList.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_FileList.ContextMenuStrip = this.contextMenuStripGridView;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_FileList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_FileList.EnableHeadersVisualStyles = false;
            this.dataGridView_FileList.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView_FileList.HeadFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView_FileList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_FileList.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_FileList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_FileList.Name = "dataGridView_FileList";
            this.dataGridView_FileList.ReadOnly = true;
            this.dataGridView_FileList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_FileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView_FileList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_FileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_FileList.Size = new System.Drawing.Size(650, 136);
            this.dataGridView_FileList.TabIndex = 6;
            this.dataGridView_FileList.TitleBack = null;
            this.dataGridView_FileList.TitleBackColorBegin = System.Drawing.Color.White;
            this.dataGridView_FileList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.dataGridView_FileList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewImageList_CellDoubleClick);
            this.dataGridView_FileList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_FileList_CellFormatting);
            // 
            // file_id
            // 
            this.file_id.DataPropertyName = "file_id";
            this.file_id.FillWeight = 107.8173F;
            this.file_id.HeaderText = "文件标识";
            this.file_id.Name = "file_id";
            this.file_id.ReadOnly = true;
            // 
            // file_name
            // 
            this.file_name.DataPropertyName = "file_name";
            this.file_name.FillWeight = 107.8173F;
            this.file_name.HeaderText = "文件名称";
            this.file_name.Name = "file_name";
            this.file_name.ReadOnly = true;
            // 
            // file_type
            // 
            this.file_type.DataPropertyName = "file_type";
            this.file_type.FillWeight = 107.8173F;
            this.file_type.HeaderText = "文件类型";
            this.file_type.Name = "file_type";
            this.file_type.ReadOnly = true;
            // 
            // file_size
            // 
            this.file_size.DataPropertyName = "file_size";
            this.file_size.FillWeight = 107.8173F;
            this.file_size.HeaderText = "文件大小";
            this.file_size.Name = "file_size";
            this.file_size.ReadOnly = true;
            // 
            // file_nodeid
            // 
            this.file_nodeid.DataPropertyName = "file_nodeid";
            this.file_nodeid.FillWeight = 107.8173F;
            this.file_nodeid.HeaderText = "文件节点标识";
            this.file_nodeid.Name = "file_nodeid";
            this.file_nodeid.ReadOnly = true;
            // 
            // pagerControl1
            // 
            this.pagerControl1.BackColor = System.Drawing.Color.Transparent;
            this.pagerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagerControl1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pagerControl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.pagerControl1.JumpText = "跳转";
            this.pagerControl1.Location = new System.Drawing.Point(0, 0);
            this.pagerControl1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.pagerControl1.Name = "pagerControl1";
            this.pagerControl1.PageIndex = 1;
            this.pagerControl1.PageSize = 100;
            this.pagerControl1.RecordCount = 0;
            this.pagerControl1.Size = new System.Drawing.Size(650, 57);
            this.pagerControl1.TabIndex = 0;
            this.pagerControl1.OnPageChanged += new System.EventHandler(this.pagerControl1_OnPageChanged);
            // 
            // tabControl_Viewer
            // 
            this.tabControl_Viewer.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl_Viewer.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Viewer.HeadBack = null;
            this.tabControl_Viewer.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl_Viewer.ItemSize = new System.Drawing.Size(70, 36);
            this.tabControl_Viewer.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Viewer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl_Viewer.Name = "tabControl_Viewer";
            this.tabControl_Viewer.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageArrowDown")));
            this.tabControl_Viewer.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageArrowHover")));
            this.tabControl_Viewer.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageCloseHover")));
            this.tabControl_Viewer.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageCloseNormal")));
            this.tabControl_Viewer.PageCloseVisble = true;
            this.tabControl_Viewer.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageDown")));
            this.tabControl_Viewer.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl_Viewer.PageHover")));
            this.tabControl_Viewer.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl_Viewer.PageNorml = null;
            this.tabControl_Viewer.Size = new System.Drawing.Size(650, 197);
            this.tabControl_Viewer.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl_Viewer.TabIndex = 0;
            this.tabControl_Viewer.TabePageClosed += new CCWin.SkinControl.SkinTabControl.ClosedTabePageHandler(this.tabControl_Viewer_TabePageClosed);
            this.tabControl_Viewer.TabePageClosing += new CCWin.SkinControl.SkinTabControl.ClosingTabePageHandler(this.tabControl_Viewer_TabePageClosing);
            this.tabControl_Viewer.DoubleClick += new System.EventHandler(this.tabControl_Viewer_DoubleClick);
            // 
            // contextMenuStrip_nav
            // 
            this.contextMenuStrip_nav.Arrow = System.Drawing.Color.Black;
            this.contextMenuStrip_nav.Back = System.Drawing.Color.White;
            this.contextMenuStrip_nav.BackRadius = 4;
            this.contextMenuStrip_nav.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.contextMenuStrip_nav.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.contextMenuStrip_nav.Fore = System.Drawing.Color.Black;
            this.contextMenuStrip_nav.HoverFore = System.Drawing.Color.White;
            this.contextMenuStrip_nav.ItemAnamorphosis = true;
            this.contextMenuStrip_nav.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_nav.ItemBorderShow = true;
            this.contextMenuStrip_nav.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_nav.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_nav.ItemRadius = 4;
            this.contextMenuStrip_nav.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStrip_nav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加节点ToolStripMenuItem,
            this.修改节点ToolStripMenuItem,
            this.剪切节点ToolStripMenuItem,
            this.粘贴节点ToolStripMenuItem,
            this.上移节点ToolStripMenuItem,
            this.下移节点ToolStripMenuItem,
            this.删除节点ToolStripMenuItem,
            this.添加文件ToolStripMenuItem});
            this.contextMenuStrip_nav.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_nav.Name = "contextMenuStrip_nav";
            this.contextMenuStrip_nav.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStrip_nav.Size = new System.Drawing.Size(125, 180);
            this.contextMenuStrip_nav.SkinAllColor = true;
            this.contextMenuStrip_nav.TitleAnamorphosis = true;
            this.contextMenuStrip_nav.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.contextMenuStrip_nav.TitleRadius = 4;
            this.contextMenuStrip_nav.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 添加节点ToolStripMenuItem
            // 
            this.添加节点ToolStripMenuItem.Name = "添加节点ToolStripMenuItem";
            this.添加节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加节点ToolStripMenuItem.Text = "添加节点";
            this.添加节点ToolStripMenuItem.Click += new System.EventHandler(this.添加节点ToolStripMenuItem_Click);
            // 
            // 修改节点ToolStripMenuItem
            // 
            this.修改节点ToolStripMenuItem.Name = "修改节点ToolStripMenuItem";
            this.修改节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改节点ToolStripMenuItem.Text = "修改节点";
            this.修改节点ToolStripMenuItem.Click += new System.EventHandler(this.修改节点ToolStripMenuItem_Click);
            // 
            // 剪切节点ToolStripMenuItem
            // 
            this.剪切节点ToolStripMenuItem.Name = "剪切节点ToolStripMenuItem";
            this.剪切节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.剪切节点ToolStripMenuItem.Text = "剪切节点";
            this.剪切节点ToolStripMenuItem.Click += new System.EventHandler(this.剪切节点ToolStripMenuItem_Click);
            // 
            // 粘贴节点ToolStripMenuItem
            // 
            this.粘贴节点ToolStripMenuItem.Name = "粘贴节点ToolStripMenuItem";
            this.粘贴节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴节点ToolStripMenuItem.Text = "粘贴节点";
            this.粘贴节点ToolStripMenuItem.Click += new System.EventHandler(this.粘贴节点ToolStripMenuItem_Click);
            // 
            // 上移节点ToolStripMenuItem
            // 
            this.上移节点ToolStripMenuItem.Name = "上移节点ToolStripMenuItem";
            this.上移节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.上移节点ToolStripMenuItem.Text = "上移节点";
            this.上移节点ToolStripMenuItem.Click += new System.EventHandler(this.上移节点ToolStripMenuItem_Click);
            // 
            // 下移节点ToolStripMenuItem
            // 
            this.下移节点ToolStripMenuItem.Name = "下移节点ToolStripMenuItem";
            this.下移节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.下移节点ToolStripMenuItem.Text = "下移节点";
            this.下移节点ToolStripMenuItem.Click += new System.EventHandler(this.下移节点ToolStripMenuItem_Click);
            // 
            // 删除节点ToolStripMenuItem
            // 
            this.删除节点ToolStripMenuItem.Name = "删除节点ToolStripMenuItem";
            this.删除节点ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除节点ToolStripMenuItem.Text = "删除节点";
            this.删除节点ToolStripMenuItem.Click += new System.EventHandler(this.删除节点ToolStripMenuItem_Click);
            // 
            // 添加文件ToolStripMenuItem
            // 
            this.添加文件ToolStripMenuItem.Name = "添加文件ToolStripMenuItem";
            this.添加文件ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加文件ToolStripMenuItem.Text = "添加文件";
            this.添加文件ToolStripMenuItem.Click += new System.EventHandler(this.添加文件ToolStripMenuItem_Click);
            // 
            // saveFileDialog_PBox
            // 
            this.saveFileDialog_PBox.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_PBox_FileOk);
            // 
            // contextMenuStrip_SysBtn1
            // 
            this.contextMenuStrip_SysBtn1.Arrow = System.Drawing.Color.Black;
            this.contextMenuStrip_SysBtn1.Back = System.Drawing.Color.White;
            this.contextMenuStrip_SysBtn1.BackRadius = 4;
            this.contextMenuStrip_SysBtn1.Base = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(200)))), ((int)(((byte)(254)))));
            this.contextMenuStrip_SysBtn1.DropDownImageSeparator = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.contextMenuStrip_SysBtn1.Fore = System.Drawing.Color.Black;
            this.contextMenuStrip_SysBtn1.HoverFore = System.Drawing.Color.White;
            this.contextMenuStrip_SysBtn1.ItemAnamorphosis = true;
            this.contextMenuStrip_SysBtn1.ItemBorder = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_SysBtn1.ItemBorderShow = true;
            this.contextMenuStrip_SysBtn1.ItemHover = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_SysBtn1.ItemPressed = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_SysBtn1.ItemRadius = 4;
            this.contextMenuStrip_SysBtn1.ItemRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStrip_SysBtn1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置密码ToolStripMenuItem,
            this.收缩空间ToolStripMenuItem,
            this.清理缓存ToolStripMenuItem,
            this.设置文件关联ToolStripMenuItem});
            this.contextMenuStrip_SysBtn1.ItemSplitter = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(148)))), ((int)(((byte)(212)))));
            this.contextMenuStrip_SysBtn1.Name = "contextMenuStrip_nav";
            this.contextMenuStrip_SysBtn1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.contextMenuStrip_SysBtn1.Size = new System.Drawing.Size(153, 114);
            this.contextMenuStrip_SysBtn1.SkinAllColor = true;
            this.contextMenuStrip_SysBtn1.TitleAnamorphosis = true;
            this.contextMenuStrip_SysBtn1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(228)))), ((int)(((byte)(236)))));
            this.contextMenuStrip_SysBtn1.TitleRadius = 4;
            this.contextMenuStrip_SysBtn1.TitleRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // 设置密码ToolStripMenuItem
            // 
            this.设置密码ToolStripMenuItem.Name = "设置密码ToolStripMenuItem";
            this.设置密码ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置密码ToolStripMenuItem.Text = "设置密码";
            this.设置密码ToolStripMenuItem.Click += new System.EventHandler(this.设置密码ToolStripMenuItem_Click);
            // 
            // 收缩空间ToolStripMenuItem
            // 
            this.收缩空间ToolStripMenuItem.Name = "收缩空间ToolStripMenuItem";
            this.收缩空间ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.收缩空间ToolStripMenuItem.Text = "收缩空间";
            this.收缩空间ToolStripMenuItem.Click += new System.EventHandler(this.收缩空间ToolStripMenuItem_Click);
            // 
            // 设置文件关联ToolStripMenuItem
            // 
            this.设置文件关联ToolStripMenuItem.Name = "设置文件关联ToolStripMenuItem";
            this.设置文件关联ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.设置文件关联ToolStripMenuItem.Text = "设置文件关联";
            this.设置文件关联ToolStripMenuItem.Click += new System.EventHandler(this.设置文件关联ToolStripMenuItem_Click);
            // 
            // 清理缓存ToolStripMenuItem
            // 
            this.清理缓存ToolStripMenuItem.Name = "清理缓存ToolStripMenuItem";
            this.清理缓存ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.清理缓存ToolStripMenuItem.Text = "清理缓存";
            this.清理缓存ToolStripMenuItem.Click += new System.EventHandler(this.清理缓存ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 480);
            this.CloseBoxSize = new System.Drawing.Size(27, 22);
            this.CloseDownBack = global::PrivateBox.Properties.Resources.CloseDownBack;
            this.CloseMouseBack = global::PrivateBox.Properties.Resources.CloseMouseBack;
            this.CloseNormlBack = global::PrivateBox.Properties.Resources.CloseNormlBack;
            this.Controls.Add(this.splitContainer3);
            this.DropBack = false;
            this.EffectCaption = CCWin.TitleType.Title;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaxDownBack = global::PrivateBox.Properties.Resources.MaxDownBack;
            this.MaxMouseBack = global::PrivateBox.Properties.Resources.MaxMouseBack;
            this.MaxNormlBack = global::PrivateBox.Properties.Resources.MaxNormlBack;
            this.MaxSize = new System.Drawing.Size(27, 22);
            this.MiniDownBack = global::PrivateBox.Properties.Resources.MiniDownBack;
            this.MiniMouseBack = global::PrivateBox.Properties.Resources.MiniMouseBack;
            this.MiniNormlBack = global::PrivateBox.Properties.Resources.MiniNormlBack;
            this.MiniSize = new System.Drawing.Size(27, 22);
            this.MobileApi = false;
            this.Name = "MainForm";
            this.Radius = 2;
            this.ShadowPalace = global::PrivateBox.Properties.Resources.ShadowPalace;
            this.ShadowWidth = 6;
            this.ShowBorder = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            cmSysButton1.Bounds = new System.Drawing.Rectangle(702, 0, 27, 22);
            cmSysButton1.BoxState = CCWin.ControlBoxState.Normal;
            cmSysButton1.Location = new System.Drawing.Point(702, 0);
            cmSysButton1.Name = null;
            cmSysButton1.OwnerForm = this;
            cmSysButton1.Size = new System.Drawing.Size(27, 22);
            cmSysButton1.SysButtonDown = global::PrivateBox.Properties.Resources.cmSysButton1_SysButtonDown;
            cmSysButton1.SysButtonMouse = global::PrivateBox.Properties.Resources.cmSysButton1_SysButtonMouse;
            cmSysButton1.SysButtonNorml = global::PrivateBox.Properties.Resources.cmSysButton1_SysButtonNorml;
            cmSysButton1.ToolTip = null;
            this.SysButtonItems.AddRange(new CCWin.CmSysButton[] {
            cmSysButton1});
            this.Text = "私密箱";
            this.SysBottomClick += new CCWin.CCSkinMain.SysBottomEventHandler(this.MainForm_SysBottomClick);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripGridView.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.skinSplitContainer_DataGridView.Panel1.ResumeLayout(false);
            this.skinSplitContainer_DataGridView.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer_DataGridView)).EndInit();
            this.skinSplitContainer_DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLoadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FileList)).EndInit();
            this.contextMenuStrip_nav.ResumeLayout(false);
            this.contextMenuStrip_SysBtn1.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private SkinContextMenuStrip contextMenuStripGridView;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private SkinSplitContainer splitContainer3;
        private SkinSplitContainer splitContainer2;
        private SkinSplitContainer splitContainer1;
        private SkinContextMenuStrip contextMenuStrip_nav;
        private System.Windows.Forms.ToolStripMenuItem 添加节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加文件ToolStripMenuItem;
        private SkinTabControl tabControl_Viewer;
        private SkinSplitContainer skinSplitContainer_DataGridView;
        private SkinDataGridView dataGridView_FileList;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn file_nodeid;
        private SkinButton btn_openPBox;
        private UserControls.PagerControl pagerControl1;
        private SkinTreeView treeView_nav;
        private SkinButton btn_newPBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_PBox;
        private SkinContextMenuStrip contextMenuStrip_SysBtn1;
        private System.Windows.Forms.ToolStripMenuItem 设置密码ToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgLoadding;
        private System.Windows.Forms.ToolStripMenuItem 收缩空间ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_File;
        private System.Windows.Forms.ToolStripMenuItem 剪切节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置文件关联ToolStripMenuItem;
        private SkinTextBox textBox_search;
        private System.Windows.Forms.ToolStripMenuItem 上移节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 下移节点ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清理缓存ToolStripMenuItem;
        private SkinCheckBox ckBox_showFname;
    }
}