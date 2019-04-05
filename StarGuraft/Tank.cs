using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGuraft
{
    class Tank : Unit
    {
        private bool IsSeigeMode;

        public override void MakeSound()
        {
            Console.WriteLine("징~~");
        }
        public override void  Move(int x, int y)
        {
            if (IsSeigeMode)
                return;

            //base.Move(x, y);
            if (x < 0 || y < 0)
                return;

            X = x;
            Y = y;
        }
    }
}
