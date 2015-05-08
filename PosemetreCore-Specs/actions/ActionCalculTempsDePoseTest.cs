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
        
        [TestCase]
        public void doitRetournerLeTypeActionTempsDePose()
        {

            TypeAction typeDaction = actionTempsDePose.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.TempsDePose));
        }

        [TestCase]
        public void doitCalculerTempsDePoseSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 0, 16);

            double tempsDePose = actionTempsDePose.calculer(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1.0 / 125.0));
        }

        [TestCase]
        public void doitCalculerTempsDePoseEV1()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(5, 100, 0, 11);

            double tempsDePose = actionTempsDePose.calculer(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1));
        }
    }
}
