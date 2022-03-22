using System;

class Player
{
    private string name;
    private float maxHp;
    public float hp;

    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        } else {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    public delegate void CalculateHealth(float amount);

    public void TakeDamage(float damage)
    {
        if (damage <= 0)
            Console.WriteLine($"{this.name} takes 0 damage!");
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
            this.hp -= damage;
        }
        ValidateHP(this.hp);
    }
    public void HealDamage(float heal)
    {
        if (heal <= 0)
            Console.WriteLine($"{this.name} heals 0 HP!");
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
            this.hp += heal;
        }
        ValidateHP(this.hp);
    }
    
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = maxHp;
        else
            this.hp = newHp;
    }
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        return (baseValue * ((int)modifier * 0.5f));
    }
}

///<summary>Modifier to apply</summary>
public enum Modifier
{
    ///<summary> weak modifier </summary>
    Weak=1,
    ///<summary> base modifier </summary>
    Base,
    ///<summary> strong modifier </summary>
    Strong
}

///<summary> modifiers for health adjustment </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);