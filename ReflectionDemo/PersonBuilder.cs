using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class PersonBuilder
    {
        public void PersonLoader()
        {
            var MyAssembly = Assembly.LoadFile(@"D:\Vijay\Technology\Csharp\CsCodeSnippets\PersonManager\bin\Debug\PersonManager.dll");
            //Get the Class Reference
            var MyType = MyAssembly.GetType("PersonManager.Person");
            //Create an instance of the type
            dynamic MyObject = Activator.CreateInstance(MyType);

            //Get the Type of the class
            Type parameterType = MyObject.GetType();
            //Step3: Browse the Metadata
            //To Get all Public Fields/variables
            Console.WriteLine("All Public Fields");
            foreach (MemberInfo memberInfo in parameterType.GetFields())
            {
                Console.WriteLine(memberInfo.Name);
            }
            //To Get all Public Methods
            Console.WriteLine("\nAll Public Methods");
            foreach (MemberInfo memberInfo in parameterType.GetMethods())
            {
                Console.WriteLine(memberInfo.Name);
            }
            //To Get all Public Properties
            Console.WriteLine("\nAll Public Properties");
            foreach (MemberInfo memberInfo in parameterType.GetProperties())
            {
                Console.WriteLine(memberInfo.Name);
            }

            parameterType.InvokeMember("SetPersonData",
                                      BindingFlags.Public |
                                      BindingFlags.InvokeMethod |
                                      BindingFlags.Instance,
                                      null, MyObject, new object[] { "Vijay", "vijay.balkawade@gmail.com", 35, "76575"}
                                    );

            parameterType.InvokeMember("PrintPersonData",
                                       BindingFlags.Public |
                                       BindingFlags.InvokeMethod |
                                       BindingFlags.Instance,
                                       null, MyObject, null
                                     );

            Console.ReadKey();
        }
    }
}
