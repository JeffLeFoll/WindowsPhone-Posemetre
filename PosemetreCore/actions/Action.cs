using PosemètreCore.données;

namespace PosemètreCore.actions
{
    interface Action
    {
        TypeAction indiqueLeTypeDeLAction();

        double calculer(Posemètre posemètre);

    }
}
