// Составить частотный словарь элементов двумерного массива. Частотный словарь 
// содержит информацию о том, сколько раз встречается элемент входных данных.


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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count++] = matrix[i, j];
        }
    }
    return array;
}

void BubbleSort(int[] array)
{
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {
                temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
}

void CountElements(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] != array[i + 1])
        {
            Console.WriteLine($"Элемент {array[i]} встречается {count} раз");
            count = 1;
        }
        else count++;
    }
    Console.WriteLine($"Элемент {array[array.Length - 1]} встречается {count} раз");
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
    int[] oneLineArray = MatrixToArray(array);
    Console.WriteLine();
    BubbleSort(oneLineArray);
    Console.WriteLine($"{String.Join(", ", oneLineArray)}");
    Console.WriteLine();
    CountElements(oneLineArray);
}

Main();