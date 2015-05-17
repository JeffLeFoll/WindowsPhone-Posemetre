using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculIso : ModeDeFonctionement
    {
        public String fournirUnLibellé()
        {
            return "ISO";
        }

        public bool estDisponible()
        {
            return false;
        }

        public TypeAction aPourAction()
        {
            return TypeAction.Iso;
        }
    }
}
