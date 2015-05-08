using PosemètreCore.données;
using System;

namespace PosemètreCore.actions
{
    public class ActionCalculIso : ActionDeCalcul
    {
        public TypeAction indiqueLeTypeDeLAction()
        {
            return TypeAction.Iso;
        }

        public Posemètre mettreAJourLePosemètre(Posemètre posemètre)
        {
            double iso = calculerIso(posemètre);

            posemètre.setISO(iso);

            return posemètre;
        }

        private double calculerIso(Posemètre posemètre)
        {
            double E = posemètre.getEclairementLumineux();
            double N = posemètre.getOuverture();
            double t = posemètre.getTempsDePose();

            double N2 = Math.Pow(N, 2);

            double ES = (N2 / t) * Posemètre.CONSTANTE_ETALONNAGE;

            double S = ES / E;

            return Math.Round(S);
        }
    }
}
