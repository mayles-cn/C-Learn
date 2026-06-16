using System.Data;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main()
        {
            Cat cat1 = new Cat("喵喵大王");
            Dog dog1 = new Dog("旺财");

            cat1.Eat();
            dog1.Eat();

            cat1.Speak();
            dog1.Speak();
        }

        interface IAnimal
        {
            void Eat();
            void Speak();
        }


        //抽象类，一般专门用于继承
        abstract class Animal:IAnimal//接口是一种规范，可以支持开闭原则
        {
            public string  Name { get; set; }

            public Animal(string name) { this.Name = name; }

            public void Eat()
            {
                Console.WriteLine($"{Name}正在吃东西....");
            }

            public abstract void Speak();   
            
        }

        class Cat : Animal {
            public Cat(string name) : base(name)
            {

            }   

            public override void Speak()
            {
                Console.WriteLine("我是猫，喵喵喵");
            }
        }

        class Dog : Animal
        {
            public Dog(string name) : base(name)
            {

            }
            public override void Speak()
            {
                Console.WriteLine("我是狗，汪汪汪");
            }
        }


    }
}
