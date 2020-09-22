using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0922_1
{
    interface IMan
    {
        string Name { get; set; }   //default -->> public
        void Save();
        void Show();
    }

    interface IPerson : IMan
    {
        int Age { get; set; }
    }

    class Employee : IPerson
    {
        int age;
        public int Age { get => age; set => age = value; }
        string name;
        public string Name { get { return name; } set { name = value; } }

        void IMan.Save()    //명시적으로 선언할 경우 Main에서 IMan타입으로 선언하여 사용 -->> 같은 이름의 인터페이스를 다중상속 받을 때 사용
        {
            Console.WriteLine("Name -->> {0}", this.name);
            //throw new NotImplementedException();
        }

        public void Show()  //IMan 3개, IPerson 1개 총 4개의 인터페이스를 구현 해야함.
        {
            Console.WriteLine("Name -->> {0}", this.name);
            Console.WriteLine("Age -->> {0}", this.age);
            //throw new NotImplementedException();
        }
    }

    class Class3
    {
        static void Main()
        {
            Employee man_e = new Employee();    //
            IMan man_i = new Employee(); //

            
        }
    }
}
