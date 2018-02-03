using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());

            int sum = 0;
            int counter = 0;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int k = 0; k <= secondNum; k++)
                {
                    counter++;
                    int curentNum = (i * k) * 3;
                    sum += curentNum;

                    if (sum >= maxSum)
                    {
                        Console.WriteLine($"{counter}combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter}combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
