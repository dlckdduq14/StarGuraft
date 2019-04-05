using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarGuraft
{
    abstract class Unit
    {
        protected int X;
        protected int Y;

        /// <summary>
        /// 이 추상메서드를 상속받는 모든 자식은 사용해야한다.
        /// </summary>
        public abstract void MakeSound();
        
        public virtual void Move(int x, int y)
        {
            if (x < 0 || y < 0)
                return;

            X = x;
            Y = y;
        }
    }
}
