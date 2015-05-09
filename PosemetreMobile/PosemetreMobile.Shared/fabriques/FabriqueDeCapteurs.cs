using PosemètreCore.capteurs;

namespace PosemetreMobile.fabriques
{
    public class FabriqueDeCapteurs
    {
        public static Capteur fabriquerUnCapteurDeLuminosité() 
        {
            return new CapteurDeLuminosité();
        }

    }
}
