using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using HHT.UI;
using System.Windows.Forms;
using HHT.Framework;

namespace NUnit
{
    [TestFixture]
    public class NUnit : AssertionHelper
    {
        [Test]
        public void PlusNUnit()
        {
            //Application.Run(new LoginForm());
            new LoginForm().ShowDialog();
        }
    }
}
