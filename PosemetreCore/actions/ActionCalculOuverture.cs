using PosemètreCore.données;
using System;

namespace PosemètreCore.actions
{
    public class ActionCalculOuverture : Action
    {
        public TypeAction indiqueLeTypeDeLAction()
        {
            return TypeAction.Ouverture;
        }

        public double calculer(Posemètre posemètre)
        {
            double E = posemètre.getEclairementLumineux();
            double S = posemètre.getISO();
            double t = posemètre.getTempsDePose();

            double N2 = ((E * S) / Posemètre.CONSTANTE_ETALONNAGE) * t;

            double N = Math.Sqrt(N2);

            return Math.Round(N);
        }
    }
}
