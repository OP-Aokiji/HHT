using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using HHT.Framework.ValidationHandler;
using System.Windows.Forms;
using System.Drawing;

namespace HHT.Framework.UserControls
{
    public partial class MyRadioButton : RadioButton, ITransactionControls
    {
        private ValidationError error;
        private string businessItemName = string.Empty;
        private bool mandatory = false;
        private Color fColor = Color.LightBlue;

        public MyRadioButton()
        {
            InitializeComponent();
        }

        public string isBusinessItemName
        {
            get { return businessItemName; }
            set { businessItemName = value; }
        }

        [DefaultValue(false)]
        public bool isMandatory
        {
            get { return mandatory; }
            set { mandatory = value; }
        }

        public Color focusColor
        {
            get { return fColor; }
        }

        public ValidationError validation()
        {
            if (mandatory && this.Visible && this.Enabled && this.Text == null && this.Text.Trim().Equals(string.Empty))
            {
                error = new ValidationError();
                error.ErrorID = "ERR-00001";
                error.ErrorMessage = string.Format("{0} is mandatory item", businessItemName);
                error.RaiseControl = this;

                return error;
            }

            return null;
        }

        #region Clear ControlValue
        public void clearControlValue()
        {
            this.Checked = false;
        }
        #endregion

        //public MyRadioButton(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
