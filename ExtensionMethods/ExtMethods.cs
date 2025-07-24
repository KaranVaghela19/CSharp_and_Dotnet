using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maths;

namespace ExtensionMethods
{
   public static class ExtMethods
    {
        public static int Sub(this Custlib obj, int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
