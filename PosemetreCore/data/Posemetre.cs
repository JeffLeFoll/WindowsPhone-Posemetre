using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        public static readonly double C = 255;

        private double constanteE;
        private double constanteS;
        private double constanteT;
        private double constanteN;

        private ModeDuPosemetre modeDUtilisation;

        public void setE(double E)
        {
            constanteE=E;
        }

        public double getE() {
            return constanteE;
        }

        public void setS(double S)
        {
            constanteS=S;
        }

        public double getS()
        {
            return constanteS;
        }

        public void setT(double t)
        {
            constanteT=t;
        }

        public double getT()
        {
            return constanteT;
        }

        public void setN(double N)
        {
            constanteN=N;
        }

        public double getN()
        {
            return constanteN;
        }

        public void setModeDUtilisation(ModeDuPosemetre mode) {
            modeDUtilisation = mode;
        }

        public ModeDuPosemetre getModeUtilisation()
        {
            return modeDUtilisation;
        }
    }
}
