using PosemètreCore.utils;
using PosemètreCore.données;
using System.Collections.Generic;

namespace PosemètreCore.actions
{
    public class TypeAction
    {
        public static TypeAction Ouverture = new TypeAction("Ouverture");
        public static TypeAction Iso = new TypeAction("ISO");
        public static TypeAction TempsDePose = new TypeAction("Temps de pose");

        public static readonly List<TypeAction> typesDActionDisponibles = new List<TypeAction> { TypeAction.Ouverture, TypeAction.Iso, TypeAction.TempsDePose };

        private string libellé;

        private TypeAction(string libellé)
        {
            this.libellé = libellé;
        }

        public string getLibellé() 
        {
            return this.libellé;
        }
    }

}
