using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace HHT.Framework.ValidationHandler
{
    public class ValidationError
    {
        private string errorID;
        private string errorMessage;
        private Control control;

        public string ErrorID
        {
            get { return errorID; }
            set { errorID = value; }
        }

        public string ErrorMessage
        {
            get { return errorMessage; }
            set { errorMessage = value; }
        }

        public Control RaiseControl
        {
            get { return control; }
            set { control = value; }
        }
    }
}
