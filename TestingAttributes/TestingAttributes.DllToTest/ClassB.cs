using CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAttributes.DllToTest
{
    class ClassB
    {
       
        public void Method1()
        {
            Console.WriteLine("Hi I am method1 inside classB");
        }

       
       
        public void Method2()
        {
            Console.WriteLine("Hi I am method2 inside classA");
        }

       
        public void Method3()
        {
            Console.WriteLine("Hi I am method3 inside classA");
        }
    }
}
