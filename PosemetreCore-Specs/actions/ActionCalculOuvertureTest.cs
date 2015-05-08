using NUnit.Framework;
using PosemètreCore.données;


namespace PosemètreCore.actions
{
    [TestFixture]
    class ActionCalculOuvertureTest
    {
        [TestCase]
        public void doitRetournerLeTypeActionOuverture()
        {
            ActionCalculOuverture actionOuverture = new ActionCalculOuverture();

            TypeAction typeDaction = actionOuverture.indiqueLeTypeDeLAction();

            Assert.That(typeDaction, Is.EqualTo(TypeAction.Ouverture));
        }

        [TestCase]
        public void doitCalculerOuvertureSunny16()
        {
            ActionCalculOuverture actionOuverture = new ActionCalculOuverture();
            Posemètre posemètre = GénérateurDePosemètre.générerUnPosemètre(82000, 100, 1.0 / 125.0, 0);

            double ouverture = actionOuverture.calculer(posemètre);

            Assert.That(ouverture, Is.EqualTo(16));
        }
    }
}
