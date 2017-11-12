using System;

namespace rec
{
    class Operations
    {
        public long Sum(long x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                return x+Sum(x-1);
            }
        } 

        public long Factorial(long x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
              return x*Factorial(x-1);  
            }
        }

        public long Fibonachi(long x)
        {
            if(x == 0)
            {
                return 0;                
            }
            else if (x == 1)
            {
                return 1;
            }
            else
            {
                return (Fibonachi(x-1) + Fibonachi (x-2)); 
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var operation = new Operations();      
            Console.Write("Input number: ");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Sum(x) = {0}",operation.Sum(number));
            Console.WriteLine("Factorial(x) = {0}",operation.Factorial(number));
            Console.WriteLine("Fibonachi(x) = {0}", operation.Fibonachi(number));
            Console.ReadKey();
        }
    }
}