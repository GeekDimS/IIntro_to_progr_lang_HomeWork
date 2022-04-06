// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Заполните спирально массив 4 на 4 по возрастанию.
// Выполнил по принципу обхода лабиринта для матрицы любого размера (ограничено максимальным int)

void FillSpiralArray(int[,] array)
{
    array[0, 0] = 1;
    int r = 0;
    int c = 0;
    int i = 1;
    while (i < array.Length)
    {
        while (c + 1 < array.GetLength(1) && (array[r, c + 1] == 0)) // Пока справа от текущего элемента нет границы матрицы или ненулевой ячейки
        {
            c++;
            array[r, c] = i + 1;
            i++;
        }
        while (r + 1 < array.GetLength(0) && array[r + 1, c] == 0) // Пока снизу текущей ячейки нет границы матрицы или ненулевой ячейки
        {
            r++;
            array[r, c] = i + 1;
            i++;
        }
        while (c - 1 >= 0 && array[r, c - 1] == 0) // Пока слева от текущей ячейки нет границы матрицы или ненулевой ячейки
        {
            c--;
            array[r, c] = i + 1;
            i++;
        }
        while (array[r - 1, c] == 0) // Пока сверху текущей ячейки нет ненулевого значения
        {
            r--;
            array[r, c] = i + 1;
            i++;
        }
    }
    return;
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

int rows = 4;
int columns = 4;
int[,] spiralArray = new int[rows, columns];
FillSpiralArray(spiralArray);
printArrInt(spiralArray);
