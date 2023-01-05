using System;

namespace Laba1Z3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите А");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите двузначное число");
            int b = int.Parse(Console.ReadLine());
            int sum = (b / 10) + (b % 10);
            string result = (sum%a==0)?"кратное":"не кратное";
            Console.WriteLine(result);
        }
    }
}
