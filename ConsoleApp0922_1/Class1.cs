using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    class Class1
    {
        static int Sum(int a)
        {
            int i = 0;
            int sum = 0;

            while(i <= a)
            {
                sum += i;
                i++;
            }

            return sum;
        }

        static int Sum(int step, int min = 1, int max = 100)    //필수 파라미터는 선택 파라미터 앞에 있어야 됨.
        {
            int i = min;
            int tot = 0;
            while(i <= max)
            {
                tot += i;
                i += step;
            }

            return tot;
        }

        static void Main()
        {
            Console.WriteLine(Sum(1, max : 10, min : 1));  //명명 파라미터 -->> 전달되는 매개변수를 정확이 명시해줌.
            Console.WriteLine(Sum(1, 100)); //step, min
            Console.WriteLine(Sum(1));  //step
        }
    }
}
