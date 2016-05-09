using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HHT.Framework.Controls
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public void initialFormSize()
        {
            this.Height = 335;
            this.Width = 250;
        }
    }
}