using System;
/// <summary>
/// Player class
/// </summary>
public class Player
{
    /// <summary>
    /// Name of the player
    /// </summary>
    /// <value></value>
    private string name {
        get;
        set;
    }
    /// <summary>
    /// Max Health Points of player
    /// </summary>
    /// <value></value>
    private float maxHp {
        get;
        set;
    }
    /// <summary>
    /// Actual health
    /// </summary>
    /// <value></value>
    private float hp {
        get;
        set;
    }
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name="Player", float maxHp=100f)
    {
        if (maxHp > 0f)
            this.maxHp = maxHp;
        else
        { 
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.name = name;
        this.hp = this.maxHp;

    }

    /// <summary>
    /// Print Player's health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// TakeDamage method
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage > 0)
            Console.WriteLine($"{this.name} takes {damage} damage!");
        else
            Console.WriteLine($"{this.name} takes 0 damage!");
    }

    /// <summary>
    /// HealDamage method
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal > 0)
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
        else
            Console.WriteLine($"{this.name} takes 0 heals!");
    }

}
/// <summary>
/// Delegate
/// </summary>
/// <param name="amount"></param>
public delegate void CalculateHealth(float amount);

