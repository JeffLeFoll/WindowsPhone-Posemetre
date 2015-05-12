using System;
using System.Collections.Generic;

namespace PosemètreCore.données
{
    public class ArrondiseurTempsDePose
    {

        public static double arrondire(double tempsDePose)
        {
            List<double> ensembleDesTempsDePose = TempsDePose.récupérerToutesLesValeuresDeTempsDePose();

            Double valeureCourante = ensembleDesTempsDePose[0];
            Double difference = Math.Abs(valeureCourante - tempsDePose);


            for (int i = 1; i < ensembleDesTempsDePose.Count; i++)
            {
                Double diff = Math.Abs(ensembleDesTempsDePose[i] - tempsDePose);
                if (diff < difference)
                {
                    difference = diff;
                    valeureCourante = ensembleDesTempsDePose[i];
                }
            }

            return valeureCourante;
        }

    }
}
