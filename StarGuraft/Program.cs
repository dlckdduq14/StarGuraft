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
            //팬을 생성한다.
            Pan pan = new Pan();

            if (pan.ink != true)
                Console.WriteLine("잉크가 없습니다.");

            Console.WriteLine("어떤 색을 쓸 것가요?");
            Console.WriteLine("1: 검정 , 2: 빨강 , 3: 파랑 , 4: 초록 , 5: 샤프");

            int userInput = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"당신이 고른색은 {userInput} 입니다.");
            Console.WriteLine();
        }
    }
}
