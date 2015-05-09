using NUnit.Framework;

namespace PosemètreCore.util
{
    [TestFixture]
    class FractionTest
    {
        [Test]
        public void doitConstruireUneFractionDepuisUnDouble()
        {
            double valeure = 0.51;

            Fraction fraction = new Fraction(valeure);

            Assert.That(fraction.ToString(), Is.EqualTo("1/2"));
        }
    }
}
