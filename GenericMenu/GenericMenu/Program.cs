using System;

namespace GenericMenu
{
    public delegate void MyDelegate();

    class Program
    {
        static void f1()
        {
            Console.WriteLine("A");
        }
        static void f2()
        {
            Console.WriteLine("B");
        }
        static void f3()
        {
            Console.WriteLine("C");
        }

        static void Main(string[] args)
        {
            Menu.MenuGenerator(new string[] { "Op1", "Op2", "Op3" }, new MyDelegate[] { f1, f2, f3 });
            Console.ReadKey();
        }

    }
}
