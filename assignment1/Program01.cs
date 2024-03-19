using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用简单计算器！");
            Console.WriteLine("请输入第一个数字: ");
            double num1 = GetNumberFromUser();

            Console.WriteLine("请输入第二个数字: ");
            double num2 = GetNumberFromUser();

            Console.WriteLine("请输入运算符 (+, -, *, /): ");
            char op = GetOperatorFromUser();

            try
            {
                double result = Calculate(num1, num2, op);
                Console.WriteLine("计算结果: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("错误: " + ex.Message);
            }

            Console.ReadLine(); // 保持控制台窗口打开
        }

        static double GetNumberFromUser()
        {
            double num;
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("错误: 请输入有效的数字");
                Console.WriteLine("请重新输入: ");
            }
            return num;
        }

        static char GetOperatorFromUser()
        {
            char op;
            while (!char.TryParse(Console.ReadLine(), out op) || (op != '+' && op != '-' && op != '*' && op != '/'))
            {
                Console.WriteLine("错误: 请输入有效的运算符 (+, -, *, /)");
                Console.WriteLine("请重新输入: ");
            }
            return op;
        }

        static double Calculate(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    if (num2 != 0)
                        return num1 / num2;
                    else
                        throw new DivideByZeroException("除数不能为零");
                default:
                    throw new ArgumentException("无效的运算符");
            }
        }
    }
}
