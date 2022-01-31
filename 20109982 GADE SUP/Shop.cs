using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    class Shop : Tile
    {
        private weapon[] weaponarray;
        private Random random;
        private Character buyer;

        public Shop(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate)
        {
            Weaponarray = new weapon[3];
            random = new Random();
            for (int i = 0; i < 3; i++)
            {
                Random_weapon(i);
            }



        }

        public void newitem(int i)
        {
            int weapon = random.Next(0, 3);
            if (weapon == 0)
            {
                Weaponarray[i] = new Melee_weapon(500, 500, 'D', Melee_weapon.Type.Dagger);
            }
            else if (weapon == 1)
            {
                Weaponarray[i] = new Melee_weapon(500, 500, 'L', Melee_weapon.Type.Longsword);
            }
            else if (weapon == 2)
            {
                Weaponarray[i] = new Ranged_weapon(500, 500, 'R', Ranged_weapon.Type.Rifle);
            }
            else
            {
                Weaponarray[i] = new Ranged_weapon(500, 500, 'B', Ranged_weapon.Type.Longbow);
            }

        }
        private void Random_weapon(int arrayorder)
        {
            int weapon = random.Next(0, 3);
            if (weapon == 0)
            {
                Weaponarray[arrayorder] = new Melee_weapon(500, 500, 'D', Melee_weapon.Type.Dagger);
            }
            else if (weapon == 1)
            {
                Weaponarray[arrayorder] = new Melee_weapon(500, 500, 'L', Melee_weapon.Type.Longsword);
            }
            else if (weapon == 2)
            {
                Weaponarray[arrayorder] = new Ranged_weapon(500, 500, 'R', Ranged_weapon.Type.Rifle);
            }
            else
            {
                Weaponarray[arrayorder] = new Ranged_weapon(500, 500, 'B', Ranged_weapon.Type.Longbow);
            }

        }
        public bool CanBuy(int num)
        {
            if (buyer.Gold >= Weaponarray[0].Cost)
            {
                return true;
            }
            else if (buyer.Gold >= Weaponarray[1].Cost)
            {
                return true;
            }
            else if (buyer.Gold >= Weaponarray[2].Cost)
            {
                return true;
            }
            else
            {
                return false;
            }



        }
        public void Buy(int num)
        {


        }

        internal Character Buyer { get => buyer; set => buyer = value; }
        public weapon[] Weaponarray { get => weaponarray; set => weaponarray = value; }

        public override string ToString()
        {
            return " S";
        }
    }
}
