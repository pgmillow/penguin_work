using System;

class MainClass
{
    public static bool IsToeplitzMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        // 检查每个元素是否与其右下方对角线上的元素相等
        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                if (matrix[i][j] != matrix[i + 1][j + 1])
                {
                    return false;
                }
            }
        }

        return true;
    }

    public static void Main(string[] args)
    {
        int[][] matrix = new int[][] {
            new int[] {1, 2, 3, 4},
            new int[] {5, 1, 2, 3},
            new int[] {9, 5, 1, 2}
        };

        if (IsToeplitzMatrix(matrix))
        {
            Console.WriteLine("给定的矩阵是托普利茨矩阵。");
        }
        else
        {
            Console.WriteLine("给定的矩阵不是托普利茨矩阵。");
        }
        Console.Read();
    }
}
