using PosemètreCore.données;
using System;

namespace PosemètreCore.services
{
    public class ServicePosemètre
    {

        public double calculerOuverture(Posemètre posemètre)
        {
            double E = posemètre.getEclairementLumineux();
            double S = posemètre.getISO();
            double t = posemètre.getTempsDePose();

            double N2 = ((E * S) / Posemètre.CONSTANTE_ETALONNAGE) * t;

            double N = Math.Sqrt(N2);

            return Math.Round(N);
        }

        public double calculerIso(Posemètre posèmetre)
        {
            double E = posèmetre.getEclairementLumineux();
            double N = posèmetre.getOuverture();
            double t = posèmetre.getTempsDePose();

            double N2 = Math.Pow(N, 2);

            double ES = (N2 / t) * Posemètre.CONSTANTE_ETALONNAGE;

            double S = ES / E;

            return Math.Round(S);
        }

        public double calculerTempsDePose(Posemètre posemètre)
        {
            double E = posemètre.getEclairementLumineux();
            double S = posemètre.getISO();
            double N = posemètre.getOuverture();

            double N2 = Math.Pow(N, 2);

            double ESparC = (E * S) / Posemètre.CONSTANTE_ETALONNAGE;

            double t = Math.Round((N2 / ESparC), 3);

            if (t >= 60)
            {
                t = Math.Round(t / 60.0);
            }

            return t;
        }

    }
}
