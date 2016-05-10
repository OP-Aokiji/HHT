using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using HHT.Framework.ValidationHandler;

namespace HHT.Framework.UserControls
{
    public partial class MyComboBox : ComboBox, ITransactionControls, IConstraint
    {
        private ValidationError error;
        private string businessItemName = string.Empty;
        private bool mandatory = false;

        public MyComboBox()
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

        #region Control Validation Check
        public ValidationError validation()
        {
            if (mandatory && this.Visible && this.Enabled && (this.Text == null || this.Text.Trim().Equals(string.Empty) || "Select".Equals(this.Text)))
            {
                error = new ValidationError();
                error.ErrorID = "ERR-00001";
                error.ErrorMessage = string.Format("{0} is a mandatory item", businessItemName);
                error.RaiseControl = this;

                return error;
            }

            return null;
        }
        private void makeError()
        {
            this.BackColor = Framework.Common.Constants.DefaultColor;
        }
        #endregion

        #region Clear ControlValue
        public void clearControlValue()
        {
            this.SelectedIndex = -1;
        }
        #endregion

        //public MyComboBox(IContainer container)
        //{
        //    container.Add(this);

        //    InitializeComponent();
        //}
    }
}
