using System;
using System.Linq;

namespace DemoCSharpModern
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints =
                Enumerable.Range(1, 10)
                    .Select(i => i * i)
                    .Where(i => i > 5)
                    .ToList();

            Console.Write(string.Join(Environment.NewLine, ints));

            Console.WriteLine($"Total: {ints.Sum()}");
        }
    }
}
