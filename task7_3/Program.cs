// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] RandArray(int row, int column, int min = -10, int max = 10) //Функция создания двумерного массива и заполнения его случайными вещественными числами
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

void printArrDouble(double[] Mas) // Функция вывода на консоль одномерного массива чисел с плавающей запятой
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write($"{Mas[pos]:f2} \t");
    }
    Console.WriteLine();
}

void printArrInt(int[,] arr) // Функция вывода на консоль двумерного массива целых чисел
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] CalculatingAverage(int[,] arr) // Функция вычисления ср.-арифм. столбцов двумерного массива целых чисел
{
    double[] res = new double[arr.GetLength(1)];

    for (int j = 0; j < arr.GetLength(1); j++)
    {
        int temp = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            temp = temp + arr[i, j];
        }
        res[j] = (temp) / (double)arr.GetLength(0);
    }
    return res;
}

int[,] InputArray = RandArray(5, 5);
printArrInt(arr: InputArray);
double[] ArrAverage = CalculatingAverage(InputArray);
printArrDouble(Mas: ArrAverage);
