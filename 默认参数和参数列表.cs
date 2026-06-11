namespace ConsoleApp1
{
    internal class Program
    {
        //默认参数和参数数组

        private static void fun1(ref Person p,string name,int age = 18)
        {
            p.mName = name;
            p.mAge = age;
        }

        private static void fun2(params int[] numbers)
        {
            foreach(var a in numbers)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            Person p1 = new Person();

            fun1(ref p1, "李华");//使用默认参数
            Console.WriteLine(p1.mName);

            fun2(1, 4, 31, 422);//使用参数数组
        }
    }
}
