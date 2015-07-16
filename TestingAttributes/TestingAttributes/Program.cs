using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingAttribute.AttributeRetreival;

namespace TestingAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string category;
                string operation;
                List<string> methodList = null;

                Console.WriteLine("Enter the Type of method to be searced(Ignore/TestMethod):");
                operation = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(operation) == true)
                {
                    throw new Exception("You entered a wrong method to be searched.");
                }

                if (string.Equals(operation, "TestMethod", StringComparison.OrdinalIgnoreCase))
                {
                    methodList = new RetreiveSelectiveMethods().SelectTestMethods(args[0]);
                    if (methodList.Count == 0)
                    {
                        Console.WriteLine("There is no Test method.");
                    }
                    else
                    {
                        foreach (string method in methodList)
                        {
                            Console.WriteLine(method);
                        }
                    }

                }
                else if (string.Equals(operation, "Ignore", StringComparison.OrdinalIgnoreCase))
                {
                    methodList = new RetreiveSelectiveMethods().SelectIgnoreMethods(args[0]);
                    if (methodList.Count == 0)
                    {
                        Console.WriteLine("There is no Test method.");
                    }
                    else
                    {
                        foreach (string method in methodList)
                        {
                            Console.WriteLine(method);
                        }
                    }
                
                }

                Console.WriteLine("Enter the Test Case category to be searched(space separated):");
                category = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(category) == true)
                    throw new Exception("You entered a wrong category");

                methodList = new RetreiveSelectiveMethods().SelectTestMethodCategory(args[0],category);
                if (methodList.Count == 0)
                {
                    Console.WriteLine("There is no Test method belonging to that category.");
                }
                else
                {
                    foreach (string method in methodList)
                    {
                        Console.WriteLine(method);
                    }
                }



                Console.ReadKey();
            }
            catch(Exception e)
            { Console.WriteLine(e.Message); }
        }
    }
}
