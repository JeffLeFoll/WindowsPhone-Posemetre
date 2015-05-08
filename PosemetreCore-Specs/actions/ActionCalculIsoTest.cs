using NUnit.Framework;
using PosemètreCore.données;

namespace PosemètreCore.actions
{
    [TestFixture]
    public class ActionCalculIsoTest
    {
        [TestCase]
        public void doitRetournerLeTypeActionTempsDePose()
        {
            ActionCalculIso actionIso = new ActionCalculIso();

            TypeAction typeDaction = actionIso.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Iso));
        }

        [TestCase]
        public void doitCalculerIsoSunny16()
        {
            ActionCalculIso actionIso = new ActionCalculIso();
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 0, 1.0 / 125.0, 16);

            double iso = actionIso.calculer(posemètre);

            Assert.That(iso, Is.EqualTo(100));
        }
    }
}
