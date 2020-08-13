using System;

namespace ConsoleApp1
{
    public abstract class IecDefaultVar
    {
        public abstract string getName(); // 名前を得る

        public abstract int getPrice(); // 価格を得る

        public void show()
        { // 名前と価格を表示する
            Console.WriteLine(getName() + ":" + getPrice() + "円");
        }

        private string N;
        private string D;
        private string Com;
    }
}
