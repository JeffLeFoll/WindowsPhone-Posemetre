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

        [Test]
        public void doitCalculerTempsDePoseEV3Iso100F2()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(20, 100, 0, 2);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(0.5));
        }

        [Test]
        public void doitCalculerTempsDePoseEV1Iso100F14()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(20, 100, 0, 4);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(2));
        }
    }
}
