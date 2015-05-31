using Windows.Devices.Sensors;

namespace PosemètreCore.capteurs
{
    public class CapteurDeLuminosité : PosemètreCore.capteurs.Capteur
    {

        private LightSensor lightsensor;

        private bool capteurDeLumièrePresent;

        public CapteurDeLuminosité()
        {
           lightsensor = LightSensor.GetDefault();

            if (lightsensor == null)
            {
                capteurDeLumièrePresent = false;
            }
        }

        public bool estPrésentSurLeDevice()
        {
            return capteurDeLumièrePresent;
        }

        public double lireMesureDuCapteur()
        {
            double valeurRetour = -1;

           LightSensorReading valeurLue = lightsensor.GetCurrentReading();
           valeurRetour = System.Convert.ToDouble(valeurLue.IlluminanceInLux);

            return valeurRetour;
        }

    }
}
