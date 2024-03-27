using System;

namespace 第二题
{
    class Program
    {
        static void Main()
        {
            Console.Write($"请输入数组数字（以空格分隔）： ");
            string input = Console.ReadLine();

            string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputArray.Length];
            bool isValidInput = false;

            // 循环直到所有输入都能成功解析为整数
            while (!isValidInput)
            {
                isValidInput = true; // 先假设输入是有效的
                for (int i = 0; i < inputArray.Length; i++)
                {
                    if (!int.TryParse(inputArray[i], out int number))
                    {
                        isValidInput = false; // 如果有无法解析的输入，则设定输入无效
                        Console.WriteLine($"无法解析输入: {inputArray[i]}");
                        Console.Write($"请重新输入： ");
                        input = Console.ReadLine();
                        inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries); // 更新输入数组
                        i = -1; // 重新检查新的输入
                    }
                    else
                    {
                        numbers[i] = number;
                    }
                }
            }

            // 计算最大值
            int max = int.MinValue; // 设置初始最大值为最小可能的整数值
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            // 计算最小值
            int min = int.MaxValue; // 设置初始最小值为最大可能的整数值
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }
            }

            // 计算平均值和总和
            int sum = 0;
            int validCount = 0; // 统计有效输入的数量
            foreach (int num in numbers)
            {
                if (num != 0) // 忽略标志值 0
                {
                    sum += num;
                    validCount++;
                }
            }
            double average = validCount > 0 ? (double)sum / validCount : 0; // 避免除以零

            // 输出结果
            Console.WriteLine("最大值: " + (max != int.MinValue ? max.ToString() : "N/A"));
            Console.WriteLine("最小值: " + (min != int.MaxValue ? min.ToString() : "N/A"));
            Console.WriteLine("平均值: " + average);
            Console.WriteLine("总和: " + sum);
            Console.Read();
        }
    }
}
