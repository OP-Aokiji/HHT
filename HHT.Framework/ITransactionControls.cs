using System;
using System.Collections.Generic;
using System.Text;

namespace HHT.Framework
{
    public interface ITransactionControls : IConstraint
    {
        bool isMandatory { get; set; }
    }
}
