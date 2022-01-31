using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    abstract class Tile
    {

        protected int x_coordinate;

        protected int y_coordinate;

        public int X_coordinate { get => x_coordinate; set => x_coordinate = value; }
        public int Y_coordinate { get => y_coordinate; set => y_coordinate = value; }

        public enum TileType
        {
            HERO, ENEMY, GOLD, WEAPON, SHOP
        }

        public Tile(int x_coordinate, int y_coordinate)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;

        }




    }
}
