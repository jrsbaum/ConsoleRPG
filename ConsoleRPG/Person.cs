﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Person
    {
        public string name;
        public int attack;
        public int health;

        public Person(string _name, int _attack, int _health)
        {
            name = _name;
            attack = _attack;
            health = _health;
        }

        public void PrintStats()
        {
            Console.WriteLine("{0} status:", name);
            Console.WriteLine("");
            Console.WriteLine("Ataque: {0}", attack);
            Console.WriteLine("Vida: {0}", health);
        }

        public void NormAttack(Person target)
        {
            Random r = new Random();
            int randomDamage = r.Next(1, 11);
            Console.WriteLine("random dmg: " + randomDamage);
            target.health -= attack + randomDamage;
            if (randomDamage >= 7)
            {
                Console.WriteLine("Uau! Você causou um dano crítico!");
            }
        }
    }
}
