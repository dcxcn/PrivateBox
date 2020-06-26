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
    public partial class PDFViewer : UserControl
    {
        public PDFViewer()
        {
            InitializeComponent();
        }
        public void openFile(string path)
        {
            this.axAcroPDF1.LoadFile(path);
        }
    }
}
