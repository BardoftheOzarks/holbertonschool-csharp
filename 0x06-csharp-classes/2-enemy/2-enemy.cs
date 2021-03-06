using System;

namespace Enemies
{
    /// <summary>An undead enemy.</summary>
    public class Zombie
    {
        /// <summary>How much before it dies...again.</summary>
        public int health;
        /// <summary>Basic Zombie constructor.</summary>
        public Zombie()
        {
            this.health = 0;
        }
        /// <summary>Construct a Zombie with health.</summary>
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}