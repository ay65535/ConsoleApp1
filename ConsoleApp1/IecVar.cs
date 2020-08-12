using System;

namespace ConsoleApp1
{
    class IecVar
    {
        private IecVar()
        {
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

        public static string Hello(Action<IecVar> builder)
        {
            IecVar iecVar = new IecVar();
            builder.Invoke(iecVar);
            return $"{iecVar.N}: {iecVar.D};  // {iecVar.Com}";
        }
    }
}

// Action<People> builder = people => people.Name("Tom").Age(12).Hobby("BaseBall");
// People.Hello(builder);
