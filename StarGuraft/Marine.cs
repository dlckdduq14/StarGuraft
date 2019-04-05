using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGuraft
{
    class Marine : Unit
    {
        public override void MakeSound()
        {
            Console.WriteLine("u wanna piece of meat?");
        }
    }
}
