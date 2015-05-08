using PosemètreCore.actions;
using System.Collections.Generic;

namespace PosemètreCore.commandes
{
    public class AnnuaireDActions
    {
        private static Dictionary<TypeAction, ActionDeCalcul> annuaire = new Dictionary<TypeAction, ActionDeCalcul>() 
        { 
            {TypeAction.Ouverture, new ActionCalculOuverture()},
            {TypeAction.TempsDePose, new ActionCalculTempsDePose()},
            {TypeAction.Iso, new ActionCalculIso()},
        };

        public static ActionDeCalcul fournirLActionDeType(TypeAction typeDActionVoulu)
        {
            ActionDeCalcul actionVoulu;
            annuaire.TryGetValue(typeDActionVoulu, out actionVoulu);

            return actionVoulu;
        }

    }
}
