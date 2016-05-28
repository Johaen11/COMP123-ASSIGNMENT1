using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Assignment1
{
    class Hero
    {
        //Private Instance Variables
         private int _strength;
         private int _speed;
         private int _health;
         private string _name;
        
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

        private void _generateAbilities()
        {
            Random rnd = new Random();
            _strength = rnd.Next(1, 101);
            _speed = rnd.Next(1,101);
            _health = rnd.Next(1, 101);
        }

        private bool _hitAttempt()
        {
            return;
        }

        private int _hitDamage()
        {

            return;
        }

        public void Fight()
        {

        }

        public void Show()
        {

        }
        public void Constructor(string name)
        {
            _name = name;
            _generateAbilities();
        }
    }
}
