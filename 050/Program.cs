// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

void PrintArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}, ");
        }
        Console.WriteLine();
    }
}

int[,] CreateArrayWithRandomNumbers(int m, int n)
{
    int[,] result = new int[m, n];

    var random = new Random();

    for (var i = 0; i < result.GetLength(0); i++)
    {
        for (var j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = random.Next(1, 10);
        }
    }

    return result;

}

Console.WriteLine("Введите число строк (m)");
if (!int.TryParse(Console.ReadLine()!, out var m))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите число столбцов (n)");
if (!int.TryParse(Console.ReadLine()!, out var n))
{
    Console.WriteLine("Всё плохо");
}

var array = CreateArrayWithRandomNumbers(m, n);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите номер строки (m2)");
if (!int.TryParse(Console.ReadLine()!, out var m2))
{
    Console.WriteLine("Всё плохо");
}

Console.WriteLine("Введите номер столбца (n2)");
if (!int.TryParse(Console.ReadLine()!, out var n2))
{
    Console.WriteLine("Всё плохо");
}

void Result(int m2, int n2)
{
    if (m - 1 < m2 | m2 < 0 | n - 1 < n2 | n2 < 0)
    {
        Console.WriteLine("Элемент не существует");
    }

    else
    {
        Console.WriteLine("Значение элемента массива = " + array[m2, n2]);
    }

}
Console.WriteLine();
Result(m2, n2);
