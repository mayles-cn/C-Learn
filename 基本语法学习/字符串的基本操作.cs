using System.Text;
namespace ReadAndWriteCSVDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////字符串的基本操作
            ///

            //1------查询与判断
            string s = "Hello World";

            // 长度
            int len = s.Length;                    // 11

            // 是否包含
            bool b1 = s.Contains("World");         // true
            bool b2 = s.Contains('W');             // true

            // 开头/结尾判断
            bool b3 = s.StartsWith("Hello");       // true
            bool b4 = s.EndsWith("!");             // false

            // 查找位置（找不到返回 -1）
            int i1 = s.IndexOf("World");           // 6
            int i2 = s.IndexOf('o');               // 4（第一个）
            int i3 = s.LastIndexOf('o');           // 7（最后一个）
            int i4 = s.IndexOf("xyz");             // -1

            // 是否为空
            bool b5 = string.IsNullOrEmpty("");    // true
            bool b6 = string.IsNullOrWhiteSpace("  "); // true（空格也算空）

            // 比较
            bool b7 = s.Equals("hello world", StringComparison.OrdinalIgnoreCase); // true
            int cmp = string.Compare("A", "B");    // -1（A < B）

            //2------截取与分割

            // 截取子串
            string sub1 = s.Substring(6);          // "World"（从索引6到末尾）
            string sub2 = s.Substring(0, 5);       // "Hello"（从0开始，取5个）

            // 分割
            string csv = "a,b,c,d";
            string[] parts = csv.Split(',');       // ["a", "b", "c", "d"]
            string[] parts2 = "a,,b".Split(',', StringSplitOptions.RemoveEmptyEntries); // ["a","b"]

            // 按多个字符分割
            string[] parts3 = "a;b|c".Split(new[] { ';', '|' }); // ["a", "b", "c"]

            // 取前后N个字符（C# 8+）
            string first = s[..5];                 // "Hello"
            string last = s[6..];                  // "World"
            string mid = s[2..7];                  // "llo W"（索引2到6）


            //3------------替换与修改

            // 替换（返回新字符串，原字符串不变）
            string r1 = s.Replace("World", "C#");  // "Hello C#"
            string r2 = s.Replace('l', 'L');       // "HeLLo WorLd"

            // 移除
            string r3 = s.Remove(5);               // "Hello"（从索引5移除到末尾）
            string r4 = s.Remove(2, 3);            // "He World"（从2开始移除3个）

            // 插入
            string r5 = s.Insert(5, ",");          // "Hello, World"

            // 填充
            string r6 = "42".PadLeft(5, '0');      // "00042"
            string r7 = "42".PadRight(5, '-');     // "42---"

            // 修剪空白
            string r8 = "  hello  ".Trim();        // "hello"
            string r9 = "  hello  ".TrimStart();   // "hello  "
            string r10 = "  hello  ".TrimEnd();     // "  hello"


            //4---------大小写转换
            string up = s.ToUpper();               // "HELLO WORLD"
            string low = s.ToLower();              // "hello world"

            // 文化敏感的大小写（如土耳其语 i）
            string up2 = s.ToUpperInvariant();
            string low2 = s.ToLowerInvariant();


            //5-------------拼接与组合
            // 运算符 +
            string s1 = "Hello" + " " + "World";

            // string.Concat
            string s2 = string.Concat("a", "b", "c");  // "abc"

            // string.Join
            string s3 = string.Join(", ", new[] { "a", "b", "c" });  // "a, b, c"

            // string.Format
            string s4 = string.Format("{0} + {1} = {2}", 1, 2, 3);  // "1 + 2 = 3"

            // 插值（推荐）
            string s5 = $"1 + 2 = {1 + 2}";         // "1 + 2 = 3"


            //6------------其他操作

            // 转字符数组
            char[] chars = s.ToCharArray();        // ['H','e','l','l','o',' ','W','o','r','l','d']

            // 重复字符串（.NET 6+）
            string repeat = string.Concat(Enumerable.Repeat("ab", 3)); // "ababab"

            // 判断是否包含任意字符
            bool hasDigit = s.Any(char.IsDigit);   // false

            // 行分割
            string text = "line1\nline2";
            string[] lines = text.Split('\n');

            // 包含在范围内检查
            bool inRange = s.Contains("World", StringComparison.OrdinalIgnoreCase);




            ///////////////////////////////////////////////////////补充
            ///using System.Text;
            ///StringBuilder
            ///

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" ");
            sb.Append("World");
            sb.AppendLine("!");        // 自动加换行
            sb.Insert(5, ",");         // 插入
            sb.Remove(5, 1);           // 移除

            string result = sb.ToString();  // "Hello, World!\n"
        }
    }

}
