// Задайтедвумерный массив из целых чисел. Напишите программу, которая удалит 
// строку и столбец, на пересечении которых расположен наименьший элемент массива.


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

int[] MinIndexs(int[,] array)
{
    int minIndexRow = 0;
    int minIndexCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[minIndexRow, minIndexCol] > array[i, j])
            {
                minIndexRow = i;
                minIndexCol = j;
            }
        }
    }
    return new int[] { minIndexRow, minIndexCol };
}

int[,] MatrixCutLines(int[,] matrix, int[] indexMin)
{
    int height = matrix.GetLength(0) - 1;
    int width = matrix.GetLength(1) - 1;
    int countNewRow = 0;
    int countNewCol = 0;
    int[,] afterCutMatrix = new int[height, width];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i == indexMin[0])
            continue;
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == indexMin[1])
                    continue;
                afterCutMatrix[countNewRow, countNewCol] = matrix[i, j];
                countNewCol++;
            }
            countNewRow++;
            countNewCol = 0;
        }
    }
    return afterCutMatrix;
}

void Main()
{
    Console.Clear();
    int row = Input("Введите кол-во строк");
    int col = Input("Введите кол-во столбцов");
    int minVal = Input("Введите минимальное значение");
    int maxVal = Input("Введите максимальное значение");
    Console.WriteLine();
    int[,] array = GetArray(row, col, minVal, maxVal);
    PrintArray(array);
    int[] indexsMinValue = MinIndexs(array);
    Console.WriteLine();
    int[,] cutMatrix = MatrixCutLines(array, indexsMinValue);
    PrintArray(cutMatrix);
}

Main();