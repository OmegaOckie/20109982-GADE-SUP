using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    class Leader : Enemy
    {
        public Leader(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate, 2, " L", 20)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            this.HP = 20;
            this.Damage = 2;
            this.gold = 2;
            Weapon = new Melee_weapon(this.x_coordinate, this.y_coordinate, 'S', Melee_weapon.Type.Longsword);

        }

        public override Movement Returnmove(Movement move = Movement.No_Movement)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Equipped: leader at [" + X_coordinate + "," + Y_coordinate + "]" + "HP:" + this.HP + "with(" + Weapon.Durability + "DURx" + Weapon.Damage + "DMG)";
        }
    }
}
