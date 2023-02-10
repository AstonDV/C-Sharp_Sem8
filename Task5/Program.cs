// Вывести первые N строк треугольника Паскаля. Сделать 
// вывод в виде равнобедренного треугольника


int Input(string text)
{
    Console.Write($"{text}: ");
    int value = int.Parse(Console.ReadLine()!);
    return value;
}

void Main()
{
    Console.Clear();
    int height = Input("Введите высоту треугольника Паскаля");
}

Main();