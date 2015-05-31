using NUnit.Framework;
using PosemètreCore.données;
using System;

namespace PosemètreCore.actions
{
    [TestFixture]
    public class ActionCalculIsoTest
    {
        ActionCalculIso actionIso;

        [SetUp]
        public void initialisationDeLAction()
        {
            actionIso = new ActionCalculIso();
        }

        [Test]
        public void doitRetournerLeTypeActionTempsDePose()
        {

            TypeAction typeDaction = actionIso.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Iso));
        }

        [Test]
        public void doitCalculerIsoSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 0, 1.0 / 125.0, 16);

            posemètre = actionIso.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getISO(), Is.EqualTo(100));
        }

    }
}
