using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public interface ModeDeFonctionement
    {

        String fournirUnLibellé();

        bool estDisponible();

        TypeAction aPourAction();

    }
}
