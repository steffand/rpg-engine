using RPGEngine.Items;

namespace RPGEngine.Characters;

public class Paladin(IItem item) : ICharacter
{
    private readonly IItem _item = item;

    public string Attack()
    {
        return "Conan " + _item.Use();
    }
}
