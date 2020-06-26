using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CCWin.Win32;

namespace PrivateBox.Forms
{
    public partial class FrmPlayer : CCWin.CCSkinMain
    {
        ToolStripMenuItem LastItem;
        public FrmPlayer()
        {
            InitializeComponent();
        }


        private void chkPlay_CheckedChanged(object sender, EventArgs e)
        {
            PlayBtnEv();
            ToolTip.SetToolTip(chkPlay, chkPlay.Checked ? "播放" : "暂停");
            VideoMsg(chkPlay.Checked ? "暂停播放" : "正在播放");
        }

        private void btnVideoRight_Click(object sender, EventArgs e)
        {
            PlayGo();//快进 
        }

        private void chkVideoMusic_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVideoMusic.Checked)
            {
                axPlay.SetVolume(0);
            }
            else
            {
                axPlay.SetVolume(tbMusic.Value);
            }
        }

        private void btnOpenVideoFile_Click(object sender, EventArgs e)
        {
            openfile();
        }

        private void chkFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkFullScreen.Checked)
            {
                AllFull();
            }
            else
            {
                this.ExitAllFull();
            }
        }
        #region 播放器事件封装
        #region 枚举
        /// <summary>
        /// 播放状态
        /// </summary>
        public enum PlayState
        {
            PS_READY = 0,  // 准备就绪
            PS_OPENING = 1,  // 正在打开
            PS_PAUSING = 2,  // 正在暂停
            PS_PAUSED = 3,  // 暂停中
            PS_PLAYING = 4,  // 正在开始播放
            PS_PLAY = 5,  // 播放中
            PS_CLOSING = 6  // 正在开始关闭
        }
        #endregion

        /// <summary>
        /// 鼠标事件
        /// </summary>
        public enum WinMsg
        {
            WM_LBUTTONDOWN = 0x201, //Left mousebutton down
            WM_LBUTTONUP = 0x202,  //Left mousebutton up
            WM_LBUTTONDBLCLK = 0x203, //Left mousebutton doubleclick
            WM_RBUTTONDOWN = 0x204, //Right mousebutton down
            WM_RBUTTONUP = 0x205,   //Right mousebutton up
            WM_RBUTTONDBLCLK = 0x206, //Right mousebutton doubleclick
            WM_KEYDOWN = 0x100,  //Key down
            WM_KEYUP = 0x101   //Key up
        }
        #endregion
        /// <summary>
        /// 返回播放状态
        /// </summary>
        public int GetState()
        {
            return axPlay.GetState();
        }

        #region 播放视频消息提示
        public void VideoMsg(string msg)
        {
            this.Invoke(new MethodInvoker(delegate {
                lblMsg.Visible = true;
                lblMsg.Text = msg;
                //工具栏隐藏，启用渐变隐藏小提示计时器
                if (!pnlTool.Visible)
                {
                    timMsg.Stop();
                    timMsg.Start();
                }
            }));
        }
        #endregion
        /// <summary>
        /// 暂停与播放
        /// </summary>
        public void PlayBtnEv()
        {
            if (GetState() == Convert.ToInt32(PlayState.PS_PLAY))
            {
                axPlay.Pause();
                //true:播放图标 false:暂停图标
                chkPlay.Checked = true;
            }
            else if (GetState() == Convert.ToInt32(PlayState.PS_PAUSED))
            {
                axPlay.Play();
                //true:播放图标 false:暂停图标
                chkPlay.Checked = false;
            }
            else if (GetState() == Convert.ToInt32(PlayState.PS_READY))
            {
                ////true:播放图标 false:暂停图标
                //chkPlay.Checked = false;
            }
        }

        public bool IsMouseDown = false;
        private void tbValue_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
        }

        private void tbValue_MouseUp(object sender, MouseEventArgs e)
        {
            //进度条鼠标抬起
            IsMouseDown = false;
            //设置进度
            axPlay.SetPosition(tbValue.Value);
        }

        private void btnClosePlay_Click(object sender, EventArgs e)
        {
            ClosePlay();
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        public void ClosePlay()
        {
            axPlay.Close();
        }
        /// <summary>
        /// 设置播放器默认图片
        /// </summary>
        /// <param name="bt"></param>
        public void SetLogo(Bitmap bt)
        {
            Bitmap logo = new Bitmap(bt.Width, bt.Height);
            Graphics g = Graphics.FromImage(logo);
            g.Clear(Color.Black);
            g.DrawImage(bt, 0, 0, bt.Width, bt.Height);
            axPlay.SetCustomLogo(logo.GetHbitmap().ToInt32());
        }
        /// <summary>
        /// 往后
        /// </summary>
        private void PlayBack()
        {
            int index = CurrentPosition;
            int toindex = index - (CurrentLength / 100);
            //设置进度
            axPlay.SetPosition(toindex);
            tbValue.Value = CurrentPosition = axPlay.GetPosition();
        }
        /// <summary>
        /// 往前
        /// </summary>
        private void PlayGo()
        {
            int index = CurrentPosition;
            int toindex = index + (CurrentLength / 100);
            axPlay.SetPosition(toindex);
            tbValue.Value = CurrentPosition = axPlay.GetPosition();
        }
        private void btnVideoLeft_Click(object sender, EventArgs e)
        {
            PlayBack();//后退
        }
        //进度
        int CurrentPosition = 0;
        int CurrentLength = 0;
        private void axPlay_OnOpenSucceeded(object sender, EventArgs e)
        {
            tbValue.Value = 0;
            CurrentLength = axPlay.GetDuration();
            if (CurrentLength == 0)
            {
                return;
            }
            tbValue.Maximum = CurrentLength;
        }


        private void tbMusic_ValueChanged(object sender, EventArgs e)
        {
            axPlay.SetVolume(tbMusic.Value);
        }

        private void axPlay_OnBuffer(object sender, AxAPlayer3Lib._IPlayerEvents_OnBufferEvent e)
        {
            //缓冲进度 最多100
            int i = e.nPercent;
            if (i == -1)
            {
                VideoMsg(lblMsg.Tag.ToString());
            }
            else
            {
                if (i == 100)
                {
                    VideoMsg(lblMsg.Tag.ToString());
                }
                else
                {
                    VideoMsg(string.Format("缓冲中：{0}%", i));
                }
            }
        }

        private void axPlay_OnDownloadCodec(object sender, AxAPlayer3Lib._IPlayerEvents_OnDownloadCodecEvent e)
        {
            //解码器的名字
            string str = e.strCodecPath;
            MessageBox.Show("没有解码器：" + str);
        }

        /// <summary>
        /// 视频区域引发鼠标操作或者当 APlayer 视频区域拥有焦点时引发键盘操作时触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axPlay_OnMessage(object sender, AxAPlayer3Lib._IPlayerEvents_OnMessageEvent e)
        {
            int code = e.nMessage;
            if (code == Convert.ToInt32(WinMsg.WM_LBUTTONDBLCLK))
            {
                //全屏
                FullScreen();
            }
            else if (code == Convert.ToInt32(WinMsg.WM_RBUTTONUP))
            {
                if (this.WindowState == FormWindowState.Maximized && this.TopMost)
                {
                    //隐藏和显示控制栏
                    lblMsg.Visible = pnlTool.Visible = !pnlTool.Visible;
                }
                else
                {
                    axPlayContextMenu.Show(axPlay, axPlay.PointToClient(Cursor.Position));
                }
            }
            else if (code == Convert.ToInt32(WinMsg.WM_LBUTTONDOWN))
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    //释放鼠标焦点捕获
                    NativeMethods.ReleaseCapture();
                    //向当前窗体发送拖动消息
                    NativeMethods.SendMessage(this.Handle, 0x0112, 0xF011, 0);
                }
            }
        }

        /// <summary>
        /// 全屏
        /// </summary>
        private void FullScreen()
        {
            //如果是非全屏
            if (WindowState == FormWindowState.Normal)
            {
                //执行全屏
                AllFull();
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                //退出全屏
                ExitAllFull();
            }
        }
        private Color BackColor_BAK;
        private Color BorderColor_BAK;
        /// <summary>
        /// 执行全屏
        /// </summary>
        private void AllFull()
        {
            //如果是非全屏
            if (WindowState == FormWindowState.Normal)
            {
                //执行全屏
                TopMost = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.ControlBox = false;
                BackColor_BAK = this.BackColor;
                BorderColor_BAK = this.BorderColor;
                this.BackColor = Color.Black;
                this.BorderColor = Color.Transparent;
                this.ShowIcon = false;
                this.chkFullScreen.Checked = true;
                VideoMsg("右键隐藏工具栏");
            }
        }
        /// <summary>
        /// 退出全屏
        /// </summary>
        private void ExitAllFull()
        {
            if (WindowState == FormWindowState.Maximized)
            {
                //恢复非全屏
                TopMost = false;
                pnlTool.Visible = true;
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.ControlBox = true;
                this.BackColor = BackColor_BAK;
                this.BorderColor = BorderColor_BAK;
                this.ShowIcon = true;
                this.chkFullScreen.Checked = false;
                VideoMsg(lblMsg.Tag.ToString());
            }
        }

        internal void openFile(string path)
        {
            this.axPlay.Open(path);
        }

        /// <summary>
        /// 发生在用户进行一个 SetPosition 的异步调用完成后。通常并没有什么卵用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axPlay_OnSeekCompleted(object sender, AxAPlayer3Lib._IPlayerEvents_OnSeekCompletedEvent e)
        {
        }

        /// <summary>
        ///  播放状态发生改变后
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axPlay_OnStateChanged(object sender, AxAPlayer3Lib._IPlayerEvents_OnStateChangedEvent e)
        {
            // 新状态
            int i = e.nNewState;
            //之前的状态
            int j = e.nOldState;
            //播放就绪状态，说明播放完毕或者未播放
            if (i == Convert.ToInt32(PlayState.PS_READY))
            {
                tbValue.Value = 0;
                //true:播放图标 false:暂停图标
                chkPlay.Checked = true;
                //设置Msg提示
                VideoMsg(lblMsg.Tag.ToString());
                //更新进度值
                labTime.Text = labTime.Tag.ToString();
            }
        }

        /// <summary>
        /// 控件中的按的按键触发事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axPlay_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == (Keys.Enter))
            {
                //全屏
                AllFull();
            }
            else if (e.KeyData == (Keys.Escape))
            {
                //退出全屏
                ExitAllFull();
            }
            else if (e.KeyData == (Keys.Left))
            {
                PlayBack();//后退
            }
            else if (e.KeyData == (Keys.Right))
            {
                PlayGo();//快进
            }
            else if (e.KeyData == (Keys.Space))
            {
                //暂停播放
                PlayBtnEv();
            }
            else if (e.KeyData == (Keys.Up))
            {
                //音量++
                tbMusic.Value += 10;
                axPlay.SetVolume(tbMusic.Value);
            }
            else if (e.KeyData == (Keys.Down))
            {
                //音量--
                tbMusic.Value -= 10;
                axPlay.SetVolume(tbMusic.Value);
            }
        }

        private void timShow_Tick(object sender, EventArgs e)
        {
            if (GetState() == Convert.ToInt32(PlayState.PS_PLAY))//播放中
            {
                if (!IsMouseDown)//没有拖动
                {
                    CurrentLength = axPlay.GetDuration();
                    if (CurrentLength == 0)
                    {
                        return;
                    }
                    CurrentPosition = axPlay.GetPosition();
                    tbValue.Value = CurrentPosition;
                    //显示视频进度
                    ShowTime();
                }

                if (this.LastItem == this.播放时在最前ToolStripMenuItem &&!TopMost)
                {
                    TopMost = true;
                }
            }
            else if(TopMost)
            {
                TopMost = false;
            }
        }
        #region 显示视频进度值
        public void ShowTime()
        {
            string str1 = ConvertTime(axPlay.GetPosition() / 1000);
            string str2 = ConvertTime(axPlay.GetDuration() / 1000);
            if (str1.IndexOf(".") >= 0)
            {
                str1 = str1.Substring(0, str1.LastIndexOf("."));
            }
            if (str2.IndexOf(".") >= 0)
            {
                str2 = str2.Substring(0, str2.LastIndexOf("."));
            }
            labTime.Text = str1 + "/" + str2;
        }
        /// <summary>
        /// 时间转换，将秒转换为对应的   mm：ss
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public static string ConvertTime(int time)
        {
            string musicTime = "00:00";
            if (time > 0)
            {
                int minute = time / 60;
                int seconds = time % 60;
                musicTime = (minute < 10 ? "0" + minute.ToString() : minute.ToString()) + ":" + (seconds < 10 ? "0" + seconds.ToString() : seconds.ToString());
            }
            return musicTime;
        }
        #endregion

        private void timMsg_Tick(object sender, EventArgs e)
        {
            if (!pnlTool.Visible)
            {
                lblMsg.Visible = false;
                timMsg.Stop();
            }
        }
        /// <summary>
        /// 打开本地文件
        /// </summary>
        private void openfile()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "mp4|*.mp4|avi|*.avi|rm|*.rm|rmvb|*.rmvb|flv|*.flv|xr|*.xr|所有文件|*.*";
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    axPlay.Open(ofd.FileName);
                }
            }
        }

        private void 显示字幕ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).Text == "显示字幕")
            {
                (sender as ToolStripMenuItem).Text = "隐藏字幕";
                axPlay.SetConfig(504, "1");
            }
            else
            {
                (sender as ToolStripMenuItem).Text = "显示字幕";
                axPlay.SetConfig(504, "0");
            }
        }

        private void 总是在最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
            if (this.LastItem != null)
            {
                this.LastItem.Checked = false;
            }
            this.LastItem = this.总是在最前ToolStripMenuItem;
        }

        private void 播放时在最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.LastItem != null)
            {
                this.LastItem.Checked = false;
            }
            this.LastItem = this.播放时在最前ToolStripMenuItem;
            this.总是在最前ToolStripMenuItem.Checked = false;
           
        }

        private void 取消最前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = false;
            this.总是在最前ToolStripMenuItem.Checked = false;
            this.播放时在最前ToolStripMenuItem.Checked = false;
            this.LastItem = null;
        }
    }
}
