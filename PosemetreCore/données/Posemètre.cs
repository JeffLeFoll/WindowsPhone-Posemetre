
namespace PosemètreCore.données
{
    public class Posemètre
    {
        public static readonly double CONSTANTE_ETALONNAGE = 255;

        private double éclairementLumineux;
        private double iso;
        private double tempsDePose;
        private double ouverture;

        public void setEclairementLumineux(double éclairementLumineux)
        {
            this.éclairementLumineux = éclairementLumineux;
        }

        public double getEclairementLumineux()
        {
            return éclairementLumineux;
        }

        public void setISO(double iso)
        {
            this.iso = iso;
        }

        public double getISO()
        {
            return iso;
        }

        public void setTempsDePose(double tempsDePose)
        {
            this.tempsDePose = tempsDePose;
        }

        public double getTempsDePose()
        {
            return tempsDePose;
        }

        public void setOuverture(double ouverture)
        {
            this.ouverture = ouverture;
        }

        public double getOuverture()
        {
            return ouverture;
        }
    }
}
