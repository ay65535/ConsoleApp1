using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            void builder(IecVar iecVar) => iecVar.Name("in_Execute").DataType("BOOL").Comment("Boolean");
            Console.WriteLine(IecVar.Hello(builder));

            // ショートケーキの生成
            SpongeCake s1 = new ShortCake();
            SpongeCake s2 = new StrawberryDecorator(s1);
            SpongeCake s3 = new BananaDecorator(s1);
            SpongeCake s4 = new StrawberryDecorator(new ShortCake());
            SpongeCake s5 = new StrawberryDecorator(new BananaDecorator(new ShortCake()));
            s1.show();
            s2.show();
            s3.show();
            s4.show();
            s5.show();
            Console.WriteLine("--------------------------------------------");
            // チョコレートケーキの生成
            SpongeCake c1 = new ChocolateCake();
            SpongeCake c2 = new StrawberryDecorator(c1);
            SpongeCake c3 = new BananaDecorator(c1);
            SpongeCake c4 = new StrawberryDecorator(new ChocolateCake());
            SpongeCake c5 = new StrawberryDecorator(new BananaDecorator(new ChocolateCake()));
            c1.show();
            c2.show();
            c3.show();
            c4.show();
            c5.show();
        }
    }
}
