using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    class Hero : Character
    {
        public string current_weapon = "bare handed";
        public int current_range = 1;
        public int current_damage = 2;
        public weapon weapon;
        public Hero(int x_coordinate, int y_coordinate, int hp, int damage) : base(x_coordinate, y_coordinate, damage)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            hP = hp;
            MaxHP = hp;
            Damage = damage;
            this.gold = 100;
        }

        public override Movement Returnmove(Movement move = Movement.No_Movement)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "player stats:\n" + "HP:" + HP + "/" + MaxHP + "\n weapon Damage:" + current_damage + "\n[" + X_coordinate + "," + Y_coordinate + "]\n" + "Gold:" + this.gold + "\n Current weapon:" + current_weapon + "\n Weapon Range:" + current_range;
        }
    }
}
