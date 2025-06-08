using RPGEngine.Items;

namespace RPGEngine.Characters;

public class Mage(IItem item) : ICharacter
{
    private readonly IItem _item = item;

    public string Attack()
    {
        return "Merlin " + _item.Use();
    }
}
