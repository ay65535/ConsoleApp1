using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void builder(People people) => people.Name("Tom").Age(12).Hobby("BaseBall");
            Console.WriteLine(People.Hello(builder));
        }
    }
}
