using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TankBattle
{
    interface Unit
    {
        int Power { get; set; }
        int Range { get; set; }
        int Accuracy { get; set; }
        int Rate { get; set; }
        int Health { get; set; }
        int Shield { get; set; }
        int Maneur { get; set; }
        int Reflection { get; set; }
        int Speed { get; set; }

        void Fire();
        void DecreaseHealth();
        void Move();
    }
}
