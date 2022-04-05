// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MultplyArrays(int[,] arrayA, int[,] arrayB) //Функция перемножения двух матриц (двумерных массивов) целых чисел
{
    if (arrayA.GetLength(1) != arrayB.GetLength(0))
    {
        Console.WriteLine("Размеры массивов не подходят для умножения.");
        return new int[,]{{0}};
    }

    int[,] res = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            for (int cA = 0; cA < arrayA.GetLength(1); cA++)
            {
                    res[i, j] = res[i, j] + arrayA[i, cA]*arrayB[cA, j];                
            }
        }
    }
    return res;
}

int[,] arrayA = FillArray(3, 5);
int[,] arrayB = FillArray(5, 2);
PrintArray(arrayA);
Console.WriteLine();
PrintArray(arrayB);
Console.WriteLine();

PrintArray(MultplyArrays(arrayA, arrayB));
Console.WriteLine();