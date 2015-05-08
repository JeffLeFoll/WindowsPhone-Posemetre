using NUnit.Framework;
using PosemètreCore.actions;
using PosemètreCore.capteurs;
using PosemètreCore.données;

namespace PosemètreCore.commandes
{
    [TestFixture]
    class BusDeCommandesTest
    {
        [Test]
        public void doitRécupérerLaBonneActionEtFaireLeCalculCorrectement()
        {
            Capteur capteurDeTest = new DoublureDeCapteur();
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(0, 100, 0, 16);
            BusDeCommandes bus = new BusDeCommandes(capteurDeTest);

            posemètre = bus.éxécuterLaCommandeDeCalcul(TypeAction.TempsDePose, posemètre);

            Assert.That(posemètre.getTempsDePose(), Is.EqualTo(1.0 / 125.0));
        }

    }
}
