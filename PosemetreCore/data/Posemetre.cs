
namespace PosemetreCore.data
{
    public enum ModeDuPosemetre
    {
        TempsDePose,
        Iso,
        Ouverture
    }

    public class Posemetre
    {
        public static readonly double CONSTANTE_ETALONNAGE = 255;

        private double eclairementLumineux;
        private double iso;
        private double tempsDExposition;
        private double ouverture;

        private ModeDuPosemetre modeDUtilisation;

        public void setEclairementLumineux(double eclairementLumineux)
        {
            this.eclairementLumineux = eclairementLumineux;
        }

        public double getEclairementLumineux()
        {
            return eclairementLumineux;
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

        public void setModeDUtilisation(ModeDuPosemetre mode)
        {
            modeDUtilisation = mode;
        }

        public ModeDuPosemetre getModeUtilisation()
        {
            return modeDUtilisation;
        }
    }
}
