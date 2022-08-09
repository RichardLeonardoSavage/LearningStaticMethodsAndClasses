using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStaticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulTools.SayHi("Mike");


            //note that these 2 static class methods don't need to/CAN'T have instances created but their methods can still be invoked
            Console.WriteLine(Math.Sqrt(144));

            Console.ReadLine();
        }
    }
}