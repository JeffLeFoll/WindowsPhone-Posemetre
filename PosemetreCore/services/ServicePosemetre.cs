using PosemetreCore.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.Devices.Sensors;

namespace PosemetreCore.services
{
    public class ServicePosemetre
    {
        private LightSensor lightsensor;
        private double lumiereMesure;

        private bool capteurDeLumierePresent;

        public ServicePosemetre() {
            lightsensor = LightSensor.GetDefault();

            if (lightsensor == null) {
                capteurDeLumierePresent = false;
            }
        }

        public bool aUnCapteurDeLumiere() {
            return capteurDeLumierePresent;
        }

        public double lireMesureDuCapteurDeLuminosité()
        {
            double valeurRetour = -1;
            
            LightSensorReading valeurLue = lightsensor.GetCurrentReading();
            valeurRetour = System.Convert.ToDouble(valeurLue.IlluminanceInLux.ToString());

            return valeurRetour;
        }

        public void calculerOuverture(Posemetre posemetre)
        {
            double E = posemetre.getE();
            double S = posemetre.getS();
            double t = posemetre.getT();

            double N2 = ((E * S) / Posemetre.C) * t;

            double N = Math.Sqrt(N2);

            posemetre.setN(Math.Round(N));
        }

        public void calculerIso(Posemetre posemetre)
        {
            double E = posemetre.getE();
            double N = posemetre.getN();
            double t = posemetre.getT();

            double N2 = Math.Pow(N, 2);

            double ES = (N2 / t) * Posemetre.C;

            double S = ES / E;

            posemetre.setS(Math.Round(S));
        }

        public void calculerTempsDePose(Posemetre posemetre)
        {
            double E = posemetre.getE();
            double S = posemetre.getS();
            double N = posemetre.getN();
            
            double N2 = Math.Pow(N, 2);

            double ESparC = (E * S) / Posemetre.C;

            double t = Math.Round((N2 / ESparC), 3);

            if (t >= 60)
            {
                t = Math.Round(t / 60.0);
            }

            posemetre.setT(t);
        }


        public void calculer(Posemetre posemetre)
        {
            switch (posemetre.getModeUtilisation())
            { 
                case ModeDuPosemetre.Iso:
                    this.calculerIso(posemetre);
                    break;
                case ModeDuPosemetre.Ouverture:
                    this.calculerOuverture(posemetre);
                    break;
                case ModeDuPosemetre.TempsDePose:
                    this.calculerTempsDePose(posemetre);
                    break;
            }
        }

        public void mesurer(Posemetre posemetre)
        {
            lumiereMesure = lireMesureDuCapteurDeLuminosité();

            posemetre.setE(lumiereMesure);

            calculer(posemetre);
        }
    }
}
