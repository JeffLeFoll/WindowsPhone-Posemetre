using PosemètreCore.données;

namespace PosemètreCore.actions
{
    public interface ActionDeCalcul
    {
        TypeAction indiqueLeTypeDeLAction();

        Posemètre mettreAJourLePosemètre(Posemètre posemètre);

    }
}
