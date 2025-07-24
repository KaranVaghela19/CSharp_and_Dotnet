using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Abstraction
    {
        static void Main(string[] args)
        {
            Clinic cl = new Clinic();
            cl.doctors();
            cl.patients();
            Console.ReadLine();
        }
    }

    public abstract class Hospital
    {
      public abstract void doctors(); 
        public virtual void patients()
        {
            Console.WriteLine("Patients visit hospital");
        }
        
        
    }

    public  class Clinic : Hospital
    {
        public override void  doctors()
        {
            Console.WriteLine(" Clinic also has doctor");
        }

        public override void patients()
        {
            Console.WriteLine("Patients also visit clinic");
        }

        
    }
}
