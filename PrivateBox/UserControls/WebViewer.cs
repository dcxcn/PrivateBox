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
    public partial class WebViewer : UserControl
    {
        public WebViewer()
        {
            InitializeComponent();
        }
        public void openFile(String path)
        {
            this.webBrowser1.Navigate(path);
        }
    }
}
