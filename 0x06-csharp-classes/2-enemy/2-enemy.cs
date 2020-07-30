using System;

namespace Enemies
{
    /// <summary>
    /// Represents a class of Zombie
    ///</summary>
    public class Zombie
    {
        /// <summary> 
        /// Health of a zombie
        /// </summary>
        public int health;
        /// <summary> Initializes a new instance of a Zombie </summary> ///
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary> Initializes a new instance of a Zombie with a given health value</summary> ///
        public Zombie(int value)
        {
            if (value < 0)
                throw new System.ArgumentException("Health must be greater than or equal to 0");
            else
                this.health = value;
        }
    }
}