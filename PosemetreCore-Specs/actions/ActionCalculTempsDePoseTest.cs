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

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(1.0 / 125.0));
        }

        [Test]
        public void doitCalculerTempsDePoseEV1()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(5, 100, 0, 11);

            posemètre = actionTempsDePose.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(1));
        }
    }
}
