using System;
using System.Collections.Generic;
using System.Text;

namespace GenericMenu
{
    class Menu
    {
        public static void MenuGenerator(string[] options, MyDelegate[] functions)
        {
            if (options != null && functions != null && options.GetLength(0) == functions.GetLength(0))
            {
                int op;
                do
                {
                    for (int i = 1; i <= options.Length + 1; i++)
                    {
                        if (i <= options.Length)
                        {
                            Console.WriteLine(i + ". " + options[i - 1]);
                        }
                        else
                        {
                            Console.WriteLine(i + ". Exit");
                        }
                    }
                    op = ValidarNum(options.Length + 1, 1);
                    if (op <= options.Length)
                    {
                        MyDelegate f = functions[op - 1];
                        f();
                        Console.WriteLine();
                    }
                } while (op < options.Length + 1);
            }
            else
            {
                Console.WriteLine("Error: The number of options and functions is diferent");
            }
        }

        public static int ValidarNum(int max, int min = 0)
        {
            bool valido = false;
            int num = 0;
            while (!valido)
            {
                try
                {
                    valido = true;
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num < min || num > max)
                    {
                        throw new ArgumentException();
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The number is out of range " + min + "-" + max);
                    valido = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The data entered must be a number");
                    valido = false;
                }
            }
            return num;
        }
    }
}
