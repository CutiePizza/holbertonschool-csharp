using System;

/// <summary>
/// Delegate
/// </summary>
/// <param name="amount"></param>
public delegate void CalculateHealth(float amount);
/// <summary>
/// Calculate Modifier
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Player class
/// </summary>
public class Player
{
    private string name {
        get;
        set;
    }
    private float maxHp {
        get;
        set;
    }

    private float hp {
        get;
        set;
    }

    private string status {
        get;
        set;
    }

    /// <summary>
    /// Event
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;



    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    /// <param name="status"></param>
    public Player(string name="Player", float maxHp=100f, string status="none")
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
        if (status == "none")
            this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;

    }

    
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp >= this.maxHp / 2 && e.currentHp < this.maxHp)
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp)
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.currentHp > 0 && e.currentHp < this.maxHp / 4)
        {
            this.status = $"{this.name} needs help!";
        }
        else if (e.currentHp <= 0)
        {
            this.status = $"{this.name} is knocked out!";
        }
        Console.WriteLine(this.status);
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
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
            ValidateHP(this.hp - damage);
        }
        else
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
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
            ValidateHP(this.hp + heal);
        }
        else
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
    }

    /// <summary>
    /// Sets the new Hp
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            this.hp = 0;
        else if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else
            this.hp = newHp;
        CurrentHPArgs myHp = new CurrentHPArgs(this.hp);
        CheckStatus(HPCheck, myHp);
    }

    /// <summary>
    /// Apply modifier
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return (float)(baseValue / 2);
        else if (modifier == Modifier.Base)
            return (baseValue);
        else
            return (float)(baseValue * 1.5);
    }
}


/// <summary>
/// Class CurrentHPArgs
/// </summary>
public class CurrentHPArgs : EventArgs {

    /// <summary>
    /// CurrentHp
    /// </summary>
    /// <value></value>
    public readonly float currentHp;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }

}

/// <summary>
/// Modified behavior
/// </summary>
public enum Modifier {
    /// <summary>
    /// Modified behavior
    /// </summary>
    Weak,
    /// <summary>
    /// Modified behavior
    /// </summary>
    Base,
    /// <summary>
    /// Modified behavior
    /// </summary>
    Strong
}