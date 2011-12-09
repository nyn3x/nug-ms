using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in FizzBuzz.From1To100())
            {
                Console.WriteLine(item);
            }
        }
    }
}
