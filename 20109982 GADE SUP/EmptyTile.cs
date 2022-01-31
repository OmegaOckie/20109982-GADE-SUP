using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    class EmptyTile : Tile
    {
        public EmptyTile(int x_coordinate, int y_coordinate) : base(x_coordinate, y_coordinate)
        {

        }

        public override string ToString()
        {
            return " . ";
        }
    }
}
