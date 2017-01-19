using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    class Random
    {
        public int Next(int value)
        {
            Random random = new Random();
            int r = random.Next(1,value);
            if (value < 1 || value > 9)
            {
                return 0;
            }
            else
            {
                if (true)
                {

                }
            }
        }
    }
}
