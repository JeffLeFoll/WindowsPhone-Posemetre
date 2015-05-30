using PosemètreCore.actions;
using PosemètreCore.annuaires;
using PosemètreCore.capteurs;
using PosemètreCore.données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosemètreCore.commandes
{
    public class BusDeCommandes
    {
        private Capteur capteurDeLuminosité;

        public BusDeCommandes(Capteur capteur) 
        {
            capteurDeLuminosité = capteur;
        }

        public Posemètre éxécuterLaCommandeDeCalcul(TypeAction typeDAction, Posemètre posemètre) 
        {
            ActionDeCalcul action = AnnuaireDActions.fournirLActionDeType(typeDAction);

            double éclairementLumineux = capteurDeLuminosité.lireMesureDuCapteur();

            posemètre.setEclairementLumineux(éclairementLumineux);

            action.mettreAJourLePosemètre(posemètre);

            return posemètre;
        }
    }
}
