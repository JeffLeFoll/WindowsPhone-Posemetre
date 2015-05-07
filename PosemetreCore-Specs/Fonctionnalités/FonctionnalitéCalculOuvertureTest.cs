using NUnit.Framework;
using System;

namespace PosemètreCore.Fonctionnalités
{
    [TestFixture]
    class FonctionnalitéCalculOuvertureTest
    {

        FonctionnalitéCalculOuverture fonctionnalitéOuverture;

        [SetUp]
        public void initialisationFonctionnalitées()
        {
            fonctionnalitéOuverture = new FonctionnalitéCalculOuverture();
        }

        [Test]
        public void doitFournirLeLibelléDeLaFonctionnalitéOuverture() 
        {
            String libellé = fonctionnalitéOuverture.fournirUnLibellé();

            Assert.That(libellé, Is.EqualTo("Ouverture"));
        }

        [Test]
        public void doitFournirLaDisponibilitéDeLaFonctionnalitéOuverture()
        {
            Boolean disponibilité = fonctionnalitéOuverture.estDisponible();

            Assert.That(disponibilité, Is.True);
        }

    }
}
