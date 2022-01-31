using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk1_v._2
{
    [Serializable]
    abstract class Enemy : Character
    {
        Random rnd = new Random();


        public Enemy(int x_coordinate, int y_coordinate, int enemyDamage, string symbol, int startingHP) : base(x_coordinate, y_coordinate, enemyDamage)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            Damage = enemyDamage;
            Symbol = symbol;
            MaxHP = startingHP;

        }

        public override string ToString()
        {
            return "Goblin at [" + X_coordinate + "," + Y_coordinate + Damage + "\n";
        }
    }
}
