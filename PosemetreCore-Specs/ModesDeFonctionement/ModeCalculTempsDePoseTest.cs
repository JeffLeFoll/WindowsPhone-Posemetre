using NUnit.Framework;
using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    [TestFixture]
    class ModeCalculTempsDePoseTest
    {
        ModeCalculTempsDePose modeTempsDePose;

        [SetUp]
        public void initialisationDuMode()
        {
            modeTempsDePose = new ModeCalculTempsDePose();
        }

        [Test]
        public void doitFournirLeLibelléDuModeTempsDePose()
        {
            String libellé = modeTempsDePose.fournirUnLibellé;

            Assert.That(libellé, Is.EqualTo("Temps de pose"));
        }

        [Test]
        public void doitFournirLaDisponibilitéDuModeTempsDePose()
        {
            bool disponibilité = modeTempsDePose.estDisponible;

            Assert.That(disponibilité, Is.True);
        }

        [Test]
        public void doitFournirLeTypeActionTempsDePose()
        {
            TypeAction action = modeTempsDePose.aPourAction;

            Assert.That(action, Is.EqualTo(TypeAction.TempsDePose));
        }
    }
}
