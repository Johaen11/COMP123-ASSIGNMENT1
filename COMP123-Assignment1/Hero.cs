﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment1
{
    public class Hero
    {
        //Private Instance Variables
         private int _strength;
         private int _speed;
         private int _health;
         private string _name;
        

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }

        }
        /// <summary>
        /// /
        /// </summary>
        public void _generateAbilities()
        {
            Random rnd = new Random();
            _strength = rnd.Next(1, 101);
            _speed = rnd.Next(1,101);
            _health = rnd.Next(1, 101);
        }
        /// <summary>
        /// /
        /// </summary>
        /// <returns></returns>
        private bool _hitAttempt()
        {Random rnd = new Random();
            if (rnd.Next(1, 101) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        private int _hitDamage()
        {
            Random rnd = new Random();

            return rnd.Next(1, 7) * _strength;

            
        }
        /// <summary>
        /// /
        /// </summary>
        public void Fight()
        {
            if (_hitAttempt() == true)
            {
                _hitDamage();
                Console.WriteLine("The Damage hit was {0}", _hitDamage());
            }
            else
                Console.WriteLine("Hit Attempt Failed");
        }
        /// <summary>
        /// 
        /// </summary>
        public void Show()
        {
            Console.WriteLine("Strength: {0}", _strength);
            Console.WriteLine("Health: {0}", _health);
            Console.WriteLine("Speed: {0}", _speed);


        }
        public Hero(string name)
        {
            _name = name;
            _generateAbilities();
        }
    }
}
