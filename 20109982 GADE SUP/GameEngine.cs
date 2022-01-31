using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_GADE_SUP
{
    [Serializable]
    class GamEngine
    {
        private Map map;

        public GamEngine(Map Map)
        {
            this.map = Map;

        }






        public bool MovePlayer(Character.Movement move)
        {
            if (move == 0)
            {

            }
            return true;
        }
    }
}
