using System;

namespace Enemies
{
    public class Zombie
    {
        private int health;
        public Zombie()
        {
            this.health = 0;
        }
        public Zombie(int value)
        {
            if (value >= 0)
                this.health = value;
            else
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
        private string name = "(No name)";
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int GetHealth()
        {
            return this.health;
        }
        public override string ToString()
        {
            return $"Zombie Name: {this.name} / Total Health: {this.health}";
        }
    }
}