using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            AsyncFactorial(n);
            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i <= n; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);

        }

        static async void AsyncFactorial(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
    
}
