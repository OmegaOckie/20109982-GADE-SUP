using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    abstract class weapon : Item
    {

        private int damage;
        private int range;
        private int durability;
        private int cost;
        private string weapon_type;
        private Char symbol;

        public weapon(int X_coordinate, int Y_coordinate, char Symbol) : base(X_coordinate, Y_coordinate)
        {
            symbol = Symbol;
        }

        public int Damage { get => damage; set => damage = value; }

        public int Durability { get => durability; set => durability = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Weapon_type { get => weapon_type; set => weapon_type = value; }
        public int Range { get => range; set => range = value; }

    }
}
