using System;
/// <summary>
/// Base class
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Name property
    /// </summary>
    /// <value>string value</value>
    public string name {
        get;
        set;
    }
    /// <summary>
    /// Override tostring() method
    /// </summary>
    /// <returns>string</returns>

    public override string ToString()
    {
        return ($"{this.name} is a {this.GetType()}");
    }
}

/// <summary>
/// Ineterface Interactive
/// </summary>
public interface IInteractive {
    /// <summary>
    /// Intercat method
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface Breakable
/// </summary>
public interface IBreakable {
    /// <summary>
    /// durability integer
    /// </summary>
    /// <value>int value</value>
    int durability {
        get;
        set;
    }
    /// <summary>
    /// break method
    /// </summary>
    void Break();   
}

/// <summary>
/// Interface Collectable
/// </summary>
public interface ICollectable {
    /// <summary>
    /// isCOllected property
    /// </summary>
    /// <value>Bool value</value>
    bool isCollected {
        get;
        set;
    }
    /// <summary>
    /// Collect method
    /// </summary>
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
public class Door : Base, IInteractive {

    /// <summary>
    /// Constructor for Door
    /// </summary>
    /// <param name="name">Door name</param>
    public Door(string name)
    {
        if (name == null)
            this.name = "Door";
        else
            this.name = name;
    }

    /// <summary>
    /// Interact implementation
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }

}