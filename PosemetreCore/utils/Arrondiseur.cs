using PosemètreCore.données;
using System;
using System.Collections.Generic;

namespace PosemètreCore.utils
{
    public class Arrondiseur
    {
        public static double arrondire(double tempsDePose, List<double> valeursARapprocher)
        {
            Double valeureCourante = valeursARapprocher[0];
            Double difference = Math.Abs(valeureCourante - tempsDePose);
            
            for (int i = 1; i < valeursARapprocher.Count; i++)
            {
                Double diff = Math.Abs(valeursARapprocher[i] - tempsDePose);
                if (diff < difference)
                {
                    difference = diff;
                    valeureCourante = valeursARapprocher[i];
                }
            }

            return valeureCourante;
        }

    }
}
