using NUnit.Framework;
using PosemètreCore.données;


namespace PosemètreCore.actions
{
    [TestFixture]
    class ActionCalculOuvertureTest
    {

        ActionCalculOuverture actionOuverture;

        [SetUp]
        public void initialisationDeLAction()
        {
            actionOuverture = new ActionCalculOuverture();
        }

        [Test]
        public void doitRetournerLeTypeActionOuverture()
        {

            TypeAction typeDaction = actionOuverture.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Ouverture));
        }

        [Test]
        public void doitCalculerOuvertureSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 1.0 / 125.0, 0);

            posemètre = actionOuverture.mettreAJourLePosemètre(posemètre);

            Assert.That(posemètre.getOuverture(), Is.EqualTo(16));
        }
    }
}
