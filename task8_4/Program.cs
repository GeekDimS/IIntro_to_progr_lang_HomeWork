// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Максимальное количество элементов тогда 90 (от 10 до 99).

int[,,] FillThreeDimensArray(int xDim, int yDim, int zDim)
{
    int maxNumber = 90; // Максимальное количество неповторяющихся двузначных чисел
    int[,,] res = new int[xDim, yDim, zDim];
    int[] ratioArray = new int[maxNumber]; //Массив всех неповторяющихся двузначных чисел. Используется для исключения теоретического бесконечного цикла поиска нужной случайной величины
    int temp = 0;

    if (xDim * yDim * zDim > maxNumber)
    {
        Console.WriteLine("Слишком большой массив - нет столько неповторяющихся двузначных чисел");
        return new int[,,] { { { 0 } } };
    }

    if (xDim * yDim * zDim <= 0)
    {
        Console.WriteLine("Такого трёхмерного массива не существует");
        return new int[,,] { { { 0 } } };
    }

    for (int l = 0; l < ratioArray.Length; l++) //Заполнение массива всеми возможными числами
    {
        ratioArray[l] = l + 10;
    }

    for (int i = 0; i < xDim; i++)
    {
        for (int j = 0; j < yDim; j++)
        {
            for (int k = 0; k < zDim; k++)
            {
                temp = new Random().Next(10, 100);
                while (ratioArray[temp - 10] == 0)
                {
                    if (temp == 99)
                        temp = 10;
                    temp++;
                }
                res[i, j, k] = ratioArray[temp - 10];
                ratioArray[temp - 10] = 0;
            }
        }
    }
    return res;
}

void PrintTreeDimArrInt(int[,,] arr) // Функция вывода на консоль трёхмерного массива целых чисел строкой с индексами
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{{{i},{j},{k}}}: {arr[i, j, k]} ");
            }
        }
    }
    Console.WriteLine();
}

int[,,] array = FillThreeDimensArray(4, 4, 4);
PrintTreeDimArrInt(array);
