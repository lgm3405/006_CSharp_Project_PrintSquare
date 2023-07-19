using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Square
{
    public class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int x = 0;
            int y = 0;

            Console.WriteLine("정사각형의 한 면의 크기를 입력해주세요. (3 ~ 10 사이) => ");
            int.TryParse(Console.ReadLine(), out size);

            if (3 <= size)
            {
                if (size <= 10)
                {
                    while (size > y)
                    {
                        Console.Write(" * ");
                        x += 1;
                        if (size == x)
                        {
                            Console.WriteLine();
                            x = 0;
                            y += 1;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("허용 범위 외 크기를 입력하였습니다.");
                }
            }
            else
            {
                Console.WriteLine("허용 범위 외 크기를 입력하였습니다.");
            }
        }
    }
}
