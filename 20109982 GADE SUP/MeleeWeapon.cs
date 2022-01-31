using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    class Melee_weapon : weapon
    {
        public Type type;
        public enum Type
        {
            Dagger, Longsword
        }
        public Melee_weapon(int X_coordinate, int Y_coordinate, char Symbol, Type weapon_type) : base(X_coordinate, Y_coordinate, Symbol)
        {
            type = weapon_type;
            if (weapon_type == Type.Dagger)
            {
                Weapon_type = "Dagger";
                Durability = 10;
                Damage = 3;
                Cost = 3;
                Range = 1;

            }
            else if (weapon_type == Type.Longsword)
            {
                Weapon_type = "Longsword";
                Durability = 6;
                Damage = 4;
                Cost = 5;
                Range = 1;

            }


        }


        public override string ToString()
        {
            if (type == Type.Dagger)
            {
                return "\n" + type + " \n durability:" + Durability + "\n Damge:" + Damage + "\n price:" + Cost + "\n range" + Range;
            }
            else
            {
                return "\n" + type + " \n durability:" + Durability + "\n Damge:" + Damage + "\n price:" + Cost + "\n range" + Range;
            }
        }

    }
}
