using System;

namespace git_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            string c = null;
            Console.WriteLine("Введите A");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите B");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Выберите действие +, -, /, *");
            
            if (c=="*")
            {
                Console.WriteLine(a + b);
            }
            if (c == "-")
            {
                Console.WriteLine(a * b);
            }
        }
    }
}
