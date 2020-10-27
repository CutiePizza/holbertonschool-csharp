using System;
/// <summary>
/// Base class
/// </summary>
class Base
{
    /// <summary>
    /// Property name
    /// </summary>
    /// <value>String value</value>
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
