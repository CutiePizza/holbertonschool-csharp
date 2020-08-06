using System;

/// <summary>
/// Class that represents an object
/// </summary>
    class Obj
    {
        /// <summary>
        /// Checks if the obj is an instance of Array
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true or false</returns>
        public static bool IsInstanceOfArray(object obj)
        {
            if (obj is Array || obj.GetType() == typeof(Array))
                return (true);
            else
                return (false);
        }
    }
