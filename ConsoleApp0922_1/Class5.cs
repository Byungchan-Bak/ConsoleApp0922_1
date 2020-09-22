using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    interface IRunable2
    {
        void Run();
    }
    interface IFlyable2
    {
        void Fly();
    }

    abstract class Fly
    {
        public abstract void CFly();
    }
    class FlyingBike2 : Fly, IRunable
    {
        public override void CFly() //추상클래스 재정의
        {
            Console.WriteLine("Bike Fly");
        }

        public void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }
    class FlyingCar2 : Fly, IRunable
    {
        public override void CFly() //추상클래스 재정의
        {
            Console.WriteLine("Car Fly");
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }
    class Class5
    {
        static void Main()
        {
            FlyingCar2 car2 = new FlyingCar2();
            FlyingBike2 bike2 = new FlyingBike2();
            car2.CFly();
            car2.Run();
            bike2.CFly();
            bike2.Run();

            Flying(car2);
            Flying(bike2);

            Fly[] arr = new Fly[3];
            arr[0] = new FlyingCar2();
            arr[1] = new FlyingBike2();
            arr[2] = new FlyingBike2();

            foreach(Fly temp in arr)
            {
                temp.CFly();
            }
        }
        static void Flying(Fly flyer)
        {
            flyer.CFly();
        }
    }
}
