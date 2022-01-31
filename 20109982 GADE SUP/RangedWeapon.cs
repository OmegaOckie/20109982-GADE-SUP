using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    class Ranged_weapon : weapon
    {
        public Type type;
        public enum Type
        {
            Rifle, Longbow
        }
        public Ranged_weapon(int X_coordinate, int Y_coordinate, char Symbol, Type weapon_type) : base(X_coordinate, Y_coordinate, Symbol)
        {
            if (weapon_type == Type.Rifle)
            {
                Weapon_type = "Rifle";
                Durability = 3;
                Damage = 5;
                Cost = 7;
                Range = 3;

            }
            else if (weapon_type == Type.Longbow)
            {
                Weapon_type = "Longbow";
                Durability = 4;
                Damage = 4;
                Cost = 6;
                Range = 2;

            }


        }


        public override string ToString()
        {
            if (type == Type.Longbow)
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
