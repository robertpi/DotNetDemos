using System;
using System.Linq;
using Sqreen.DemoFSharpInterop;

namespace DemoCSharpInterop
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = 
                Numberz.CreateAndFilter(1, 10, 
                    i => i * i, 
                    i => i > 5);

            Console.Write(string.Join(Environment.NewLine, ints));

            Console.WriteLine($"Total: {ints.Sum()}");
        }
    }
}
