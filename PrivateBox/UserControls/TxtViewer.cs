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
    public partial class TxtViewer : UserControl
    {
        public TxtViewer()
        {
            InitializeComponent();
        }
        public void showTxt(String txt) {
            this.rtfRichTextBox1.Text = txt;
        }
    }
}
