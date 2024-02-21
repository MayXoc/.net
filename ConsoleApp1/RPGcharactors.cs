using System;

namespace Coding.Exercise
{
    public class RPGCharacter
    {
        public string Name { get; set; }
        public int? HP { get; set; }

        public RPGCharacter(string name, int? hp)
        {
            // Defensive programming to make sure name comes in correctly.
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Character name cannot be null or empty.", nameof(name));
            }

            Name = name;
            // If HP does not come in from the user then we set it as 100 by default via null coalescing. (Lesson: Null & Null Coalescing)
            HP = hp ?? 100;
        }

        public void Attack(RPGCharacter other, int damage)
        {
            other.HP -= damage;
        }

        // Using out variables. (Lesson: Out Variables)
        public bool IsAlive(out string message)
        {
            if (HP <= 0)
            {
                message = $"{Name} is dead!";
                return false;
            }
            else
            {
                message = $"{Name} is alive!";
                return true;
            }
        }
    }
}