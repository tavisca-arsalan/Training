using CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAttributes.DllToTest
{
    [TestClassAttribute()]
    public class ClassA
    {
        [TestMethodAttribute()]
        public void Method1()
        {
            Console.WriteLine("Hi I am method1 inside classA");
        }

        [TestMethodAttribute()]
        [TestCategoryAttribute("Smoke Test")]
        public void Method2()
        {
            Console.WriteLine("Hi I am method2 inside classA");
        }

        [IgnoreAttribute()]
        public void Method3()
        {
            Console.WriteLine("Hi I am method3 inside classA");
        }

    }
}
