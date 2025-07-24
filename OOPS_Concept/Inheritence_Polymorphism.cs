using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    class Inheritence_Polymorphism
    {
        static void Main(string[] args)
        {
            Vehicles v = new Car();
            v.Gear();

            Vehicles v1 = new Bus();
            v1.Wheels();
            Console.ReadLine();
        }
    }

    public  class Vehicles
    {
        public virtual void Gear()
        {
            Console.WriteLine("Vehicles has 4-5 gears");
        }
        public virtual void Wheels()
        {
            Console.WriteLine("Vehicles has 2,4,6 wheels");
        }

    }
    public class  Bus : Vehicles
{
        public  override void Gear()
        {
            Console.WriteLine("Vehicles has 4-5 gears");

        }

        public override void Wheels()
        {
            Console.WriteLine("Bus has 4 wheels");
        }
    }

    public class Car : Vehicles
    {
        public override void Gear()
        {
            Console.WriteLine("Car has 3-5 gears");
        }
    }
}
