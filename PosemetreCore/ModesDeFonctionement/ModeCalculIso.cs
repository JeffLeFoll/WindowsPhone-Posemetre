using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

    }
}
