using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;

namespace PosemetreCore.data
{
    //http://www.fredparker.com/ultexp1.htm

    [TestClass]
    public class PosemetreTest
    {
        [TestMethod]
        public void initialiserUnPosemetre()
        {
            double constanteC = 255;
            Posemetre posemetre = new Posemetre();

            Assert.IsNotNull(posemetre);
            Assert.AreEqual(constanteC, Posemetre.C);
        }
    }
}
