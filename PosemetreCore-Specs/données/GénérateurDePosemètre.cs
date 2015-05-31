using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosemètreCore.données
{
    public class GénérateurDePosemètre
    {
        public static Posemètre générerUnPosemètre(double E, double S, double t, double N)
        {
            // E = illuminance en lux
            // S = vitesse iso
            // t = TempsDePose
            // N =  ouverture
            Posemètre posemètre = new Posemètre();

            posemètre.setEclairementLumineux(E);
            posemètre.setISO(S);
            posemètre.setTempsDePose(t);
            posemètre.setOuverture(N);

            return posemètre;
        }
    }
}
