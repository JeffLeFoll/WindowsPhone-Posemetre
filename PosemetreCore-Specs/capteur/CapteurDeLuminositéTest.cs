using NUnit.Framework;

namespace PosemètreCore.capteur
{
    [TestFixture]
    class CapteurDeLuminositéTest
    {
        [TestCase]
        public void doitIndiquerLAbsenceDeCapteurDuDevice()
        {
            CapteurDeLuminosité capteur = new CapteurDeLuminosité();

            bool présenceDUnCapteur = capteur.aUnCapteurDeLumière();

            Assert.That(présenceDUnCapteur, Is.False);
        }
    }
}
