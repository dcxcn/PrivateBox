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
    public partial class DocViewer : UserControl
    {
        public DocViewer()
        {
            InitializeComponent();
            this.axFramerControl1.Titlebar = false;
            this.axFramerControl1.Menubar = false;
        }
        public void openFile(string path)
        {
            try
            {
                this.axFramerControl1.Open(path);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
          
        }
        public void doForDispose() {
            this.axFramerControl1.Close();           
        }
    }
}
