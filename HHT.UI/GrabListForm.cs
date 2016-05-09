using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHT.UI
{
    public partial class GrabListForm : Form
    {
        public GrabListForm()
        {
            InitializeComponent();
            this.Size = new Size(240, 300);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}