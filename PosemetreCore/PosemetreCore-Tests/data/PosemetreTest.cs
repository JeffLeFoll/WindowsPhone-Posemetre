using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PosemetreCore.data
{
    //http://www.fredparker.com/ultexp1.htm

    [TestFixture]
    public class PosemetreTest
    {
        [Test]
        public void initialiserUnPosemetre()
        {
            Posemetre posemetre = new Posemetre();

            Assert.That(posemetre, Is.Not.Null);
            Assert.That(Posemetre.C, Is.EqualTo(255));
        }
    }
}
