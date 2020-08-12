using System;

namespace ConsoleApp1
{
    public abstract class IecVar
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

        public IecVar Name(string name)
        {
            this.N = name;
            return this;
        }
        public IecVar DataType(string dataType)
        {
            this.D = dataType;
            return this;
        }
        public IecVar Comment(string comment)
        {
            this.Com = comment;
            return this;
        }
    }
}

// Action<People> builder = people => people.Name("Tom").Age(12).Hobby("BaseBall");
// People.Hello(builder);
