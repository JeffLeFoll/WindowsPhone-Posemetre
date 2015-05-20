using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculIso : ModeDeFonctionement
    {
        public string fournirUnLibellé
        {
            get { return "ISO"; }
        }

        public bool estDisponible
        {
            get { return false; }
        }

        public TypeAction aPourAction
        {
            get { return TypeAction.Iso; }
        }
    }
}
