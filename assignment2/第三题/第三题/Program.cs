using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int n = 100;
        bool[] prime = new bool[n + 1];

        // 初始化数组，将所有数标记为素数
        for (int i = 2; i <= n; i++)
        {
            prime[i] = true;
        }

        // 使用埃氏筛法筛选素数
        for (int p = 2; p * p <= n; p++)
        {
            // 如果 prime[p] 为 true，则 p 是素数
            if (prime[p] == true)
            {
                // 将 p 的倍数标记为非素数
                for (int i = p * 2; i <= n; i += p)
                {
                    prime[i] = false;
                }
            }
        }

        // 输出素数
        Console.WriteLine("2 到 100 之间的素数为：");
        for (int p = 2; p <= n; p++)
        {
            if (prime[p] == true)
            {
                Console.Write(p + " ");
            }
        }
        Console.Read();
    }
}
