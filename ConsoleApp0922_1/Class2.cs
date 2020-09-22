using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    class Class2
    {
        static void ChangeArray(int[] p)
        {
            p[0]++;
        }
        static void Main()
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            Console.WriteLine("arr1_1 : {0}", arr1[0]); //1
            ChangeArray(arr1);
            Console.WriteLine("arr1_2 : {0}", arr1[0]);  //2

            int[] arr2 = new int[3] { 1, 2, 3 };
            Console.WriteLine("arr1_1 : {0}", arr2[0]); //1
            ChangeArray((int[])arr2.Clone());   //새로운 인스턴스를 생성 후 그 인스턴스를 연산 -->> Deep Copy
            Console.WriteLine("arr1_2 : {0}", arr2[0]);  //1

            Console.WriteLine(arr2.Min());
            Console.WriteLine(arr2.Max());

            int[] target = new int[5];  //Clone은 배열선언과 복사를 동시에 할 수 있으나 배열의 크기가 같음.
            arr2.CopyTo(target, 2); //target배열에 arr2배열을 복사하여 target[2]부터 입력
            PrintArray(target);
            Array.Copy(arr2, target, 3);    //복사하는 배열, 입력받는 배열 총 2개의 파라미터가 필요 -->> 정적 메서드

            int[] arr3 = new int[10] { 13, 21, 3, 2, 9, 4, 16, 24, 10, 5 };
            int[] arr3_1 = (int[])arr3.Clone();
            PrintArray(arr3);
            Array.Sort((int[])arr3.Clone());   //오름차순, ***void타입의 메서드는 근본적인 변수 값이 바뀜.
            PrintArray(arr3_1);
            Array.Reverse(arr3);    //Sort후 Reverse -->> 내림차순
            PrintArray(arr3);

            string str = "CBHYYJBRJWRMCRMY";
            Console.WriteLine(str);
            Console.WriteLine(str.ToLower());
            Console.WriteLine(str);
            //Console.WriteLine(str.Replace("CB", "fnc"));
            str = str.Replace("CB", "fnc");
            Console.WriteLine(str);

            int[,] s_arr = new int[2, 3]
            {
                { 1, 2, 3}, { 4, 5, 6}
            };

            //Console.WriteLine(s_arr[1, 2]);
            foreach (int temp in s_arr)
            {
                Console.Write(temp + "  ");
            }
            Console.WriteLine();
            PrintArray(s_arr);
        }

        private static void PrintArray(int[,] target)
        {
            for (int i = 0; i < target.GetLength(0); i++)
            {
                for (int j = 0; j < target.GetLength(1); j++)
                {
                    Console.Write(target[i, j] + "  ");
                }
            }
            Console.WriteLine();
        }

        private static void PrintArray(int[] target)
        {
            for (int i = 0; i < target.Length; i++)
            {
                Console.Write(target.GetValue(i) + "  ");
            }
            Console.WriteLine();
        }

        static void MyMax(int[] p)
        {
            int max = p[0];

            for(int i = 0; i < p.Length; i++)
            {
                if (p[i] >= max)
                    max = p[i];
            }
        }
    }
}
