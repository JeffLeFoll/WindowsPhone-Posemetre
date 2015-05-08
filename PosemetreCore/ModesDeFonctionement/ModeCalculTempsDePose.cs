using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculTempsDePose : ModeDeFonctionement
    {
        public String fournirUnLibellé()
        {
            return "Temps de pose";
        }

        public bool estDisponible()
        {
            return true;
        }

        public TypeAction aPourAction()
        {
            return TypeAction.TempsDePose;
        }
    }
}
