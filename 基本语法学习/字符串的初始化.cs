using System.Text;
namespace ReadAndWriteCSVDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///字符串的初始化
            //字面量初始化
            string str01 = "hello";
            string str02 = """
                你好
                世界
                我爱你
                """;//多行文本字符串
            Console.WriteLine(str02);
            string str03 = @"C\cognex\vision\";//不转义反斜杠，常用于路径

            //空字符串
            string str04 = "";//常用
            string str05 = string.Empty;//清晰语义
            string str06 = null;//不能调用方法，否则会报异常

            //使用构造函数构造字符串
            string str07 = new string('a', 8);
            char[] chars = {'a','b','c' };
            string str08 = new string(chars);
            string str09 = new string(chars,0,3);//index and lenth

            //从其他类型转换
            string s12 = 123.ToString();           // "123"
            string s13 = 3.14.ToString("F2");      // "3.14"
            string s14 = Convert.ToString(null);   // ""（安全转换）
            string s15 = $"{123:D5}";              // "00123"

            //String Builder
            //Using System.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("我");
            sb.Append("爱");
            sb.Append("你");
            string ms = sb.ToString();


            //静态方法
            string s1 = string.Join(", ", new[] { "hello", "wo", "ai","ni" });//"hello, wo, ai, ni"
            Console.WriteLine(s1);
            string s2 = string.Concat("nihao", "xiao", "maoni");//"nihaoxiaomaomi"
        }

    }

    
}
