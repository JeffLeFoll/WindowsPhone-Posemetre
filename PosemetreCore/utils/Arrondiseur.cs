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
            Double différenceValeurCourante = Math.Abs(valeureCourante - tempsDePose);
            
            for (int i = 1; i < valeursARapprocher.Count; i++)
            {
                Double différenceValeurARapprocher = Math.Abs(valeursARapprocher[i] - tempsDePose);
                if (différenceValeurARapprocher < différenceValeurCourante)
                {
                    différenceValeurCourante = différenceValeurARapprocher;
                    valeureCourante = valeursARapprocher[i];
                }
            }

            return valeureCourante;
        }

    }
}
