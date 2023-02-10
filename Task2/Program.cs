// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] TransformMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) == matrix.GetLength(1))
    {
        int[,] tempMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                tempMatrix[j, i] = matrix[i, j];
            }
        }
        return tempMatrix;
    }
    else return matrix;
}

void PrintResult(int[,] inArray)
{
    if (inArray.GetLength(0) == inArray.GetLength(1))
    {
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]}\t ");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Матрицу с введенными вами количеством строк и столбцов транспонировать невозможно!!!");
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    Console.WriteLine();
    int[,] array = GetArray(row, col, 10, 99);
    PrintArray(array);
    int[,] transpArray = TransformMatrix(array);
    Console.WriteLine();
    PrintResult(transpArray);
    Console.WriteLine();

}

Main();