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

        [TestCase]
        public void doitRetournerLeTypeActionOuverture()
        {

            TypeAction typeDaction = actionOuverture.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Ouverture));
        }

        [TestCase]
        public void doitCalculerOuvertureSunny16()
        {
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 1.0 / 125.0, 0);

            double ouverture = actionOuverture.calculer(posemètre);

            Assert.That(ouverture, Is.EqualTo(16));
        }
    }
}
