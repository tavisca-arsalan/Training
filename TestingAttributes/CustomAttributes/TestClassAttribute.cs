using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class TestClassAttribute:System.Attribute
    {
        public TestClassAttribute()
        {
         
        }

        public static bool Exists(Type type)
        {
            foreach (var attribute in type.GetCustomAttributes(false))
            {
                if (attribute is TestClassAttribute) return true;
            }
            return false;
        }
    }
}
