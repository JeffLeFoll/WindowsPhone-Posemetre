using NUnit.Framework;
using PosemètreCore.données;

namespace PosemètreCore.actions
{
    [TestFixture]
    class ActionCalculTempsDePoseTest
    {
        [TestCase]
        public void doitRetournerLeTypeActionTempsDePose()
        {
            ActionCalculTempsDePose actionTempsDePose = new ActionCalculTempsDePose();

            TypeAction typeDaction = actionTempsDePose.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.TempsDePose));
        }

        [TestCase]
        public void doitCalculerTempsDePoseSunny16()
        {
            ActionCalculTempsDePose actionTempsDePose = new ActionCalculTempsDePose();
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 0, 16);

            double tempsDePose = actionTempsDePose.calculer(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1.0 / 125.0));
        }

        [TestCase]
        public void doitCalculerTempsDePoseEV1()
        {
            ActionCalculTempsDePose actionTempsDePose = new ActionCalculTempsDePose();
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(5, 100, 0, 11);

            double tempsDePose = actionTempsDePose.calculer(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1));
        }
    }
}
