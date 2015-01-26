using System;
using System.Collections.Generic;
using System.Text;
using PosemetreCore.data;

namespace Posemetre_mobile
{
    class ContoleurCommun
    {

        public Array initComboBox() {
            return Enum.GetValues(typeof(ModeDuPosemetre));
        }

    }
}
