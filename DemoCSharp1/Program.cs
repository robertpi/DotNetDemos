using System;
using System.Collections;

namespace DemoCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ints = new ArrayList();
            ints.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            int total = 0;
            foreach (object o in ints)
            {
                int i = (int)o;
                i = i * i;
                if (i > 5)
                {
                    Console.WriteLine("{0}", i);
                    total = total + i;
                }
            }
            Console.WriteLine("Total: {0}", total);
        }
    }
}
