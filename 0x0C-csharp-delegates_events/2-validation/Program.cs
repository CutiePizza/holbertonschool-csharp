﻿using System;
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
        CalculateHealth handler = ValidateHP;
        if (damage > 0)
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
            handler(this.hp - damage);
        }
        else
        {
            Console.WriteLine($"{this.name} takes 0 damage!");
            handler(0);
        }
    }

    /// <summary>
    /// HealDamage method
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        CalculateHealth handler = ValidateHP;
        if (heal > 0)
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
            handler(this.hp + heal);
        }
        else
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
            handler(0);
        }
    }

    /// <summary>
    /// Sets the new Hp
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp > this.maxHp)
            this.hp = this.maxHp;
        else if (newHp < 0)
            this.hp = 0;
        else
            this.hp = newHp;
    }
}
/// <summary>
/// Delegate
/// </summary>
/// <param name="amount"></param>
public delegate void CalculateHealth(float amount);

