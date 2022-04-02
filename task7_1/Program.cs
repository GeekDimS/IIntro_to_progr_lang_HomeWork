// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/// <summary>
/// Функция создания двумерного массива и заполнения его случайными вещественными числами
/// </summary>
/// <param name="row">количество строк</param>
/// <param name="column">количество столбцов</param>
/// <param name="min">минимальное число диапазона</param>
/// <param name="max">максимальное число диапазона</param>
/// <returns>Двумерный массив вещественных чисел</returns>
double[,] RandArray(int row, int column, double min = -10, double max = 10) //Функция создания двумерного массива и заполнения его случайными вещественными числами
{
    double[,] arr = new double[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble() * (max - min) + min;
        }
    }
    return arr;
}

/// <summary>
/// Функция вывода на консоль двумерного массива чисел с плавающей запятой
/// </summary>
/// <param name="arr">Двумерный массив вещественных чисел</param>
void printArr(double[,] arr) // Функция вывода на консоль двумерного массива чисел с плавающей запятой
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]:f2} \t");   
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int m = 5;
int n = 5;
double[,] TwoDimensionArray = RandArray(m, n);
printArr(TwoDimensionArray);