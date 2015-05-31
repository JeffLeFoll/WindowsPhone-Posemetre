using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public interface ModeDeFonctionement
    {
        string fournirUnLibellé { get; }

        bool estDisponible { get; }

        TypeAction aPourAction { get; }
    }
}
