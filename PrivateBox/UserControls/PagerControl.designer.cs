using CCWin.SkinControl;

namespace PrivateBox.UserControls
{
    partial class PagerControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lnkFirst = new System.Windows.Forms.LinkLabel();
            this.lnkPrev = new System.Windows.Forms.LinkLabel();
            this.lnkNext = new System.Windows.Forms.LinkLabel();
            this.lnkLast = new System.Windows.Forms.LinkLabel();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.txtPageSize = new System.Windows.Forms.TextBox();
            this.btnGo = new CCWin.SkinControl.SkinButton();
            this.lblCurrentPage = new System.Windows.Forms.Label();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.lblMsg3 = new System.Windows.Forms.Label();
            this.lblMsg4 = new System.Windows.Forms.Label();
            this.lblSept = new System.Windows.Forms.Label();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkFirst
            // 
            this.lnkFirst.AutoSize = true;
            this.lnkFirst.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkFirst.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkFirst.LinkColor = System.Drawing.Color.Black;
            this.lnkFirst.Location = new System.Drawing.Point(359, 6);
            this.lnkFirst.Name = "lnkFirst";
            this.lnkFirst.Size = new System.Drawing.Size(32, 17);
            this.lnkFirst.TabIndex = 42;
            this.lnkFirst.TabStop = true;
            this.lnkFirst.Text = "首页";
            this.lnkFirst.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkFirst_LinkClicked);
            // 
            // lnkPrev
            // 
            this.lnkPrev.AutoSize = true;
            this.lnkPrev.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkPrev.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkPrev.LinkColor = System.Drawing.Color.Black;
            this.lnkPrev.Location = new System.Drawing.Point(397, 6);
            this.lnkPrev.Name = "lnkPrev";
            this.lnkPrev.Size = new System.Drawing.Size(44, 17);
            this.lnkPrev.TabIndex = 43;
            this.lnkPrev.TabStop = true;
            this.lnkPrev.Text = "上一页";
            this.lnkPrev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPrev_LinkClicked);
            // 
            // lnkNext
            // 
            this.lnkNext.AutoSize = true;
            this.lnkNext.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkNext.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkNext.LinkColor = System.Drawing.Color.Black;
            this.lnkNext.Location = new System.Drawing.Point(447, 6);
            this.lnkNext.Name = "lnkNext";
            this.lnkNext.Size = new System.Drawing.Size(44, 17);
            this.lnkNext.TabIndex = 44;
            this.lnkNext.TabStop = true;
            this.lnkNext.Text = "下一页";
            this.lnkNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNext_LinkClicked);
            // 
            // lnkLast
            // 
            this.lnkLast.AutoSize = true;
            this.lnkLast.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnkLast.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLast.LinkColor = System.Drawing.Color.Black;
            this.lnkLast.Location = new System.Drawing.Point(497, 6);
            this.lnkLast.Name = "lnkLast";
            this.lnkLast.Size = new System.Drawing.Size(32, 17);
            this.lnkLast.TabIndex = 45;
            this.lnkLast.TabStop = true;
            this.lnkLast.Text = "尾页";
            this.lnkLast.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLast_LinkClicked);
            // 
            // txtPageNum
            // 
            this.txtPageNum.Location = new System.Drawing.Point(535, 3);
            this.txtPageNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(33, 23);
            this.txtPageNum.TabIndex = 46;
            this.txtPageNum.TextChanged += new System.EventHandler(this.txtPageNum_TextChanged);
            this.txtPageNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNum_KeyPress);
            // 
            // txtPageSize
            // 
            this.txtPageSize.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtPageSize.Location = new System.Drawing.Point(286, 3);
            this.txtPageSize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPageSize.Name = "txtPageSize";
            this.txtPageSize.Size = new System.Drawing.Size(37, 23);
            this.txtPageSize.TabIndex = 46;
            this.txtPageSize.Text = "100";
            this.txtPageSize.TextChanged += new System.EventHandler(this.txtPageSize_TextChanged);
            this.txtPageSize.Leave += new System.EventHandler(this.txtPageSize_Leave);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGo.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnGo.DownBack = null;
            this.btnGo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGo.ForeColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(574, 3);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.MouseBack = null;
            this.btnGo.Name = "btnGo";
            this.btnGo.NormlBack = null;
            this.btnGo.Size = new System.Drawing.Size(52, 25);
            this.btnGo.TabIndex = 48;
            this.btnGo.Text = "跳转";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lblCurrentPage
            // 
            this.lblCurrentPage.AutoSize = true;
            this.lblCurrentPage.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCurrentPage.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentPage.Location = new System.Drawing.Point(7, 6);
            this.lblCurrentPage.Name = "lblCurrentPage";
            this.lblCurrentPage.Size = new System.Drawing.Size(15, 17);
            this.lblCurrentPage.TabIndex = 49;
            this.lblCurrentPage.Text = "1";
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg2.Location = new System.Drawing.Point(198, 6);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(44, 17);
            this.lblMsg2.TabIndex = 50;
            this.lblMsg2.Text = "条记录";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCount.Location = new System.Drawing.Point(126, 6);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(64, 17);
            this.lblTotalCount.TabIndex = 51;
            this.lblTotalCount.Text = "10000000";
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg1.Location = new System.Drawing.Point(100, 6);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(20, 17);
            this.lblMsg1.TabIndex = 52;
            this.lblMsg1.Text = "共";
            // 
            // lblMsg3
            // 
            this.lblMsg3.AutoSize = true;
            this.lblMsg3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg3.Location = new System.Drawing.Point(248, 6);
            this.lblMsg3.Name = "lblMsg3";
            this.lblMsg3.Size = new System.Drawing.Size(32, 17);
            this.lblMsg3.TabIndex = 53;
            this.lblMsg3.Text = "每页";
            // 
            // lblMsg4
            // 
            this.lblMsg4.AutoSize = true;
            this.lblMsg4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMsg4.Location = new System.Drawing.Point(329, 6);
            this.lblMsg4.Name = "lblMsg4";
            this.lblMsg4.Size = new System.Drawing.Size(20, 17);
            this.lblMsg4.TabIndex = 55;
            this.lblMsg4.Text = "条";
            // 
            // lblSept
            // 
            this.lblSept.AutoSize = true;
            this.lblSept.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSept.Location = new System.Drawing.Point(28, 6);
            this.lblSept.Name = "lblSept";
            this.lblSept.Size = new System.Drawing.Size(13, 17);
            this.lblSept.TabIndex = 56;
            this.lblSept.Text = "/";
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPageCount.ForeColor = System.Drawing.Color.Red;
            this.lblPageCount.Location = new System.Drawing.Point(54, 6);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(15, 17);
            this.lblPageCount.TabIndex = 57;
            this.lblPageCount.Text = "1";
            // 
            // PagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lblPageCount);
            this.Controls.Add(this.lblSept);
            this.Controls.Add(this.lblMsg4);
            this.Controls.Add(this.lblMsg3);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.lblCurrentPage);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtPageSize);
            this.Controls.Add(this.txtPageNum);
            this.Controls.Add(this.lnkLast);
            this.Controls.Add(this.lnkNext);
            this.Controls.Add(this.lnkPrev);
            this.Controls.Add(this.lnkFirst);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(78)))), ((int)(((byte)(151)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PagerControl";
            this.Size = new System.Drawing.Size(640, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkFirst;
        private System.Windows.Forms.LinkLabel lnkPrev;
        private System.Windows.Forms.LinkLabel lnkNext;
        private System.Windows.Forms.LinkLabel lnkLast;
        private System.Windows.Forms.TextBox txtPageNum;
        private System.Windows.Forms.TextBox txtPageSize;
        private SkinButton btnGo;
        private System.Windows.Forms.Label lblCurrentPage;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.Label lblMsg3;
        private System.Windows.Forms.Label lblMsg4;
        private System.Windows.Forms.Label lblSept;
        private System.Windows.Forms.Label lblPageCount;
    }
}
