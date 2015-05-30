using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosemètreCore.données
{
    public class Ouverture
    {
        private static readonly List<double> ouvertureEnTierDeStop = new List<double> { 0.7, 0.8, 0.9, 1.0, 1.1, 1.2, 1.4, 1.6, 1.8, 2, 2.2, 2.5, 2.8, 3.2, 3.5, 4, 4.5, 5.0, 5.6, 6.3, 7.1, 8, 9, 10, 11, 13, 14, 16, 18, 20, 22 };

        public static List<double> récupérerLesValeuresDOuverture()
        {
            return ouvertureEnTierDeStop;
        }
    }
}
