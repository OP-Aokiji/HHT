using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using HHT.Framework;
using HHT.Framework.ValidationHandler;

namespace HHT.Framework.UserControls
{
    public partial class MyTextBox : TextBox, IConstraint
    {
        #region local variable
        private ValidationError error;
        private bool mandatory = false;
        private CharacterList characterType = CharacterList.Default;
        private string businessItemName = string.Empty;
        private int nSmallestInputLength = 0;
        #endregion

        #region characterList
        public enum CharacterList
        {
            Default,
            UpperCase,
            LowerCase
        }
        #endregion

        [DefaultValue(CharacterList.Default)]
        public CharacterList isCharacterType
        {
            get { return characterType; }
            set { characterType = value; }
        }

        #region Mandatory
        [DefaultValue(false)]
        public bool isMandatory
        {
            get { return mandatory; }
            set { mandatory = value; }
        }

        public void ResetisMandatory()
        {
            mandatory = false;
        }
        public bool ShouldSerializeisMandatory()
        {
            return mandatory != false;
        }
        #endregion

        #region Business Name
        [DefaultValue(0)]
        public int isSmallestInputLength
        {
            get { return nSmallestInputLength; }
            set { nSmallestInputLength = value; }
        }
        public bool ShouldSerializeisSmallestInputLength()
        {
            return nSmallestInputLength != 0;
        }

        public string isBusinessItemName
        {
            get { return businessItemName; }
            set { businessItemName = value; }
        }

        public void ResetisFBusinessItemName()
        {
            businessItemName = string.Empty;
        }
        public bool ShouldSerializeisBusinessItemName()
        {
            return businessItemName != string.Empty;
        }
        #endregion


        public MyTextBox()
        {
            InitializeComponent();
        }

        public MyTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        #region Control Validation Check
        public ValidationError validation()
        {
            if (mandatory && this.Visible && this.Enabled && (this.Text == null || this.Text.Trim().Equals(string.Empty)))
            {
                makeError();

                error = new ValidationError();
                error.ErrorID = "ERR-00001";
                error.ErrorMessage = string.Format("{0} is a mandatory item", businessItemName);
                error.RaiseControl = this;

                return error;
            }

            if (mandatory && this.Visible && this.Enabled && nSmallestInputLength > 0 && (this.Text.Length < nSmallestInputLength))
            {
                makeError();

                error = new ValidationError();
                error.ErrorID = "ERR-00002";
                error.ErrorMessage = string.Format("{0} has to input at least {1} character(s)", businessItemName, nSmallestInputLength);
                error.RaiseControl = this;

                return error;
            }

            return null;
        }
        #endregion



        #region IConstraint Members


        public void clearControlValue()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region Display Error
        private void makeError()
        {
            this.BackColor = Framework.Common.Constants.DefaultColor;
        }
        #endregion
    }
}
