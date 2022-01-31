using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP

{
    [Serializable]
    class Goblin : Enemy
    {

        public Goblin(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate, 1, " G", 10)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;
            this.HP = 10;
            Weapon = new Melee_weapon(X_coordinate, Y_coordinate, 'D', Melee_weapon.Type.Dagger);
            this.Damage = Weapon.Damage;
            this.range = Weapon.Range;
            this.gold = 1;
        }

        public override Movement Returnmove(Movement move = Movement.No_Movement)
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return "Equipped: Goblin at [" + X_coordinate + "," + Y_coordinate + "]" + "HP:" + this.HP + "with Dagger(" + Weapon.Durability + "DURx" + Weapon.Damage + "DMG)";
        }

    }
}
