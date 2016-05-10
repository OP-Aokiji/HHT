using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Specialized;
using HHT.Framework.ValidationHandler;

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

        #region Local Valiable
        private HybridDictionary errorControls = new HybridDictionary();
        #endregion

        #region Validation Controls
        public bool validations(System.Windows.Forms.Control.ControlCollection controls)
        {
            errorControls = new HybridDictionary();

            this.checkControls(controls);

            if (errorControls.Count > 0)
            {
                displayError();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void checkControls(System.Windows.Forms.Control.ControlCollection controls)
        {
            foreach (Control ctl in controls)
            {
                if (ctl is IContainerControls)
                {
                    this.checkControls(ctl.Controls);
                }

                if (ctl is IConstraint)
                {
                    IConstraint chkControl = (IConstraint)ctl;
                    ValidationError error = chkControl.validation();

                    if (error != null)
                    {
                        errorControls.Add(error.RaiseControl.Name, error);
                    }
                }
            }
        }
        private void displayError()
        {
            //frmValidationMsg msg = new frmValidationMsg(errorControls);
            //msg.ShowDialog();
        }
        #endregion

        public new DialogResult ShowDialog()
        {
            return base.ShowDialog();
        }

        #region Clear Controls Value
        public void clearControlValue(System.Windows.Forms.Control.ControlCollection controls)
        {

            foreach (Control ctl in controls)
            {
                if (ctl is IContainerControls)
                {
                    this.clearControlValue(ctl.Controls);
                }
                else if (ctl is IConstraint)
                {
                    IConstraint clearControl = (IConstraint)ctl;
                    clearControl.clearControlValue();
                }
                else
                {
                    if (ctl.Controls.Count > 0)
                    {
                        this.clearControlValue(ctl.Controls);
                    }
                }
            }
        }
        #endregion
    }
}