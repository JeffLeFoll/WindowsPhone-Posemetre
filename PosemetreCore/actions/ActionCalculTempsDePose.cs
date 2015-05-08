using PosemètreCore.données;
using System;

namespace PosemètreCore.actions
{
    public class ActionCalculTempsDePose : ActionDeCalcul
    {
        public TypeAction indiqueLeTypeDeLAction()
        {
            return TypeAction.TempsDePose;
        }

        public Posemètre mettreAJourLePosemètre(Posemètre posemètre)
        {
            double tempsDePose = calculerTempsDePose(posemètre);

            posemètre.setTempsDePose(tempsDePose);

            return posemètre;
        }

        private double calculerTempsDePose(Posemètre posemètre)
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
