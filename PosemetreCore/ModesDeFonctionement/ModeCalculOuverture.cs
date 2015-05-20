using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculOuverture : ModeDeFonctionement
    {
        public string fournirUnLibellé
        {
            get { return "Ouverture"; }
        }

        public bool estDisponible
        {
            get {return true; }
        }

        public TypeAction aPourAction
        {
            get { return TypeAction.Ouverture; }
        }
    }
}
