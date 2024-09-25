using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    abstract internal class Enemy
    {
        string _name;
        float _health;
        float defense;

        public Enemy()
        {
            _name = "Reptile";
            _health = 5;
            
        }

        public Enemy(string name, float health)
        {
            _name = name;
            _health = health;
        }
    }
}
