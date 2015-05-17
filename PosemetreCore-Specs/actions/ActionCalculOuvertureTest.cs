using NUnit.Framework;
using PosemètreCore.données;


namespace PosemètreCore.actions
{
    [TestFixture]
    class ActionCalculOuvertureTest
    {

        ActionCalculOuverture actionOuverture;

        [SetUp]
        public void initialisationDeLAction()
        {
            actionOuverture = new ActionCalculOuverture();
        }

        [Test]
        public void doitRetournerLeTypeActionOuverture()
        {

            TypeAction typeDaction = actionOuverture.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Ouverture));
        }

        [Test]
        public void doitCalculerOuvertureSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 1.0 / 125.0, 0);

            posemètre = actionOuverture.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getOuverture(), Is.EqualTo(16));
        }

        [TestCase(22, 60)]
        [TestCase(5.6, 4)]
        [TestCase(4, 2)]
        [TestCase(2.8, 1)]
        [TestCase(2, 0.5)]
        [TestCase(1.4, 0.25)]
        public void doitCalculerOuvertureEV3Iso100(double ouvertureAttendue, double tempsDePose)
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(20, 100, tempsDePose, 0);

            posemètre = actionOuverture.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getOuverture(), Is.EqualTo(ouvertureAttendue));
        }

        [TestCase(22, 0.125)]
        [TestCase(5.6, 0.008)]
        [TestCase(4, 0.004)]
        [TestCase(2.8, 0.002)]
        [TestCase(2, 0.001)]
        [TestCase(1.4, 0.0005)]
        public void doitCalculerOuvertureEV12Iso100(double ouvertureAttendue, double tempsDePose)
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(10000, 100, tempsDePose, 0);

            posemètre = actionOuverture.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getOuverture(), Is.EqualTo(ouvertureAttendue));
        }
    }
}
