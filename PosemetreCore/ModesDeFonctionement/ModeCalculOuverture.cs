using PosemètreCore.actions;
using System;

namespace PosemètreCore.ModesDeFonctionement
{
    public class ModeCalculOuverture : ModeDeFonctionement
    {
        public String fournirUnLibellé() 
        {
            return "Ouverture";
        }

        public bool estDisponible()
        {
            return true;
        }

        public TypeAction aPourAction()
        {
            return TypeAction.Ouverture;
        }

    }
}
