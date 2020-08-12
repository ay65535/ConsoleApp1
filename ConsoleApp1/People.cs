using System;

namespace ConsoleApp1
{
    class People
    {
        private People()
        {
        }

        private string name;
        private int age;
        private string hobby;

        public People Name(string name)
        {
            this.name = name;
            return this;
        }
        public People Age(int age)
        {
            this.age = age;
            return this;
        }
        public People Hobby(string hobby)
        {
            this.hobby = hobby;
            return this;
        }

        public static string Hello(Action<People> builder)
        {
            People people = new People();
            builder.Invoke(people);
            return "Hello, world!";
        }
    }
}

// Action<People> builder = people => people.Name("Tom").Age(12).Hobby("BaseBall");
// People.Hello(builder);
