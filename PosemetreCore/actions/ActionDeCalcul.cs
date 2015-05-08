using PosemètreCore.données;

namespace PosemètreCore.actions
{
    public interface ActionDeCalcul
    {
        TypeAction indiqueLeTypeDeLAction();

        double calculer(Posemètre posemètre);

    }
}
