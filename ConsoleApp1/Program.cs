using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ショートケーキの生成
            IecDefaultVar s1 = new IecGlobalVar();
            IecDefaultVar s2 = new OrderDecorator(s1);
            IecDefaultVar s3 = new ATDecorator(s1);
            IecDefaultVar s4 = new OrderDecorator(new IecGlobalVar());
            IecDefaultVar s5 = new OrderDecorator(new ATDecorator(new IecGlobalVar()));
            s1.show();
            s2.show();
            s3.show();
            s4.show();
            s5.show();
            Console.WriteLine("--------------------------------------------");
            // チョコレートケーキの生成
            IecDefaultVar c1 = new IecInOutVar();
            IecDefaultVar c2 = new OrderDecorator(c1);
            IecDefaultVar c3 = new ATDecorator(c1);
            IecDefaultVar c4 = new OrderDecorator(new IecInOutVar());
            IecDefaultVar c5 = new OrderDecorator(new ATDecorator(new IecInOutVar()));
            c1.show();
            c2.show();
            c3.show();
            c4.show();
            c5.show();
        }
    }
}
