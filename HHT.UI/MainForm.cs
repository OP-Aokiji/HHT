using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHT.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(240, 300);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnGrabList_Click(object sender, EventArgs e)
        {
            GrabListForm gl = new GrabListForm();
            gl.ShowDialog();
        }
    }
}