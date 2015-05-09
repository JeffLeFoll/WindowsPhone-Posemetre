using PosemètreCore.actions;
using PosemètreCore.capteurs;
using PosemètreCore.commandes;
using PosemètreCore.données;
using PosemetreMobile.fabriques;

namespace PosemetreMobile.relais
{
    public class RelaiCommandesCalcul
    {
        public Posemètre executerCommande(TypeAction typeDAction, Posemètre posemètre) 
        {
            Capteur capteur = FabriqueDeCapteurs.fabriquerUnCapteurDeLuminosité();

            BusDeCommandes bus = new BusDeCommandes(capteur);

            posemètre = bus.éxécuterLaCommandeDeCalcul(typeDAction, posemètre);

            return posemètre;
        }
    }
}
