public class Character
{
    public int hp;
    public string name;
    public Inventory Backpack = new();

    public Character()
    {

        Backpack.Items.Add(new Weapon() { minDamage = 2, maxDamage = 10, name = "Axe", weight = 10f });
        Backpack.Items.Add(new Consumable() { name = "Health potion", usesMax = 25, weight = 2f });

        name = "";
        hp = 100;
    }
}
