using NUnit.Framework;
using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    [TestFixture]
    class ModeCalculIsoTest
    {
        ModeCalculIso modeIso;

        [SetUp]
        public void initialisationDuMode()
        {
            modeIso = new ModeCalculIso();
        }

        [Test]
        public void doitFournirLeLibelléDuModeISO()
        {
            String libellé = modeIso.fournirUnLibellé();

            Assert.That(libellé, Is.EqualTo("ISO"));
        }

        [Test]
        public void doitFournirLaDisponibilitéDuModeISO()
        {
            bool disponibilité = modeIso.estDisponible();

            Assert.That(disponibilité, Is.False);
        }

        [Test]
        public void doitFournirLeTypeActionIso()
        {
            TypeAction action = modeIso.aPourAction();

            Assert.That(action, Is.EqualTo(TypeAction.Iso));
        }
    }
}
