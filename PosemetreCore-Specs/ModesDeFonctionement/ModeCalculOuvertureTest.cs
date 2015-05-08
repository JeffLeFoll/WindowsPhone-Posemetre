using NUnit.Framework;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    [TestFixture]
    class ModeCalculOuvertureTest
    {

        ModeCalculOuverture modeOuverture;

        [SetUp]
        public void initialisationDuMode()
        {
            modeOuverture = new ModeCalculOuverture();
        }

        [Test]
        public void doitFournirLeLibelléDuModeOuverture() 
        {
            String libellé = modeOuverture.fournirUnLibellé();

            Assert.That(libellé, Is.EqualTo("Ouverture"));
        }

        [Test]
        public void doitFournirLaDisponibilitéDuModeOuverture()
        {
            bool disponibilité = modeOuverture.estDisponible();

            Assert.That(disponibilité, Is.True);
        }

    }
}
