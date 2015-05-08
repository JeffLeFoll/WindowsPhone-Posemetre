using System;

namespace PosemètreCore.capteurs
{
    public interface Capteur
    {
        bool estPrésentSurLeDevice();

        double lireMesureDuCapteur();
    }
}
