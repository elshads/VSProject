using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    class Tank : Unit
    {
        public int Accuracy { get; set; } = 3;

        public int Health { get; set; } = 3;

        public int Maneur { get; set; } = 2;

        public int Power { get; set; } = 3;

        public int Range { get; set; } = 2;

        public int Rate { get; set; } = 1;

        public int Reflection { get; set; } = 2;

        public int Shield { get; set; } = 2;

        public int Speed { get; set; }

        public void DecreaseHealth()
        {
            throw new NotImplementedException();
        }

        public void Fire()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
