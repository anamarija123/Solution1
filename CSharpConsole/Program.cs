﻿

namespace CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 0; i < 100; ++i)
                sum += i;

            System.Console.WriteLine(sum);

            System.Console.WriteLine("Zdravo narode");
            System.Console.ReadKey(true);
        }
    }
}
