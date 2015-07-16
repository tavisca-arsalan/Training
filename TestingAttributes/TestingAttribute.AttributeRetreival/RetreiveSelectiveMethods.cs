using CustomAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestingAttribute.AttributeRetreival
{
    public class RetreiveSelectiveMethods
    {
        public List<string> SelectTestMethods(string dllPath)
        {
            List<string> methodList=new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (TestClassAttribute.Exists(type))
                    {
                        string className = type.FullName;
                        
                                foreach (MethodInfo methodInfo in type.GetMethods())
                                {
                                    foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                                    {
                                        TestMethodAttribute testMethodAttribute = customAttribute as TestMethodAttribute;
                                        if (null != testMethodAttribute)
                                        {
                                            methodList.Add(className + "." + methodInfo.Name);
                                        }
                                    }
                                }
                    }
                    
                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message,e);
            }
                return methodList;
        }

        public List<string> SelectTestMethodCategory(string dllPath,string category)
        {
            List<string> methodList = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (TestClassAttribute.Exists(type))
                    {
                        string className = type.FullName;
                       
                                foreach (MethodInfo methodInfo in type.GetMethods())
                                {
                                    foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                                    {
                                        TestCategoryAttribute testCategoryAttribute = customAttribute as TestCategoryAttribute;
                                        if (null != testCategoryAttribute)
                                        {
                                            if (string.Equals(testCategoryAttribute.Category,category,StringComparison.OrdinalIgnoreCase))
                                                methodList.Add(className + "." + methodInfo.Name);
                                        }
                                    }
                                }
                    }

                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
            return methodList;
        }


        public List<string> SelectIgnoreMethods(string dllPath)
        {
            List<string> methodList = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (TestClassAttribute.Exists(type))
                    {
                        string className = type.FullName;
                       
                                foreach (MethodInfo methodInfo in type.GetMethods())
                                {
                                    foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                                    {
                                        IgnoreAttribute testCategoryAttribute = customAttribute as IgnoreAttribute;
                                        if (null != testCategoryAttribute)
                                        {
                                                methodList.Add(className+"."+methodInfo.Name);
                                        }
                                    }
                                }
                    }

                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
            return methodList;
        }
    }
}
