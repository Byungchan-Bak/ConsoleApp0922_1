using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    interface IRunable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class FlyingBike : IFlyable, IRunable
    {
        public void Fly()
        {
            Console.WriteLine("Bike Fly");
            //throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Bike Run");
            //throw new NotImplementedException();
        }
    }
    class FlyingCar : IFlyable, IRunable
    {
        public void Fly()
        {
            Console.WriteLine("Car Fly");
            //throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Car Run");
            //throw new NotImplementedException();
        }
    }
    class Class4
    {
        static void Main()
        {
            FlyingCar car = new FlyingCar();
            car.Fly();
            car.Run();

            FlyingBike bike = new FlyingBike();
            bike.Fly();
            bike.Run();

            Flying(car);
            Flying(bike);
        }

        static void Flying(IFlyable flyer)  //인터페이스에 정의된 클래스 타입으로 자식클래스 사용(부모↔ 자식 자동 형변환)
        {
            flyer.Fly();
        }
        static void Running(IRunable runner)  //인터페이스에 정의된 클래스 타입으로 자식클래스 사용(부모↔ 자식 자동 형변환)
        {
            runner.Run();
        }

        /*
        static void Flying(FlyingCar car)
        {
            car.Fly();
        }
        static void Flying(FlyingBike bike)
        {
            bike.Fly();
        }
        */
    }
}
