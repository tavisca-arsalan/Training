using CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAttributes.DllToTest
{
   [TestClassAttribute()]
   public class ClassC
    {
        [IgnoreAttribute()]
        public void Method1()
        {
            Console.WriteLine("Hi I am method1 inside classC");
        }

        [TestMethodAttribute()]
        [TestCategoryAttribute("Unit Test")]
        public void Method2()
        {
            Console.WriteLine("Hi I am method2 inside classC");
        }

        [IgnoreAttribute()]
        public void Method3()
        {
            Console.WriteLine("Hi I am method3 inside classC");
        }

        [TestMethodAttribute()]
        [TestCategoryAttribute("Unit Test")]
        public void Method4()
        {
            Console.WriteLine("Hi I am method4 inside classC");
        }

    }
}
