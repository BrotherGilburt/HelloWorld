using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Start:
            Console.Write("Enter a value:\nn = ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Fibonacci n = " + Fibulator(n));

            Console.WriteLine("Again? (Y/N)");
            if (Console.Read() == 'Y')
            {
                Console.ReadLine();
                goto Start;
            }
        }

        static int Fibulator(int n)
        {
            return Fibulator(1, 1, n);
        }

        static int Fibulator(int a, int b, int n)
        {
            if(n<1)
            {
                return -1;
            }
            else if (n==1)
            {
                return a;
            }
            else if(n==2)
            {
                return b;
            }
            else if(n==3)
            {
                return a + b;
            }
            else
            {
                return Fibulator(b, a + b, n - 1);
            }
        }
    }
}
