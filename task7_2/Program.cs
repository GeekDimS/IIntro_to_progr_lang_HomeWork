// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого элемента или же указание, что такого элемента нет.

/// <summary>
/// Функция ввода нескольких целых чисел через пробелы или запятые
/// </summary>
/// <param name="message">Запрос данных</param>
/// <returns>Массив целых чисел</returns>
int[] PromtSeveralInt(string message) //Функция ввода нескольких целых чисел, разделённых пробелами или
// запятыми. Запрашивает на входе строку запроса, какие именно данные нужны.
{
    Console.WriteLine(message);
    string? str = Console.ReadLine(); // Проверяем наличие символов на вводе
    if (str == null)
        return new int[] { 0 }; // Если нет символов, то возврат нулевого массива

    char[] separators = new char[] { ' ', '.', ',' }; // Задаём разделители символов (чисел)
    string[] numbers = str.Split(separators, StringSplitOptions.RemoveEmptyEntries); //создаём массив строковых чисел
    int[] res = new int[numbers.Length]; // Создаём массив для записи в него чисел
    for (int i = 0; i < numbers.Length; i++) // Цикл преобразования массива строк в массив целых чисел
    {
        if (int.TryParse(numbers[i], out int temp))
            res[i] = temp;
        else
        {
            Console.WriteLine("Неверно введены числа"); // Если есть символы, отличные от цифр, то выводим сообщение об ошибке
            return new int[] { 0 }; // и выходим из функции с нулевым массивом
        }
    }
    return res;
}

/// <summary>
/// Функция создания двумерного массива и заполнения его случайными вещественными числами
/// </summary>
/// <param name="row">Количество строк</param>
/// <param name="column">Количество столбцов</param>
/// <param name="min">Минимальное число диапазона</param>
/// <param name="max">Максимальное число диапазона</param>
/// <returns>Двумерный массив</returns>
double[,] RandArray(int row, int column, double min = -10, double max = 10) //Функция создания двумерного массива и заполнения его случайными вещественными числами
{
    double[,] arr = new double[row, column];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().NextDouble() * (max - min) + min;
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
            Console.Write($"{arr[i, j]:f2} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



double[,] TwoDimensionArray = RandArray(5, 5);
printArr(TwoDimensionArray);
int[] Position = PromtSeveralInt("Введите через пробел или запятую позицию элемента в массиве : ");

if (Position[0] < 1 || Position[0] > TwoDimensionArray.GetLength(0))
{
    Console.WriteLine("На такой позиции нет элементов");
    return;
}
if (Position[1] < 1 || Position[1] > TwoDimensionArray.GetLength(1))
{
    Console.WriteLine("На такой позиции нет элементов");
    return;
}

Console.WriteLine(
    $"Элемент в позиции ({Position[0]},{Position[1]}) имеет значение {TwoDimensionArray[Position[0] - 1, Position[1] - 1]}"
);
