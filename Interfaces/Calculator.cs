using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public abstract class Calculator
    {
        public abstract void Addition();
       public void Substraction()
        {

        }
    }

    public  class Operations: Calculator
    {
        public override void Addition()
        {
            int x = 10, y= 20;
            int result = x + y;
        }


    } 



}
