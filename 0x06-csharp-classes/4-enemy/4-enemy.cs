using System;

namespace Enemies
{
    /// <summary>An undead enemy.</summary>
    public class Zombie
    {
        /// <summary>How much before it dies...again.</summary>
        private int health;
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
        /// <summary>Even dead guys gots names.</summary>
        private string name = "(No name)";
        /// <summary>In case he forgets or wants to change it.</summary>
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        /// <summary>Get how much health he got.</summary>
        public int GetHealth()
        {
            return this.health;
        }
    }
}