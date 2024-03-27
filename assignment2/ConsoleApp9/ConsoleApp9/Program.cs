using System;

class PrimeFactorFinder
{
    // 判断一个数是否是素数
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));
        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    // 输出整数的所有素数因子
    static void FindPrimeFactors(int number)
    {
        Console.Write($"整数 {number} 的所有素数因子为: ");
        for (int i = 2; i <= number; i++)
        {
            if (number % i == 0 && IsPrime(i))
            {
                Console.Write($"{i} ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("请输入一个整数：");
        if (int.TryParse(Console.ReadLine(), out int inputNumber))
        {
            FindPrimeFactors(inputNumber);
        }
        else
        {
            Console.WriteLine("输入的不是有效的整数。");
        }
        Console.ReadLine(); // 保持控制台窗口打开
    }
}
