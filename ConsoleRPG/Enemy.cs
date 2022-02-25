using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Enemy : Person
    {
        public int numOfAttack;

        public Enemy(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
        }

        // Battle methods -----------------------------------------

        public int EChoice()
        {
            int eChoice;
            Random ran = new Random();
            eChoice = ran.Next(1, numOfAttack + 1);
            return eChoice;
        }
    }

    public class Bandit : Enemy
    {
        public Bandit(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 2;
        }

        //  Battle methods ---------------------------------------------

        public void Steal(Hero target)
        {
            target.health -= attack + 2;
        }

        public void BanditTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Bandido te acertou!");

            }

            if (choice == 2)
            {
                Steal(target);
                Console.WriteLine("Bandido roubou um pouco da sua vida!");

            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Knight : Enemy
    {
        public Knight(string _name, int _attack, int _health)
            : base(_name, _attack, _health)
        {
            numOfAttack = 3;
        }

        // Battle methods -------------------------------------------

        public void Slash(Hero target)
        {
            target.health -= attack + 5;
        }

        public void Shield(Hero target)
        {
            target.health -= attack + 2;
        }

        public void KnightTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Cavaleiro deu um soco em você!");
            }

            if (choice == 2)
            {
                Slash(target);
                Console.WriteLine("Cavaleiro cortou você!");
            }

            if (choice == 3)
            {
                Shield(target);
                Console.WriteLine("Cavaleiro bateu em você com seu escudo!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public class Dragon : Enemy
    {
        public int armor;

        public Dragon(string _name, int _attack, int _health, int _armor)
            : base(_name, _attack, _health)
        {
            numOfAttack = 4;
            armor = _armor;
        }

        // Battle methods ------------------------------------------------------------

        public void FireBreath(Hero target)
        {
            target.health -= attack * 2;
        }

        public void Claw(Hero target)
        {
            target.health -= attack + 3;
        }

        public void Bite(Hero target)
        {
            target.health -= attack + 4;
        }

        public void DragonTurn(int choice, Hero target)
        {
            if (choice == 1)
            {
                NormAttack(target);
                Console.WriteLine("Dragão cuspiu em você!");
            }

            if (choice == 2)
            {
                FireBreath(target);
                Console.WriteLine("Dragão cuspiu fogo em você!");
            }

            if (choice == 3)
            {
                Claw(target);
                Console.WriteLine("Dragão arranhou você!");
            }

            if (choice == 4)
            {
                Bite(target);
                Console.WriteLine("Dragon mordeu você!");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
