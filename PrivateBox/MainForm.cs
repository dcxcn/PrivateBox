using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Data.SQLite;
using System.Reflection;
using PrivateBox.Model;
using PrivateBox.UserControls;
using CCWin.SkinControl;
using PrivateBox.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using PrivateBox.Utils;
using CCWin;

namespace PrivateBox
{
    public partial class MainForm : CCWin.CCSkinMain
    {
        [DllImport("shell32.dll")]
        public static extern void SHChangeNotify(uint wEventId, uint uFlags, IntPtr dwItem1, IntPtr dwItem2);

        private dBHelper helperPBox = null;
        private dBHelper helperPData = null;
        private TreeNode treeNode_Cut = null;
        public MainForm()
        {
            InitializeComponent();            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registDll();
            upZipCodecs();
            //获取进程命令行参数
            string command = Environment.CommandLine;             
            string[] para = command.Split('\"');
            if (para.Length > 2 && "".Equals(para[2].Trim())==false)
            {
                //获取打开的文件的路径
                string pathC = para[2];
                DBSource.ConnectionStringPBox = @"Data Source=" + pathC;
                DBSource.ConnectionStringPData = @"Data Source=" + pathC.Replace("pbox","pdata");
            }
            else
            {
                initDefDbPath();
            }                
            loadData();           
        }
        private void upZipCodecs()
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\codecs")==false)
            {
                string codecsZip = AppDomain.CurrentDomain.BaseDirectory + "\\codecs.zip";
                SevenZip.SevenZipExtractor sze = new SevenZip.SevenZipExtractor(codecsZip);
                sze.ExtractArchive(AppDomain.CurrentDomain.BaseDirectory + "\\codecs");
            }
        }
        private void initDefDbPath()
        {
            string database_pbox =AppDomain.CurrentDomain.BaseDirectory + "\\Database\\FileDB.pbox";
            string database_pdata = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\FileDB.pdata";
            DBSource.ConnectionStringPBox = @"Data Source=" + Path.GetFullPath(database_pbox);
            DBSource.ConnectionStringPData = @"Data Source=" + Path.GetFullPath(database_pdata);
        }
        private void registDll() {
            Assembly asm = Assembly.GetEntryAssembly();
            String projectName = Assembly.GetExecutingAssembly().GetName().Name.ToString();
            using (Stream stream = asm.GetManifestResourceStream(projectName+ ".Resources.dsoframer.ocx"))
            {
                int len = (int)stream.Length;
                byte[] byts = new byte[len];

                stream.Read(byts, 0, len);
                stream.Close();
                Process[] p_word = Process.GetProcessesByName("WINWORD");
                if (p_word.Length > 0) {
                    p_word[0].Kill();
                }
                Process[] p_excel = Process.GetProcessesByName("EXCEL");
                if (p_excel.Length > 0)
                {
                    p_excel[0].Kill();
                }
                try
                {
                    using (FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "//dsoframer.ocx", FileMode.Create))
                    {
                        fs.Write(byts, 0, len);
                    }
                }
                catch (Exception exp) { }
                
            }
            Register r = new Register();
            r.RegisterDll("dsoframer.ocx");
        }

        private void dataGridViewImageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            // Have aquired a valided row
            Int32 fid = Convert.ToInt32(dataGridView_FileList.CurrentRow.Cells["file_id"].Value);
            openFileViewer(fid);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 fid = Convert.ToInt32(dataGridView_FileList.CurrentRow.Cells["file_id"].Value);
            System.Threading.ThreadPool.QueueUserWorkItem((s) => DeleteFile(fid));
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Int32 fid = Convert.ToInt32(dataGridView_FileList.CurrentRow.Cells["file_id"].Value);
            string connectionStringPBox = DBSource.ConnectionStringPBox;
            string connectionStringPData = DBSource.ConnectionStringPData;
            string commandText = @"SELECT file_id,file_name,file_type,file_size,file_nodeid FROM FileMemo where file_id = " + fid;
            helperPBox = new dBHelper(connectionStringPBox);
            FileStream fs;
            if (helperPBox.Load(commandText, "") == true)
            {
                if (fid > 0 && helperPBox.DataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dataRow = helperPBox.DataSet.Tables[0].Select("file_id=" + fid)[0];
                    string filename = dataRow["file_name"].ToString();
                    string filetype = dataRow["file_type"].ToString();
                    List<Byte[]> l_fileData = new FileDBHelper().getFileData(fid);
                    
                    this.saveFileDialog_File.Title = "另存"+ filename;
                    this.saveFileDialog_File.Filter = filetype + "|" + filetype;
                    this.saveFileDialog_File.DefaultExt = filetype;
                    this.saveFileDialog_File.FileName = filename;
                    if (this.saveFileDialog_File.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(saveFileDialog_File.FileName);
                        fs = fi.OpenWrite();
                        for (int i = 0; i < l_fileData.Count; i++) {                           
                            fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                        }
                        fs.Close();
                    }
                }
            }
       
        }

        private void DeleteFile(Int32 i)
        {
            FileDBHelper fileDBHelper = new FileDBHelper();
            fileDBHelper.deleteFile(i);
            if (fileDBHelper.GetSucces()) refreshDataGridView();
        }

        private void openFileViewer(Int32 fileID)
        {

            string connectionStringPBox = DBSource.ConnectionStringPBox;
            string connectionStringPData = DBSource.ConnectionStringPData;
            string commandText = @"SELECT file_id,file_name,file_type,file_size,file_nodeid FROM FileMemo where file_id = " + fileID;
            helperPBox = new dBHelper(connectionStringPBox);
            if (helperPBox.Load(commandText, "") == true)
            {
                if (fileID > 0 && helperPBox.DataSet.Tables[0].Rows.Count > 0)
                {
                    DataRow dataRow = helperPBox.DataSet.Tables[0].Select("file_id=" + fileID)[0];
                    string filename = dataRow["file_name"].ToString();
                    string filetype = dataRow["file_type"].ToString();
                    List<Byte[]> l_fileData = new FileDBHelper().getFileData(fileID);
                    if (l_fileData.Count==0) {
                        MessageBoxEx.Show("找不到对应数据文件！");
                        return;
                    }
                    SkinTabPage tp = new SkinTabPage();
                    tp.Text = filename;
                    switch (filetype)
                    {
                        case ".jpg":
                        case ".png":
                        case ".bmp":
                        case ".gif":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();
                                    try
                                    {
                                        Bitmap bmap = new Bitmap(Application.StartupPath + "\\temp\\" + filename + filetype);
                                        PicViewer uc_picviewer = new PicViewer();
                                        uc_picviewer.showPic(filename, bmap);
                                        uc_picviewer.Dock = DockStyle.Fill;
                                        tp.Controls.Add(uc_picviewer);
                                        tabControl_Viewer.TabPages.Add(tp);
                                    }
                                    catch (Exception exp) { }

                                }
                                break;
                            }
                        case ".doc":
                        case ".docx":
                        case ".xls":
                        case ".xlsx":
                        case ".ppt":
                        case ".pptx":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();
                                    DocViewer uc_docviewer = new DocViewer();
                                    tp.Tag = uc_docviewer;
                                    uc_docviewer.Dock = DockStyle.Fill;
                                    tp.Controls.Add(uc_docviewer);
                                    tabControl_Viewer.TabPages.Add(tp);
                                    uc_docviewer.openFile(Application.StartupPath + "\\temp\\" + filename + filetype);
                                }
                                break;
                            }
                        case ".txt":
                        case ".sql":
                        case ".log":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();
                                    StreamReader sr = new StreamReader(Application.StartupPath + "\\temp\\" + filename + filetype, Encoding.Default);         
                                    TxtViewer txtViewer = new TxtViewer();
                                    txtViewer.Dock = DockStyle.Fill;
                                    tp.Controls.Add(txtViewer);
                                    tabControl_Viewer.TabPages.Add(tp);
                                    txtViewer.showTxt(sr.ReadToEnd());
                                    sr.Close();
                                }                             
                                break;
                            }
                        case ".htm":
                        case ".html":
                        case ".mht":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();
                                    WebViewer webViewer = new WebViewer();
                                    webViewer.Dock = DockStyle.Fill;
                                    tp.Controls.Add(webViewer);
                                    tabControl_Viewer.TabPages.Add(tp);
                                    webViewer.openFile(Application.StartupPath + "\\temp\\" + filename + filetype);
                                }
                                break;
                            }
                        case ".pdf":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();
                                    PDFViewer pdfViewer = new PDFViewer();
                                    pdfViewer.Dock = DockStyle.Fill;
                                    tp.Controls.Add(pdfViewer);
                                    tabControl_Viewer.TabPages.Add(tp);
                                    pdfViewer.openFile(Application.StartupPath + "\\temp\\" + filename + filetype);
                                }
                                break;
                            }
                        case ".mp4":
                        case ".avi":
                        case ".rm":
                        case ".rmvb":
                        case ".flv":
                        case ".xr":
                        case ".wmv":
                            {
                                if (Directory.Exists(Application.StartupPath + "\\temp") == false)
                                {
                                    Directory.CreateDirectory(Application.StartupPath + "\\temp");
                                }
                                FileStream fs;
                                FileInfo fi = new FileInfo(Application.StartupPath + "\\temp\\" + filename + filetype);
                                if (!fi.Exists || !IsFileInUse(fi.FullName))
                                {
                                    fs = fi.OpenWrite();
                                    for (int i = 0; i < l_fileData.Count; i++)
                                    {
                                        fs.Write(l_fileData[i], 0, l_fileData[i].Length);
                                    }
                                    fs.Close();                                   
                                }
                                FrmPlayer aplayer = new FrmPlayer();
                                aplayer.Text = filename;
                                aplayer.Show();
                                aplayer.openFile(Application.StartupPath + "\\temp\\" + filename + filetype);
                                break;
                            }
                            
                    }
                    tabControl_Viewer.SelectedTab = tp;

                }
            }
        }




        private void treeView_nav_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (e.Node == null) return;
                    treeView_nav.SelectedNode = e.Node;
                    if (int.Parse("" + treeView_nav.SelectedNode.Tag) == 0)
                    {
                        修改节点ToolStripMenuItem.Visible = false;
                        剪切节点ToolStripMenuItem.Visible = false;
                        粘贴节点ToolStripMenuItem.Visible = false;
                        上移节点ToolStripMenuItem.Visible = false;
                        下移节点ToolStripMenuItem.Visible = false;
                        删除节点ToolStripMenuItem.Visible = false;
                        添加文件ToolStripMenuItem.Visible = false;
                    }
                    else
                    {
                        修改节点ToolStripMenuItem.Visible = true;
                        剪切节点ToolStripMenuItem.Visible = true;
                        if (this.treeNode_Cut != null)
                        {
                            粘贴节点ToolStripMenuItem.Visible = true;
                        }
                        else
                        {
                            粘贴节点ToolStripMenuItem.Visible = false;
                        }
                        上移节点ToolStripMenuItem.Visible = true;
                        下移节点ToolStripMenuItem.Visible = true;
                        删除节点ToolStripMenuItem.Visible = true;
                        添加文件ToolStripMenuItem.Visible = true;
                    }

                    contextMenuStrip_nav.Show(treeView_nav, e.X, e.Y);
                }
                else
                {
                    if (e.Node == null) return;
                    System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
                }
            }
            else
            {
                loadData();
            }
        }

        private void 添加节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                FrmNodeEdit frmNodeEdit = new FrmNodeEdit();
                frmNodeEdit.EditMode = FrmNodeEdit.EditMode_ADD;
                frmNodeEdit.ParentID = int.Parse("" + this.treeView_nav.SelectedNode.Tag);
                if (frmNodeEdit.ShowDialog() == DialogResult.OK)
                {
                    refreshTreeView();
                    this.treeView_nav.Refresh();
                }
            }
            else
            {
                loadData();
            }
        }

        private void 修改节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                FrmNodeEdit frmNodeEdit = new FrmNodeEdit();
                frmNodeEdit.EditMode = FrmNodeEdit.EditMode_UPD;
                frmNodeEdit.SelfID = int.Parse("" + this.treeView_nav.SelectedNode.Tag);
                frmNodeEdit.NodeName = treeView_nav.SelectedNode.Text;
                if (frmNodeEdit.ShowDialog() == DialogResult.OK)
                {
                    refreshTreeView();
                    this.treeView_nav.Refresh();
                }
            }
            else
            {
                loadData();
            }
        }

        private void 剪切节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeNode_Cut = treeView_nav.SelectedNode;
            treeNode_Cut.Remove();
        }

        private void 粘贴节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode pNode = treeView_nav.SelectedNode;
            FileDBHelper fdbHelper = new FileDBHelper();
            fdbHelper.saveFileNode(treeNode_Cut.Text, int.Parse("" + treeNode_Cut.Tag), int.Parse("" + pNode.Tag));
            pNode.Nodes.Add(treeNode_Cut);
            pNode.ExpandAll();
            treeNode_Cut = null;
        }

        private void 上移节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode curNode = treeView_nav.SelectedNode;
            TreeNode newNode = (TreeNode)curNode.Clone();
            TreeNode pNode = curNode.Parent;
            if (pNode.Nodes.Count == 1)
            {
                MessageBoxEx.Show("只有一个节点，无须上下移动！  ", "下移节点");
            }
            else
            {
                TreeNode prevNode = curNode.PrevNode;
                FileDBHelper fdbHelper = new FileDBHelper();
                fdbHelper.changeDisporder(int.Parse("" + curNode.Tag), int.Parse("" + prevNode.Tag));
                pNode.Nodes.Insert(prevNode.Index, newNode);
                pNode.Nodes.Remove(curNode);
                treeView_nav.SelectedNode = newNode;
            }
        }

        private void 下移节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode curNode = treeView_nav.SelectedNode;
            TreeNode newNode = (TreeNode)curNode.Clone();
            TreeNode pNode = curNode.Parent;
            if (pNode.Nodes.Count == 1)
            {
                MessageBoxEx.Show("只有一个节点，无须上下移动！  ", "下移节点");
            }
            else
            {
                TreeNode nextNode = curNode.NextNode;
                FileDBHelper fdbHelper = new FileDBHelper();
                fdbHelper.changeDisporder(int.Parse("" + curNode.Tag), int.Parse("" + nextNode.Tag));
                if (nextNode.NextNode != null)
                {
                    pNode.Nodes.Insert(nextNode.NextNode.Index, newNode);
                }
                else
                {
                    pNode.Nodes.Add(newNode);
                }                
                pNode.Nodes.Remove(curNode);
                treeView_nav.SelectedNode = newNode;
            }
        }

        private void 删除节点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                DialogResult dr = MessageBoxEx.Show("删除此节点，会删除这节点下所有内容，确认吗？   ", "删除节点", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    int nodeID = int.Parse("" + this.treeView_nav.SelectedNode.Tag);
                    System.Threading.ThreadPool.QueueUserWorkItem((s) => deleteFileNode(nodeID));
                }
            }
            else
            {
                loadData();
            }
        }
        private void refreshTreeView() {
            TreeNodeCollection nodes = this.treeView_nav.Nodes;
            nodes[0].Nodes.Clear();            
            FileDBHelper imgHelper = new FileDBHelper();
            string connectionString = DBSource.ConnectionStringPBox;
            string commandText = @"SELECT * FROM FileNode ORDER BY disporder";
            helperPBox = new dBHelper(connectionString);
            if (helperPBox.Load(commandText, "") == true)
            {
                DataTable dataSource = helperPBox.DataSet.Tables[0];
                CreateTreeViewRecursive(nodes[0].Nodes, dataSource, 0);
            }
            this.treeView_nav.ExpandAll();
        }

        private void CreateTreeViewRecursive(TreeNodeCollection nodes, DataTable dataSource, int parentid)
        {
            string filter;
            filter = string.Format("parent_id='{0}'", parentid); //从0开始，可以自设 
            DataRow[] drarr = dataSource.Select(filter);
            TreeNode node;
            foreach (DataRow dr in drarr)
            {
                node = new TreeNode();

                node.Text = (string)dr["node_name"];
                node.Tag = dr["node_id"];
                nodes.Add(node);

                CreateTreeViewRecursive(node.Nodes, dataSource, int.Parse(""+node.Tag));
            }
        }

        private void deleteFileNode(int nodeID)
        {
            this.Invoke(new MethodInvoker(delegate {               
                imgLoadding.Visible = true;
            }));
            FileDBHelper fdbHelper = new FileDBHelper();
            fdbHelper.deleteFileNode(nodeID);
            if (fdbHelper.GetSucces())
            {
                loadData();
            }
            this.Invoke(new MethodInvoker(delegate {
                imgLoadding.Visible = false;
            }));
            
        }
        public FileInfo[] LoadFile()
        {            
            FileInfo[] fileInfos = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.InitialDirectory = @"C:\\";
            dlg.Title = "请选择文件 添加到【"+ this.treeView_nav.SelectedNode.Text+"】节点";
            dlg.Filter = "图片 (*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.nef)|*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.nef";
            dlg.Filter += "|文档 (*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx)|*.doc;*.docx;*.xls;*.xlsx;*.ppt;*.pptx";
            dlg.Filter += "|PDF文档 (*.pdf)|*.pdf";
            dlg.Filter += "|网页文档 (*.html;*.htm;*.mht)|*.html;*.htm;*.mht";
            dlg.Filter += "|音频 (*.mp3)|*.mp3";
            dlg.Filter += "|视频 (*.mp4,*.avi,*.rm,*.rmvb,*.flv,*.xr,*.wmv)|*.mp4,*.avi,*.rm,*.rmvb,*.flv,*.xr,*.wmv";
            dlg.Filter += "|所有文件 (*.*)|*.*";
            dlg.ShowDialog();
            string[] fileLocations = dlg.FileNames;
            if (fileLocations == null || fileLocations.Length == 0)
                return fileInfos;
            fileInfos = new FileInfo[fileLocations.Length];
            for (int i = 0; i < fileLocations.Length; i++)
            {
                fileInfos[i] = new FileInfo(fileLocations[i]);
            }
            return fileInfos;
        }
        private void 添加文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //先判断数据文件是否存在
            
            if (new FileDBHelper().hasPData())
            {
                if (DBSource.ISAdmin)
                {
                    int nodeID = int.Parse("" + this.treeView_nav.SelectedNode.Tag);
                    FileInfo[] fileInfos = LoadFile();
                    System.Threading.ThreadPool.QueueUserWorkItem((s) => insertFiles(fileInfos, nodeID));
                }
                else
                {
                    loadData();
                }
            }
            else {
                MessageBoxEx.Show("找不到对应的数据文件(*.pdata),无法添加文件！");
            }

        }
        private void insertFiles(FileInfo[] fileInfos, int nodeID)
        {
            FileDBHelper imgHelper = new FileDBHelper();
            this.Invoke(new MethodInvoker(delegate
            {
                imgLoadding.Visible = true;
            }));
            imgHelper.InsertFiles(fileInfos, nodeID);
            if (imgHelper.GetSucces())
            {
                refreshDataGridView();
            }
            this.Invoke(new MethodInvoker(delegate
            {
                imgLoadding.Visible = false;
            }));
        }
        private void pagerControl1_OnPageChanged(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
            }
            else
            {
                loadData();
            }
        }
        private void refreshDataGridView()
        {
            try
            {
                int nodeID = -1;
                this.Invoke(new MethodInvoker(delegate {
                    //loadding加载
                    imgLoadding.Visible = true;
                    if (treeView_nav.SelectedNode != null && int.Parse(treeView_nav.SelectedNode.Tag.ToString()) != 0)
                    {
                        nodeID = int.Parse("" + treeView_nav.SelectedNode.Tag);
                    }

                }));
                string connectionString = DBSource.ConnectionStringPBox;
                string whereSql = ("".Equals(this.textBox_search.Text.Trim())) ? "" : "and file_name like '%" + this.textBox_search.Text.Trim() + "%'";
                string commandText = string.Format("select file_id,file_name,file_type,file_size,file_nodeid from FileMemo where 1=1 " + whereSql + " order by disporder limit {0},{1}", (pagerControl1.PageIndex - 1) * pagerControl1.PageSize, pagerControl1.PageSize);
                string commandText_count = "select count(*) totalCount from FileMemo where 1=1 " + whereSql;
                if (nodeID != -1)
                {
                    commandText = string.Format("SELECT file_id,file_name,file_type,file_size,file_nodeid FROM FileMemo where file_nodeid='" + nodeID + "' " + whereSql + " order by disporder limit {0},{1}", (pagerControl1.PageIndex - 1) * pagerControl1.PageSize, pagerControl1.PageSize);
                    commandText_count = "select count(*) totalCount from FileMemo where file_nodeid='" + nodeID + "' " + whereSql;
                }
                helperPBox = new dBHelper(connectionString);
                if (helperPBox.Load(commandText_count, "") == true)
                {
                    DataTable dt_count = helperPBox.DataSet.Tables[0];
                    this.Invoke(new MethodInvoker(delegate {
                        pagerControl1.DrawControl(int.Parse(dt_count.Rows[0]["totalCount"].ToString()));
                    }));
                }
                if (helperPBox.Load(commandText, "") == true)
                {
                    this.Invoke(new MethodInvoker(delegate {
                        dataGridView_FileList.DataSource = helperPBox.DataSet.Tables[0];
                    }));
                }
                this.Invoke(new MethodInvoker(delegate {
                    imgLoadding.Visible = false;
                }));
            } catch (Exception exp) { }

        }

        private void tabControl_Viewer_TabePageClosing(object sender, TabPageEventArgs e)
        {
            SkinTabControl tb_doc = (SkinTabControl)sender;
            if (tb_doc.SelectedTab.Tag is DocViewer)
            {
                DocViewer uc_docviewer = (DocViewer)tb_doc.SelectedTab.Tag;
                uc_docviewer.doForDispose();
            }
        }

        private void tabControl_Viewer_DoubleClick(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1Collapsed = !this.splitContainer1.Panel1Collapsed;
        }

        private void btn_openPBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.InitialDirectory = @"C:\\";
            dlg.Title = "选择文件";
            dlg.Filter = "私有箱子 (*.pbox)|*.pbox";
            dlg.Filter += "|所有文件 (*.*)|*.*";
            dlg.ShowDialog();
            if ("".Equals(dlg.FileName) == false)
            {
                DBSource.ISAdmin = false;
                DBSource.AdminName = "匿名用户";
                DBSource.ConnectionStringPBox = @"Data Source=" + dlg.FileName;
                DBSource.ConnectionStringPData = @"Data Source=" + dlg.FileName.Replace("pbox","pdata");
                loadData();
            }
        }
        private void loadData()
        {            
            if (DBSource.ISAdmin)
            {
                this.Invoke(new MethodInvoker(delegate {
                    refreshTreeView();
                }));               
                System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
            }
            else
            {
                //查询是否有密码设置，如果有弹出用户密码输入框，没有直接刷新显示
                String commandText_count = string.Format("SELECT count(*) count FROM FileAdmin");
                helperPBox = new dBHelper(DBSource.ConnectionStringPBox);
                if (helperPBox.Load(commandText_count, "") == true)
                {
                    DataTable dt_count = helperPBox.DataSet.Tables[0];
                    int count = int.Parse(dt_count.Rows[0]["count"].ToString());
                    if (count > 0)
                    {
                        //弹出用户密码输入框
                        FrmLoginAdmin frmInputPwd = new FrmLoginAdmin();
                        if (frmInputPwd.ShowDialog() == DialogResult.OK)
                        {                            
                            if (frmInputPwd.ISAdmin)
                            {
                                this.Invoke(new MethodInvoker(delegate {
                                    refreshTreeView();
                                }));
                                System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
                            }
                            else
                            {
                                initDefDbPath();
                                MessageBoxEx.Show("非正确用户无法打开此箱子！   ","解锁箱子");
                            }

                        }
                        else
                        {
                            MessageBoxEx.Show("非正确用户无法打开此箱子！   ", "解锁箱子");
                        }
                    }
                    else
                    {
                        DBSource.ISAdmin = true;
                        DBSource.AdminName = "匿名用户";
                        this.Invoke(new MethodInvoker(delegate {
                            refreshTreeView();
                        }));
                        System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
                    }
                }
            }
            this.Text = "【私密箱：" + DBSource.AdminName + "】" + DBSource.ConnectionStringPBox.Replace("Data Source=","");

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            String tempPath = Application.StartupPath + "\\temp";
            if (Directory.Exists(tempPath))
            {
                Directory.Delete(tempPath, true);
            }            
        }


        private void MainForm_SysBottomClick(object sender, SysButtonEventArgs e)
        {
            this.contextMenuStrip_SysBtn1.Show(e.SysButton.OwnerForm, e.SysButton.Location.X, e.SysButton.Location.Y+20);
        }


        private void tabControl_Viewer_TabePageClosed(object sender, TabPageEventArgs e)
        {
            this.splitContainer1.Panel1Collapsed = false;
        }

        private void btn_newPBox_Click(object sender, EventArgs e)
        {
            this.saveFileDialog_PBox.Title = "新增私密箱";
            this.saveFileDialog_PBox.AddExtension = true;
            this.saveFileDialog_PBox.DefaultExt = ".pbox";
            this.saveFileDialog_PBox.Filter = "私密箱|.pbox";
            if (this.saveFileDialog_PBox.ShowDialog() == DialogResult.OK)
            {
                String filename = this.saveFileDialog_PBox.FileName;
                DBSource.ISAdmin = false;
                DBSource.AdminName = "匿名用户";
                DBSource.ConnectionStringPBox = @"Data Source=" + filename;
                DBSource.ConnectionStringPData = @"Data Source=" + filename.Replace("pbox","pdata");
                loadData();
            }
        }

        private void saveFileDialog_PBox_FileOk(object sender, CancelEventArgs e)
        {
            string seedfile = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\Seed.pbox";
            string seeddata = AppDomain.CurrentDomain.BaseDirectory + "\\Database\\Seed.pdata";
            SaveFileDialog sfd = (SaveFileDialog)sender;
            File.Copy(seedfile, sfd.FileName);
            File.Copy(seeddata, sfd.FileName.Replace("pbox","pdata"));
        }

        private void 设置密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                FrmSaveAdmin frmSaveAdmin = new FrmSaveAdmin();
                if (frmSaveAdmin.ShowDialog() == DialogResult.OK)
                {
                    if (frmSaveAdmin.ISSuccess)
                    {
                        MessageBoxEx.Show("设置成功！   ","设置密码");
                    }
                }
            }
        }

        private bool IsFileInUse(string fileName)
        {
            bool inUse = true;

            FileStream fs = null;
            try
            {

                fs = new FileStream(fileName, FileMode.Open, FileAccess.Read,

                FileShare.None);

                inUse = false;
            }
            catch
            {

            }
            finally
            {
                if (fs != null)

                    fs.Close();
            }
            return inUse;//true表示正在使用,false没有使用
        }

        private void 收缩空间ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Threading.ThreadPool.QueueUserWorkItem((s) => Dbgc());
        }
        private void Dbgc()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                imgLoadding.Visible = true;
            }));
            helperPBox = new dBHelper(DBSource.ConnectionStringPBox);
            helperPData = new dBHelper(DBSource.ConnectionStringPData);
            helperPBox.Dbgc();
            helperPData.Dbgc();
            this.Invoke(new MethodInvoker(delegate
            {
                imgLoadding.Visible = false;
            }));
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Int32 fid = Convert.ToInt32(dataGridView_FileList.CurrentRow.Cells["file_id"].Value);
            String fname = ""+dataGridView_FileList.CurrentRow.Cells["file_name"].Value;
            FrmFileEdit frmFileEdit = new FrmFileEdit();
            frmFileEdit.FileName = fname;
            frmFileEdit.FileID = fid;
            if (frmFileEdit.ShowDialog() == DialogResult.OK)
            {
                refreshDataGridView();
            }
        }

        private void 设置文件关联ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileTypeRegInfo pbox = new FileTypeRegInfo();
            pbox.ExtendName = ".pbox";
            pbox.Description = "私密箱";
            pbox.IcoPath = AppDomain.CurrentDomain.BaseDirectory + "PrivateBox.ico";
            pbox.ExePath = AppDomain.CurrentDomain.BaseDirectory + "PrivateBox.exe";
            FileTypeRegister.RegisterFileType(pbox);
            SHChangeNotify(0x8000000, 0, IntPtr.Zero, IntPtr.Zero);
            MessageBoxEx.Show("设置完毕！   ","设置文件关联");
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            if (DBSource.ISAdmin)
            {
                System.Threading.ThreadPool.QueueUserWorkItem((s) => refreshDataGridView());
            }
        }

        private void 清理缓存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String tempPath = Application.StartupPath + "\\temp";
            if (Directory.Exists(tempPath))
            {
                Directory.Delete(tempPath, true);
                MessageBoxEx.Show("清理完毕！   ", "清理缓存");
            }
            else
            {
                MessageBoxEx.Show("不需要清理了！   ", "清理缓存");
            }
        }

        private void dataGridView_FileList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // 把第1列显示*号，*号的个数和实际数据的长度相同
            if (e.ColumnIndex == 1)
            {
                if (e.Value != null && e.Value.ToString().Length > 0 && !ckBox_showFname.Checked)
                {
                        e.Value = new string('*', e.Value.ToString().Length);
                }
            }
        }
    }
}
