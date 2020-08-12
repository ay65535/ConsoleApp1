using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ショートケーキの生成
            IecVar s1 = new IecGlobalVar();
            IecVar s2 = new OrderDecorator(s1);
            IecVar s3 = new ATDecorator(s1);
            IecVar s4 = new OrderDecorator(new IecGlobalVar());
            IecVar s5 = new OrderDecorator(new ATDecorator(new IecGlobalVar()));
            s1.show();
            s2.show();
            s3.show();
            s4.show();
            s5.show();
            Console.WriteLine("--------------------------------------------");
            // チョコレートケーキの生成
            IecVar c1 = new IecInOutVar();
            IecVar c2 = new OrderDecorator(c1);
            IecVar c3 = new ATDecorator(c1);
            IecVar c4 = new OrderDecorator(new IecInOutVar());
            IecVar c5 = new OrderDecorator(new ATDecorator(new IecInOutVar()));
            c1.show();
            c2.show();
            c3.show();
            c4.show();
            c5.show();
        }
    }
}
