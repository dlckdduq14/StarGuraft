using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGuraft
{
    class Zealot : Unit
    {
        public override void MakeSound()
        {
            Console.WriteLine("아이어를 위하여");
        }
    }
}
