using PosemetreCore.data;
using System;

namespace PosemetreCore.services
{
    public class ServicePosemetre
    {

        public double calculerOuverture(Posemetre posemetre)
        {
            double E = posemetre.getEclairementLumineux();
            double S = posemetre.getISO();
            double t = posemetre.getTempsDExposition();

            double N2 = ((E * S) / Posemetre.CONSTANTE_ETALONNAGE) * t;

            double N = Math.Sqrt(N2);

            return Math.Round(N);
        }

        public double calculerIso(Posemetre posemetre)
        {
            double E = posemetre.getEclairementLumineux();
            double N = posemetre.getOuverture();
            double t = posemetre.getTempsDExposition();

            double N2 = Math.Pow(N, 2);

            double ES = (N2 / t) * Posemetre.CONSTANTE_ETALONNAGE;

            double S = ES / E;

            return Math.Round(S);
        }

        public double calculerTempsDExposition(Posemetre posemetre)
        {
            double E = posemetre.getEclairementLumineux();
            double S = posemetre.getISO();
            double N = posemetre.getOuverture();

            double N2 = Math.Pow(N, 2);

            double ESparC = (E * S) / Posemetre.CONSTANTE_ETALONNAGE;

            double t = Math.Round((N2 / ESparC), 3);

            if (t >= 60)
            {
                t = Math.Round(t / 60.0);
            }

            return t;
        }


       /* public void calculer(Posemetre posemetre)
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
                    this.calculerTempsDExposition(posemetre);
                    break;
            }
        }*/

    /*  public void mesurer(Posemetre posemetre)
        {
            lumiereMesure = lireMesureDuCapteurDeLuminosité();

            posemetre.setE(lumiereMesure);

            calculer(posemetre);
        }*/
    }
}
