using System;
using System.Collections.Generic;
using System.Text;

namespace HHT.Framework
{
    //Added by Khoa
    interface IContainerControls
    {
        bool validations(System.Windows.Forms.Control.ControlCollection controls);
        void clearControlValue(System.Windows.Forms.Control.ControlCollection controls);
    }
}
