using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculTempsDePose : ModeDeFonctionement
    {
        public string fournirUnLibellé
        {
            get { return "Temps de pose"; }
        }

        public bool estDisponible
        {
            get { return true; }
        }

        public TypeAction aPourAction
        {
            get { return TypeAction.TempsDePose; }
        }
    }
}
