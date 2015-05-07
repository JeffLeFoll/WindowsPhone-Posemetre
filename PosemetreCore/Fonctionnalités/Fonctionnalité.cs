using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosemètreCore.Fonctionnalités
{
    interface Fonctionnalité
    {

        String fournirUnLibellé();

        Boolean estDisponible();

    }
}
