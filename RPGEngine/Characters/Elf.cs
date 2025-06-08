using RPGEngine.Items;

namespace RPGEngine.Characters;

public class Elf(IItem item) : ICharacter
{
    private readonly IItem _item = item;

    public string Attack()
    {
        return "Legolas " + _item.Use();
    }
}
