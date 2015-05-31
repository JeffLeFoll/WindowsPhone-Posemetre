
namespace PosemètreCore.capteurs
{
    public class DoublureDeCapteur : Capteur
    {
        public bool estPrésentSurLeDevice()
        {
            return true;
        }

        public double lireMesureDuCapteur()
        {
            double éclairementLumineux = 82000;
            
            return éclairementLumineux;
        }
    }
}
