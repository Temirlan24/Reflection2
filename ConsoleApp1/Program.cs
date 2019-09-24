using System;
using System.Reflection;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;


namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            /*1. Type type = typeof(Console);
             var methods = type.GetMethods();
             Console.WriteLine("Список методов класса Console: ");
             foreach(var member in methods)
             {
                 Console.WriteLine("Type: "+member.ReturnType.Name + "\tName: " + member.Name);
             }*/
            /*2. */ Type type = typeof(Student);
            var methods = type.GetMethods();
            Console.WriteLine(methods);
            Console.WriteLine("Список методов класса Student: ");
            Console.WriteLine("*********************************");
                foreach(var member in type.GetMembers())
                {
                    if(member is MethodInfo)
                    {
                        var methodInfo = member as MethodInfo;
                        Console.WriteLine($"Метод - {methodInfo.Name}, {methodInfo.ReflectedType}");
                        foreach (var parameter in methodInfo.GetParameters())
                        {
                            Console.WriteLine($"Параметр - {parameter.ParameterType}, {parameter.Name}");
                        }
                    Console.WriteLine("\n\n");
                    }
                }
            }
    }
}