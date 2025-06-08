using System;
using RPGEngine.Characters;
using RPGEngine.Items;

ICharacter paladinSword = new Paladin(new Sword());
ICharacter elfBow = new Elf(new Bow());
ICharacter mageSpell = new Mage(new Spell());

ICharacter paladinBow = new Paladin(new Bow());
ICharacter elfSpell = new Elf(new Spell());
ICharacter mageSword = new Mage(new Sword());

Console.WriteLine(paladinSword.Attack());
Console.WriteLine(elfBow.Attack());
Console.WriteLine(mageSpell.Attack());
Console.WriteLine(paladinBow.Attack());
Console.WriteLine(elfSpell.Attack());
Console.WriteLine(mageSword.Attack());

Console.WriteLine("\nChoose a character (1: Paladin, 2: Elf, 3: Mage):");
int p = int.Parse(Console.ReadLine() ?? "1");

Console.WriteLine("Choose an item (1: Sword, 2: Bow, 3: Spell):");
int i = int.Parse(Console.ReadLine() ?? "1");

IItem userItem = i switch
{
    1 => new Sword(),
    2 => new Bow(),
    3 => new Spell(),
    _ => new Sword()
};

ICharacter userCharacter = p switch
{
    1 => new Paladin(userItem),
    2 => new Elf(userItem),
    3 => new Mage(userItem),
    _ => new Paladin(userItem)
};

Console.WriteLine(userCharacter.Attack());

Console.WriteLine("\nPress any key to exit.");
Console.ReadKey();