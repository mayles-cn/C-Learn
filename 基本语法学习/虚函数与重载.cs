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


        class Animal
        {
            public string  Name { get; set; }

            public Animal(string name) { this.Name = name; }

            public void Eat()
            {
                Console.WriteLine($"{Name}正在吃东西....");
            }

            public virtual void Speak()
            {
                Console.WriteLine("动物在叫");
            }
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
