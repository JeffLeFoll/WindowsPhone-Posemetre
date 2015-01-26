using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using PosemetreCore.data;


namespace PosemetreCore.services
{
    [TestClass]
    public class ServicePosemetreTest
    {
        [TestMethod]
        public void initialiserUnServicePosemetre() {
            ServicePosemetre servicePosemetre = new ServicePosemetre();

            Assert.IsNotNull(servicePosemetre);
        }

        [TestMethod]
        public void calculerOuvertureSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 1.0 / 125.0, 0);

            servicePosemetre.calculerOuverture(posemetre);

            Assert.AreEqual(16, posemetre.getN());
        }


        [TestMethod]
        public void calculerIsoSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);

            servicePosemetre.calculerIso(posemetre);

            Assert.AreEqual(100, posemetre.getS());
        }

        [TestMethod]
        public void calculerTempsDePoseSunny16()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);
  
            servicePosemetre.calculerTempsDePose(posemetre);

            Assert.AreEqual(1.0 / 125.0, posemetre.getT());
        }

        [TestMethod]
        public void calculerTempsDePoseEV1()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(5, 100, 0, 11);

            servicePosemetre.calculerTempsDePose(posemetre);

            Assert.AreEqual(1, posemetre.getT());
        }

        [TestMethod]
        public void calculerModeTempsDePose()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.TempsDePose);

            servicePosemetre.calculer(posemetre);

            Assert.AreEqual(1.0 / 125.0, posemetre.getT());
        }


        [TestMethod]
        public void calculerModeIso()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 0, 1.0 / 125.0, 16);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Iso);

            servicePosemetre.calculer(posemetre);

            Assert.AreEqual(100, posemetre.getS());
        }

        [TestMethod]
        public void calculerModeOuverture()
        {
            ServicePosemetre servicePosemetre = new ServicePosemetre();
            Posemetre posemetre = genererUnPosemetre(82000, 100, 1.0 / 125.0, 0);
            posemetre.setModeDUtilisation(ModeDuPosemetre.Ouverture);

            servicePosemetre.calculer(posemetre);

            Assert.AreEqual(16, posemetre.getN());
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
