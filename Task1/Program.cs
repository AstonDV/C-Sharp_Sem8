// Задайте двумерный массив. Напишите программу, которая 
// поменяет местами первую и последнюю строку массива.


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

void TransformMatrix(int[,] matrix)
{
    int temp;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = temp;
    }
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    Console.WriteLine();
    int[,] array = GetArray(row, col, 10, 99);
    PrintArray(array);
    Console.WriteLine();
    TransformMatrix(array);
    PrintArray(array);    
}

Main();