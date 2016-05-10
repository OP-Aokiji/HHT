using System;
using System.Collections.Generic;
using System.Text;
using HHT.Framework.ValidationHandler;

namespace HHT.Framework
{
    public interface IConstraint
    {
        ValidationError validation();
        void clearControlValue();
    }
}
