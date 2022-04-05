// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.
// Если есть строки с одинаковой суммой элементов, то считаем неважным, какую из них выводить (верхнюю)

int[,] FillArray(int row, int column) // Функция создания и заполнения случайными целыми числами двумерного массива целых чисел
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array) // Функция вывода на консоль двумерног массива целых чисел
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] SumInRowsArray(int[,] array) // Функция суммирования всех элементов каждой строки двумерного массива и вывода результата в виде одномрного массива
{
    int[] res = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            res[i] = res[i] + array[i, j];
        }
    }
    return res;
}

void PrintArr(int[] Mas) // Функция вывода на консоль одномерного массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}

int[,] array = FillArray(10, 5);
PrintArray(array);
Console.WriteLine();

int[] sumArray = SumInRowsArray(array);
PrintArr(sumArray);

int minVal = sumArray[0];
int minIndex = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (minVal > sumArray[i])
    {
        minVal = sumArray[i];
        minIndex = i;
    }
}

Console.WriteLine($"{minIndex + 1} строка является строкой с наименьшей суммой элементов.");
