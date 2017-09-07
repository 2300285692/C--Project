using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入月份：");
            int i = int.Parse(Console.ReadLine());
            if(i>=3&&i<=5)
            {
                Console.WriteLine(i + "月是春季");
                Console.ReadLine();
            }
            if (i >= 6 && i <= 8)
            {
                Console.WriteLine(i + "月是夏季");
                Console.ReadLine();
            }
            if (i >= 9 && i <= 11)
            {
                Console.WriteLine(i + "月是秋季");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(i + "月是冬季");
                Console.ReadLine();
            }
        }
    }
}
