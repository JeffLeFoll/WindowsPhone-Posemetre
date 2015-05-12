using NUnit.Framework;
using PosemètreCore.données;

namespace PosemètreCore.actions
{
    [TestFixture]
    class ActionCalculTempsDePoseTest
    {
        ActionCalculTempsDePose actionTempsDePose;

        [SetUp]
        public void initialisationDeLAction()
        {
            actionTempsDePose = new ActionCalculTempsDePose();
        }

        [Test]
        public void doitRetournerLeTypeActionTempsDePose()
        {

            TypeAction typeDaction = actionTempsDePose.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.TempsDePose));
        }

        [Test]
        public void doitCalculerTempsDePoseSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 0, 16);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(0.008));
        }

        [TestCase(22, 60)]
        [TestCase(5.6, 4)]
        [TestCase(4, 2)]
        [TestCase(2.8, 1)]
        [TestCase(2, 0.5)]
        [TestCase(1.4, 0.25)]
        public void doitCalculerTempsDePoseEV3Iso100(double ouverture, double tempsDePoseAttendu)
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(20, 100, 0, ouverture);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(tempsDePoseAttendu));
        }

        [TestCase(22, 0.125)]
        [TestCase(5.6, 0.008)]
        [TestCase(4, 0.004)]
        [TestCase(2.8, 0.002)]
        [TestCase(2, 0.001)]
        [TestCase(1.4, 0.0005)]
        public void doitCalculerTempsDePoseEV12Iso100(double ouverture, double tempsDePoseAttendu)
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(10000, 100, 0, ouverture);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(tempsDePoseAttendu));
        }
    }
}
