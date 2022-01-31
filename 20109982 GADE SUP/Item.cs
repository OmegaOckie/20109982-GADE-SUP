using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    abstract class Item : Tile
    {
        private int goldworth;

        public Item(int X_coordinate, int Y_coordinate) : base(X_coordinate, Y_coordinate)
        {
            X_coordinate = x_coordinate;
            Y_coordinate = y_coordinate;


        }

        public int Goldworth { get => goldworth; set => goldworth = value; }

        public abstract override string ToString();
    }
}
