using PosemetreCore.data;
using NUnit.Framework;


namespace PosemetreCore.services
{
    [TestFixture]
    public class ServicePosemetreTest
    {
        [TestCase]
        public void initialiserUnServicePosemetre()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();

            Assert.That(servicePosemetre, Is.Not.Null);
        }

        [TestCase]
        public void doitCalculerOuvertureSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 1.0 / 125.0, 0);

            double ouverture = servicePosemetre.calculerOuverture(posemetre);

            Assert.That(ouverture, Is.EqualTo(16));
        }


        [TestCase]
        public void doitCalculerIsoSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);

            double iso = servicePosemetre.calculerIso(posemetre);

            Assert.That(iso, Is.EqualTo(100));
        }

        [TestCase]
        public void doitCalculerTempsDePoseSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);

            double exposition = servicePosemetre.calculerTempsDExposition(posemetre);

            Assert.That(exposition, Is.EqualTo(1.0 / 125.0));
        }

        [TestCase]
        public void doitCalculerTempsDePoseEV1()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(5, 100, 0, 11);

            double exposition = servicePosemetre.calculerTempsDExposition(posemetre);

            Assert.That(exposition, Is.EqualTo(1));
        }

      /*  [TestCase]
        public void doitCalculerModeTempsDePose()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.TempsDePose);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getTempsDExposition(), Is.EqualTo(1.0 / 125.0));
        }


        [TestCase]
        public void doitCalculerModeIso()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Iso);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getISO(), Is.EqualTo(100));
        }

        [TestCase]
        public void doitCalculerModeOuverture()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 1.0 / 125.0, 0);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Ouverture);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getOuverture(), Is.EqualTo(16));
        }*/

        private static Posemetre genererUnPosemetre(double E, double S, double t, double N)
        {
            // E = illuminance en lux
            // S = vitesse iso
            // t = TempsDePose
            // N =  ouverture
            Posemetre posemetre = new Posemetre();

            posemetre.setEclairementLumineux(E);
            posemetre.setISO(S);
            posemetre.setTempsDExposition(t);
            posemetre.setOuverture(N);

            return posemetre;
        }
    }
}
