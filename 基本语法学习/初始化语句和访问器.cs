using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name { get;  init; }
        public int Age { get; private set; }

        public Person(int age,string name)
        {
            Age = age;
            Name = name;
        }

        public void introduction()
        {
            Console.WriteLine($"大家好，我的名字是{this.Name}，我今年{this.Age}岁了！");
        }
    }
}


namespace ConsoleApp1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person p1 = new Person(18, "zhangsan") { Name = "lisi"};

            p1.introduction();
        }
    }
}
