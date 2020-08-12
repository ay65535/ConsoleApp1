using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void builder(IecVar iecVar) => iecVar.Name("in_Execute").DataType("BOOL").Comment("Boolean");
            Console.WriteLine(IecVar.Hello(builder));
        }
    }
}
