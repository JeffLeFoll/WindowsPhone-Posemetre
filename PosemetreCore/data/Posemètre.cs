
namespace PosemètreCore.data
{
    public enum ModeDuPosemètre
    {
        TempsDePose,
        Iso,
        Ouverture
    }

    public class Posemètre
    {
        public static readonly double CONSTANTE_ETALONNAGE = 255;

        private double éclairementLumineux;
        private double iso;
        private double tempsDExposition;
        private double ouverture;

        private ModeDuPosemètre modeDUtilisation;

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

        public void setTempsDExposition(double tempsDExposition)
        {
            this.tempsDExposition = tempsDExposition;
        }

        public double getTempsDExposition()
        {
            return tempsDExposition;
        }

        public void setOuverture(double ouverture)
        {
            this.ouverture = ouverture;
        }

        public double getOuverture()
        {
            return ouverture;
        }

        public void setModeDUtilisation(ModeDuPosemètre mode)
        {
            modeDUtilisation = mode;
        }

        public ModeDuPosemètre getModeUtilisation()
        {
            return modeDUtilisation;
        }
    }
}
