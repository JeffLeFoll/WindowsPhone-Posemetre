using NUnit.Framework;
using PosemètreCore.actions;

namespace PosemètreCore.commandes
{
    [TestFixture]
    class AnnuaireDActionsTest
    {
        [Test]
        public void doitFournirLActionOuverture() 
        {
            ActionDeCalcul actionVoulu = AnnuaireDActions.fournirLActionDeType(TypeAction.Ouverture);

            Assert.That(actionVoulu, Is.InstanceOf(typeof(ActionCalculOuverture)));
        }

        [Test]
        public void doitFournirLActionTempsDePose()
        {
            ActionDeCalcul actionVoulu = AnnuaireDActions.fournirLActionDeType(TypeAction.TempsDePose);

            Assert.That(actionVoulu, Is.InstanceOf(typeof(ActionCalculTempsDePose)));
        }

        [Test]
        public void doitFournirLActionIso()
        {
            ActionDeCalcul actionVoulu = AnnuaireDActions.fournirLActionDeType(TypeAction.Iso);

            Assert.That(actionVoulu, Is.InstanceOf(typeof(ActionCalculIso)));
        }
    }
}
