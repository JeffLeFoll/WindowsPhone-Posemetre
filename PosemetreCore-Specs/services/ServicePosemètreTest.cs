using PosemètreCore.données;
using NUnit.Framework;


namespace PosemètreCore.services
{
    [TestFixture]
    public class servicePosemètreTest
    {
        [TestCase]
        public void initialiserUnservicePosemètre()
        {
            ServicePosemètre servicePosemètre = new ServicePosemètre();

            Assert.That(servicePosemètre, Is.Not.Null);
        }

        [TestCase]
        public void doitCalculerOuvertureSunny16()
        {
            ServicePosemètre servicePosemètre = new ServicePosemètre();
            Posemètre posemètre = générerUnPosemètre(82000, 100, 1.0 / 125.0, 0);

            double ouverture = servicePosemètre.calculerOuverture(posemètre);

            Assert.That(ouverture, Is.EqualTo(16));
        }


        [TestCase]
        public void doitCalculerIsoSunny16()
        {
            ServicePosemètre servicePosemètre = new ServicePosemètre();
            Posemètre posemètre = générerUnPosemètre(82000, 0, 1.0 / 125.0, 16);

            double iso = servicePosemètre.calculerIso(posemètre);

            Assert.That(iso, Is.EqualTo(100));
        }

        [TestCase]
        public void doitCalculerTempsDePoseSunny16()
        {
            ServicePosemètre servicePosemètre = new ServicePosemètre();
            Posemètre posemètre = générerUnPosemètre(82000, 100, 0, 16);

            double tempsDePose = servicePosemètre.calculerTempsDePose(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1.0 / 125.0));
        }

        [TestCase]
        public void doitCalculerTempsDePoseEV1()
        {
            ServicePosemètre servicePosemètre = new ServicePosemètre();
            Posemètre posemètre = générerUnPosemètre(5, 100, 0, 11);

            double tempsDePose = servicePosemètre.calculerTempsDePose(posemètre);

            Assert.That(tempsDePose, Is.EqualTo(1));
        }

        private static Posemètre générerUnPosemètre(double E, double S, double t, double N)
        {
            // E = illuminance en lux
            // S = vitesse iso
            // t = TempsDePose
            // N =  ouverture
            Posemètre posemètre = new Posemètre();

            posemètre.setEclairementLumineux(E);
            posemètre.setISO(S);
            posemètre.setTempsDePose(t);
            posemètre.setOuverture(N);

            return posemètre;
        }
    }
}
