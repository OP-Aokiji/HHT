using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHT.UI
{
    public partial class MainForm : HHT.Framework.Controls.MyForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGrabList_Click(object sender, EventArgs e)
        {
            GrabListForm frm = new GrabListForm();
            frm.ShowDialog();
        }

    }
}

