using PosemètreCore.données;
using PosemètreCore.utils;
using System;

namespace PosemètreCore.actions
{
    public class ActionCalculOuverture : ActionDeCalcul
    {
        public TypeAction indiqueLeTypeDeLAction()
        {
            return TypeAction.Ouverture;
        }

        public Posemètre mettreAJourLePosemètre(Posemètre posemètre)
        {
            double ouverture = calculOuverture(posemètre);

            posemètre.setOuverture(ouverture);

            return posemètre;
        }

        private double calculOuverture(Posemètre posemètre)
        {
            double E = posemètre.getEclairementLumineux();
            double S = posemètre.getISO();
            double t = posemètre.getTempsDePose();

            double N2 = ((E * S) / Posemètre.CONSTANTE_ETALONNAGE) * t;

            double N = Math.Sqrt(N2);

            return Arrondiseur.arrondire(N, Ouverture.récupérerLesValeuresDOuverture());
        }
    }
}
