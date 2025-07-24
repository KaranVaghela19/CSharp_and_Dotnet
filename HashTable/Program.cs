using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable  ht = new Hashtable();
            ht.Add(101, "Karan");
            ht.Add(102, "Kartik");
            ht.Add(103, "Mayur");
            ht.Add(104, "Nish");

            ht.Remove(104);
            //  ht.Clear();
            Hashtable cloned = (Hashtable)ht.Clone();

            cloned.Clear();

            ht.GetEnumerator();


            foreach (DictionaryEntry hashtable in ht)
            {
                Console.WriteLine(hashtable.Key +" : "+ hashtable.Value);
            }

            Console.WriteLine(ht.Contains(101));
            Console.WriteLine(ht.ContainsKey(103));
            Console.WriteLine(ht.ContainsValue("Niraj"));

            foreach (DictionaryEntry hash in cloned)
            {
                Console.WriteLine(hash.Key + " : " + hash.Value);
            }
            Console.ReadLine();

            
        }

        

    }
}
