using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            servicePosemetre.calculerOuverture(posemetre);

            Assert.That(posemetre.getN(), Is.EqualTo(16));
        }


        [TestCase]
        public void doitCalculerIsoSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);

            servicePosemetre.calculerIso(posemetre);

            Assert.That(posemetre.getS(), Is.EqualTo(100));
        }

        [TestCase]
        public void doitCalculerTempsDePoseSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);
  
            servicePosemetre.calculerTempsDePose(posemetre);

            Assert.That(posemetre.getT(), Is.EqualTo(1.0 / 125.0));
        }

        [TestCase]
        public void doitCalculerTempsDePoseEV1()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(5, 100, 0, 11);

            servicePosemetre.calculerTempsDePose(posemetre);

            Assert.That(posemetre.getT(), Is.EqualTo(1));
        }

        [TestCase]
        public void doitCalculerModeTempsDePose()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.TempsDePose);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getT(), Is.EqualTo(1.0 / 125.0));
        }


        [TestCase]
        public void doitCalculerModeIso()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Iso);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getS(), Is.EqualTo(100));
        }

        [TestCase]
        public void doitCalculerModeOuverture()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 1.0 / 125.0, 0);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Ouverture);

            servicePosemetre.calculer(posemetre);

            Assert.That(posemetre.getN(), Is.EqualTo(16));
        }

        private static Posemetre genererUnPosemetre(double E, double S, double t, double N)
        {
            // E = illuminance en lux
            // S = vitesse iso
            // t = TempsDePose
            // N =  ouverture
            Posemetre posemetre = new Posemetre();

            posemetre.setE(E);
            posemetre.setS(S);
            posemetre.setT(t);
            posemetre.setN(N);

            return posemetre;
        }
    }
}
