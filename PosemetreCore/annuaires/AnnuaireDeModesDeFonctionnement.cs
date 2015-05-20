using PosemètreCore.ModesDeFonctionement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosemètreCore.annuaires
{
    public class AnnuaireDeModesDeFonctionnement
    {
        public static readonly List<ModeDeFonctionement> Modes = new List<ModeDeFonctionement> { 
            new ModeCalculIso(),
            new ModeCalculOuverture(),
            new ModeCalculTempsDePose()
        };

    }
}
