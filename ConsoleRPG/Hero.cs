using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Hero : Person
    {
        public int healLvl = 7, maxHealth = 15;

        public Hero(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        public void LevelUp()
        {
            Console.WriteLine("Você subiu de nível!");
            Console.WriteLine("Ataque incrementado para +3");
            Console.WriteLine("Vida máxima incrementada para +10");
            Console.WriteLine("Você se curou em +5");
            Console.ReadLine();
            Console.Clear();

            attack += 3;
            maxHealth += 10;
            health = maxHealth;
            healLvl += 5;
        }

        // Special -------------------------------------------

        public void Heal()
        {
            health += healLvl;

            if (health > maxHealth)
            {
                health = maxHealth;
            }
        }

        public void FastAttack(Enemy target)
        {
            target.health -= ((attack - 2) * 3);
        }

        public void DoubleStrike(Enemy target)
        {
            target.health -= attack * 2;
        }

        // Methods used in Battle ----------------------------------------

        public int Choice() // Produces heros decision
        {
            bool correctInput = true;
            int choice = 0, choice2;
            while (correctInput)
            {
                Console.WriteLine("O quê voce gostaria de fazer agora?");
                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Curar");
                Console.WriteLine("3. Especial");

                bool test = int.TryParse(Console.ReadLine(), out choice);
                if (!test || choice > 3 || choice <= 0)
                {
                    Console.WriteLine("Essa não é uma das opções! Tente novamente!");
                    Console.ReadLine();
                    Console.Clear();
                    continue;
                }

                if (choice == 3) // Specials menu
                {
                    Console.WriteLine("Escolha o especial:");
                    Console.WriteLine("1. Ataque rápido");
                    Console.WriteLine("2. Golpe duplo");
                    Console.WriteLine("3. <--- Voltar");

                    bool test2 = int.TryParse(Console.ReadLine(), out choice2);
                    if (!test2 || choice2 > 3 || choice2 <= 0)
                    {
                        Console.WriteLine("Essa não é uma das opções! Tente novamente!");
                        Console.ReadLine();
                        Console.Clear();
                        continue;
                    }

                    if (choice2 == 1)
                    {
                        choice = 4;
                    }

                    if (choice2 == 2)
                    {
                        choice = 5;
                    }
                }

                if (choice == 1 || choice == 2 || choice == 4 || choice == 5)
                {
                    break;
                }
            }
            return choice;
        }

        public void YourTurn(int decision, Enemy target)
        {
            if (decision == 1)
            {
                NormAttack(target);
                Console.WriteLine("Você chutou o inimigo!");
            }

            if (decision == 2)
            {
                Heal();
                Console.WriteLine("Você curou {0} de vida!", healLvl);
            }

            if (decision == 4)
            {
                FastAttack(target);
                Console.WriteLine("Você usou um ataque rápido!");
            }

            if (decision == 5)
            {
                DoubleStrike(target);
                Console.WriteLine("Você deu um golpe duplo!");
            }

        }
    }
}
