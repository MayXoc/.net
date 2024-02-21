using System;
using System.Collections.Generic;

namespace Coding.Exercise
{
    public class RPGSimulator
    {
        private RPGCharacter Hero { get; set; }
        private List<RPGCharacter> Enemies { get; set; }

        public RPGSimulator(RPGCharacter hero, List<RPGCharacter> enemies)
        {
            Hero = hero;
            Enemies = enemies;
        }

        // Create a method within the simulator class that puts all together. (Lesson: Methods)
        public void StartGame()
        {
            // Going through all enemies via foreach loop.
            foreach (var enemy in Enemies)
            {
                string enemyMessage = string.Empty;

                // Since we are not sure when battle will end we use while loop.
                // Using an out parameter to pass via reference. (Lessons: Out vs Ref Parameters, Out Variable)
                while (enemy.IsAlive(out enemyMessage))
                {
                    enemy.Attack(Hero, 10);

                    if (!Hero.IsAlive(out string heroMessage))
                    {
                        Console.WriteLine(heroMessage);
                        return;
                    }

                    Hero.Attack(enemy, 10);
                }

                Console.WriteLine(enemyMessage);
            }

            Console.WriteLine($"{Hero.Name} has defended all enemies!");
        }
    }
}
