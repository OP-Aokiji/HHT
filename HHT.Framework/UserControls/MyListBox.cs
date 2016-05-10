using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using HHT.Framework.ValidationHandler;

namespace HHT.Framework.UserControls
{
    public partial class MyListBox : ListBox, ITransactionControls
    {
        private ValidationError error;
        private string businessItemName = string.Empty;

        public MyListBox()
        {
            InitializeComponent();
        }

        public MyListBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public string isBusinessItemName
        {
            get { return businessItemName; }
            set { businessItemName = value; }
        }

        private bool mandatory = false;
        [DefaultValue(false)]
        public bool isMandatory
        {
            get { return mandatory; }
            set { mandatory = value; }
        }

        #region Control Validation Check
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
        #endregion

        #region Clear ControlValue
        public void clearControlValue()
        {

        }
        #endregion
    }
}
