namespace ConsoleApp1
{
    internal class Program
    {
        //ref引用传参
        public static void dosomething(ref int num)
        {
            num = 2;
        }
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine(a);
            dosomething(ref a);
            Console.WriteLine(a);
        }
    }
}
