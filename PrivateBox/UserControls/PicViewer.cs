using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrivateBox.UserControls
{
    public partial class PicViewer : UserControl
    {
        public PicViewer()
        {
            InitializeComponent();
        }
        public void showPic(String name, Bitmap bmap)
        {
            this.kpImageViewer1.Image = bmap;
        }
    }
   
}
