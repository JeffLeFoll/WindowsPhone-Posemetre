using System;

namespace PosemètreCore.ModesDeFonctionement
{
    interface ModeDeFonctionement
    {

        String fournirUnLibellé();

        bool estDisponible();

    }
}
