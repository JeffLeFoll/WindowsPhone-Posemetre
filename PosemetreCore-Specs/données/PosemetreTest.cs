using NUnit.Framework;

namespace PosemetreCore.data
{
    //http://www.fredparker.com/ultexp1.htm

    [TestFixture]
    public class PosemetreTest
    {
        [TestCase]
        public void doitInitialiserUnPosemetre()
        {
            Posemetre posemetre = new Posemetre();

            Assert.That(posemetre, Is.Not.Null);
            Assert.That(Posemetre.CONSTANTE_ETALONNAGE, Is.EqualTo(255));
        }
    }
}
