using NUnit.Framework;

namespace PosemètreCore.données
{
    //http://www.fredparker.com/ultexp1.htm

    [TestFixture]
    public class PosemetreTest
    {
        [Test]
        public void doitInitialiserUnPosemètre()
        {
            Posemètre posemètre = new Posemètre();

            Assert.That(posemètre, Is.Not.Null);
            Assert.That(Posemètre.CONSTANTE_ETALONNAGE, Is.EqualTo(255));
        }
    }
}
