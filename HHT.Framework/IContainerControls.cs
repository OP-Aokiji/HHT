using System;
using System.Collections.Generic;
using System.Text;

namespace HHT.Framework
{
    interface IContainerControls
    {
        bool validations(System.Windows.Forms.Control.ControlCollection controls);
        void clearControlValue(System.Windows.Forms.Control.ControlCollection controls);
    }
}
