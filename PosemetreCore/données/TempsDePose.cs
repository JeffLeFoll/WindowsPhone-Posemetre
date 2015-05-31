using System;
using System.Collections.Generic;
using System.Linq;

namespace PosemètreCore.données
{
    public class TempsDePose
    {
        public static string convertirValeurTempsDePoseEnFraction(double tempsDePose)
        {
            string fraction = "";

            ensembleDesTempsDePose.TryGetValue(tempsDePose, out fraction);

            return fraction;

        }

        public static List<string> récupérerToutesLesFractionsDeTempsDePose()
        {
            List<string> fractions = ensembleDesTempsDePose.Values.ToList();

            return fractions;
        }

        public static List<double> récupérerToutesLesValeuresDeTempsDePose()
        {
            List<double> valeurs = ensembleDesTempsDePose.Keys.ToList();

            return valeurs;
        }

        public static Dictionary<double, string> récupérerTempsDePose()
        {
            return ensembleDesTempsDePose;
        }

        private static readonly Dictionary<double, string> ensembleDesTempsDePose = new Dictionary<double, string>() 
         { 
             {0.00025, "1/4000"},
             {0.0003125,"1/3200"}, 
             {0.0004,"1/2500"}, 
             {0.0005,"1/2000"}, 
             {0.000625,"1/1600"}, 
             {0.0008,"1/1250"},
             {0.001,"1/1000"}, 
             {0.00125,"1/800"}, 
             {0.0015625,"1/640"}, 
             {0.002,"1/500"}, 
             {0.0025,"1/400"}, 
             {0.003125,"1/320"}, 
             {0.004,"1/250"}, 
             {0.005,"1/200"}, 
             {0.00625,"1/160"}, 
             {0.008,"1/125"},
             {0.01,"1/100"},
             {0.0125,"1/80"},
             {0.016666,"1/60"},
             {0.02,"1/50"},
             {0.025,"1/40"}, 
             {0.0333333,"1/30"}, 
             {0.04,"1/25"},
             {0.05,"1/20"},
             {0.066666,"1/15"},
             {0.076923,"1/13"},
             {0.1,"1/10"},
             {0.125,"1/8"},
             {0.166666,"1/6"}, 
             {0.2,"1/5"}, 
             {0.25,"1/4"},
             {0.333333,"1/3"}, 
             {0.4,"1/2.5"}, 
             {0.5,"1/2"}, 
             {0.625,"1/1.6"}, 
             {0.769230,"1/1.3"}, 
             {1.0,"1"}, 
             {1.3,"1.3"}, 
             {1.6,"1.6"}, 
             {2.0,"2"},
             {2.5,"2.5"}, 
             {3.0,"3"}, 
             {4.0,"4"}, 
             {5.0,"5"}, 
             {6.0,"6"}, 
             {8.0,"8"}, 
             {10.0,"10"}, 
             {13.0,"13"}, 
             {15.0,"15"}, 
             {20.0,"20"}, 
             {25.0,"25"}, 
             {30.0,"30"}, 
             {60.0,"60"}

         };
    }
}
