using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_4
{
    internal interface IFlyable
    {
        float FlySpeed { get; set; }

        void Fly();
    }
}
