using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实训2._1
{
        class Program
        {
            static void Main(string[] args)
            {
                Student stu = new Student();
                Employer emp = new Employer();

                stu.Name = "张三";
                stu.age = 20;
                Console.Write(stu.Name + "，今年" + stu.age + "岁，");
                stu.work();

                emp.Name = "李四";
                emp.age = 40;
                Console.Write(emp.Name + "，今年" + emp.age + "岁，");
                emp.work();
            }
        }

        //抽象类people
        abstract class People
        {
            public string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public int age;
            public abstract void work();
        }

        //派生出学生类
        class Student : People
        {
            string school = "石家庄铁道大学";
            public override void work()
            {
                Console.WriteLine("在" + school + "学习。");
            }
        }

        //派生出职工类
        class Employer : People
        {
            string address = "石家庄铁道大学";
            public override void work()
            {
                Console.WriteLine("在" + address + "上班。");
            }
        }
    }

