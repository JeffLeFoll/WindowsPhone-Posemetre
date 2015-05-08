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

    }
}
