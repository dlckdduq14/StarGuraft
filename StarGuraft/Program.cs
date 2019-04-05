using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGuraft
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit m = new Marine();
            Unit t = new Tank();
            Unit z = new Zealot();

            Dance(m);
            Dance(z);
            Dance(t);

            Unit[] units = new Unit[3];
            units[0] = m;
            units[1] = t;
            units[2] = z;
            
            for (int i = 0; i < units.Length; i++)
            {
                units[i].Move(5, 6);
                
                units[i].MakeSound();
            }

        }

        static void Dance(Unit unit)
        {
            unit.Move(1, 2);
            unit.Move(3, 4);
        }
    }
}
