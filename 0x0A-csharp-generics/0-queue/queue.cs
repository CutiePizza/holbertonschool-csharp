using System;
/// <summary>
/// QUeue Class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    /// <summary>
    /// Check Type of a queue
    /// </summary>
    /// <returns>Type of a Queue</returns>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}
