// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.

int[,] FillArray(int row, int column)
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

void PrintArray(int[,] array)
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

void SortShellArrayRows(int[,] array) // Функция сортировки ОДНОМЕРНОГО массива методом Шелла
{
    int i,
        j,
        k,
        h,
        r = 0, // Текущая строка
        b = array.GetLength(1); // Длина строк (количество столбцов)
    int m;

    int[] d = // длины промежутков из эмпирической последовательности Марцина Циура (A102549 в OEIS)
    {
        1,
        4,
        10,
        23,
        57,
        145,
        356,
        911,
        1968,
        4711,
        11969,
        27901,
        84801,
        213331,
        543749,
        1355339,
        3501671,
        8810089,
        21521774,
        58548857,
        157840433,
        410151271,
        1131376761,
        2147483647
    };

    for (r = 0; r < array.GetLength(0); r++)
    {
        m = 0;
        while (d[m] < b)
            ++m;
        while (--m >= 0)
        {
            k = d[m];
            for (i = k; i < b; i++)
            { // k-сортировка
                j = i;
                h = array[r, i];
                while ((j >= k) && (array[r, j - k] > h))
                {
                    array[r, j] = array[r, j - k];
                    j = j - k;
                }
                array[r, j] = h;
            }
        }
    }
}

int[,] array = FillArray(10, 10);
PrintArray(array);
SortShellArrayRows(array);
Console.WriteLine();
PrintArray(array);
