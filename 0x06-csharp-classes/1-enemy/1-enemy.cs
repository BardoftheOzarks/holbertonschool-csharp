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
    }
}