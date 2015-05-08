using Windows.Devices.Sensors;

namespace PosemètreCore.capteur
{
    public class CapteurDeLuminosité
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

        public bool aUnCapteurDeLumière()
        {
            return capteurDeLumièrePresent;
        }

        public double lireMesureDuCapteurDeLuminosité()
        {
            double valeurRetour = -1;

           LightSensorReading valeurLue = lightsensor.GetCurrentReading();
           valeurRetour = System.Convert.ToDouble(valeurLue.IlluminanceInLux);

            return valeurRetour;
        }

    }
}
