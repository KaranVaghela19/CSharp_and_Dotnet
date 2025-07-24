using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static void Iterate(this string input, Action<char> action)
        {
            if (input == null || action == null)
                return;

            foreach (char c in input)
            {
                action(c);
            }
        }
    }
}
