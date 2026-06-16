namespace ReadAndWriteCSVDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MMPoint p1 = new MMPoint(1d,1d);
            MMPoint p2 = new MMPoint(2d,2d);
            double res = p1 | p2;
            Console.WriteLine(res);
        }


    }

    struct MMPoint
    {
        private double x, y;
        public MMPoint(double x,double y)
        {
            this.x = x;
            this.y = y;
        }
        public static double operator |(MMPoint a,MMPoint b)
        {
            double result = Math.Exp((a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y));
            return result;
        }
    }
}
