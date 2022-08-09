using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStaticMethodsAndClasses
{


    //when you create a static class you cannon create instances of it but you can still invoke methods from the class. A good example of this is the math class
     static class UsefulTools
    {
        public static void SayHi(string name)
        { Console.WriteLine("Hello " + name); }
    }
}
