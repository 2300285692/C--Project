using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;
            while(num<1000)
            {
                if(num%2==1&&num%3==1&&num%4==1)
                {
                    Console.WriteLine("这篮子鸡蛋至少有" + num + "个");
                    break;
                }
                num++;
            }
        }
    }
}