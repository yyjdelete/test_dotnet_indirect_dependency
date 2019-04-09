using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new ClassLibrary1.Class1().Test();
                Console.WriteLine("Class1 is OK");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("***Class1 is FAILED->" + ex);
            }

            Console.WriteLine();
            Console.WriteLine("----------");
            Console.WriteLine();

            try
            {
                new ClassLibrary1.Class2().Test();
                Console.WriteLine("Class2 is OK");
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("***Class2 is FAILED->" + ex);
            }
        }
    }
}
