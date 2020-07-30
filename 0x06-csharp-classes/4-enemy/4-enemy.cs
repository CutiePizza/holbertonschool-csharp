 using System;

namespace Enemies
{
    /// <summary>
    /// Represents a class of Zombie
    ///</summary>
    public class Zombie
    {
        // Health of a zombie
        private int health;
        // Name of a Zombie
        private string name;
        /// <summary>
        /// Property Name
        /// </summary>
        /// <value>get or set a Name</value>
        public string Name {get; set;} = "(No name)";
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
        /// <summary>
        /// Gets the health of a zombie
        /// </summary>
        /// <returns>an integer</returns>
        public int GetHealth()
        {
            return (this.health);
        }
    }
}
