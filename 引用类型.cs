namespace ConsoleApp1
{
    internal class Program
    {
        //值类型和引用类型
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Person p1 = new Person();
            p1.Id = 1;
            p1.Name = "Tom";

            Person p2 = p1;
            p2.Id = 2;

            Console.WriteLine($"p1的id为{p1.Id}");
        }
    }
}
