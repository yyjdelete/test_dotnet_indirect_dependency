using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Test(Action action, string name)
        {
            try
            {
                action();
                Console.WriteLine(name + " is OK");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"***{name} is FAILED->" + ex);
            }

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Test(() => new ClassLibrary1.Class2().Test(), "Test");
            //Test(() => new ClassLibrary1.Class2().Test2(), "Test2");
            Test(() => new ClassLibrary1.Class2().Test3(), "Test3");
        }
    }
}
