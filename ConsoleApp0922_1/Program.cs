using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    class Program
    {
        static void Sqr(int x)  //제곱 메서드 -->> return해야 Main에서 사용가능
        {
            x = x * x;
        }
        static int Sqr(ref int x)  //ref함수를 이용하여 파라미터 값 수신 -->> 파라미터 값(값)이 존재해야 사용가능
        {
            return x * x;
        }
        static void GetName(out string name, out int id)    //out함수를 이용하여 파라미터 값 수신 -->> 파라미터 값(주소)이 존재하지 않아도 되나 메서드에서 정의 해야함.
        {
            Console.WriteLine("Enter Name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter ID : ");
            id = int.Parse(Console.ReadLine());
        }

        static void PrintIntParams(params int[] arr)   //Params 가변배열
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int a = 3;
            Sqr(a);
            Console.WriteLine("Value -->> {0}", a); //3

            int b = 3;
            Sqr(ref b);
            Console.WriteLine("ref Value -->> {0}", b); //9

            string name;
            int id;
            GetName(out name, out id);
            Console.WriteLine("out -->> {0}\t {1}", name, id);  //name, id

            PrintIntParams(1, 2, 3, 4);
            int[] myArr = { 5, 6, 7, 8, 9 };
            PrintIntParams(myArr);  //매개변수가 배열이어도 가능
            PrintIntParams();   //매개변수가 없어도 가능
        }
    }
}
