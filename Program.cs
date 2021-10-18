using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 25;
            Console.WriteLine(findFactorial(factorial));
        }
        static int findFactorial(int num){
            if(num == 0){
                return 1;
            } else {
                return findFactorial(num - 1) * num;
            }
        }
    }
}
