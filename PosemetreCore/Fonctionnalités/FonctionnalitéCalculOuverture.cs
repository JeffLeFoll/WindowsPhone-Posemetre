using System;

namespace PosemètreCore.Fonctionnalités
{
    public class FonctionnalitéCalculOuverture : Fonctionnalité
    {
        public String fournirUnLibellé() 
        {
            return "Ouverture";
        }

        public Boolean estDisponible()
        {
            return true;
        }

    }
}
