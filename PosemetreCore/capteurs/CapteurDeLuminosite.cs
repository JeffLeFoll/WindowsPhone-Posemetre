using Windows.Devices.Sensors;

namespace PosemetreCore.capteur
{
    class CapteurDeLuminosite
    {

        private LightSensor lightsensor;

        private bool capteurDeLumierePresent;

        public CapteurDeLuminosite()
        {
           lightsensor = LightSensor.GetDefault();

            if (lightsensor == null)
            {
                capteurDeLumierePresent = false;
            }
        }

        public bool aUnCapteurDeLumiere()
        {
            return capteurDeLumierePresent;
        }

        public double lireMesureDuCapteurDeLuminosité()
        {
            double valeurRetour = -1;

           LightSensorReading valeurLue = lightsensor.GetCurrentReading();
           valeurRetour = System.Convert.ToDouble(valeurLue.IlluminanceInLux.ToString());

            return valeurRetour;
        }

    }
}
