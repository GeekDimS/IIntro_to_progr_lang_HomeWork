// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

int[] Array = PromtSeveralInt(
    "Введите через пробелы соответствующие коэффициенты k1 b1 k2 b2 уравнений прямых: "
);
double[] XY = CalcXY(Array);
Console.WriteLine($"Координаты точки пересечения равны {{{XY[0]};{XY[1]}}}");

double[] CalcXY(int[] arr) // Функция расчёта точки пересечения 2-х прямых на плоскости,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; элементы массива слева направо 
// соответствуют перечислению их в уравнениях.
{
    double[] res = { 0, 0 };
    if (arr[2] - arr[0] == 0) //Проверка равенства угла наклона прямых
    {
        Console.WriteLine("Прямые параллельны");
        return res;
    }
    res[0] = (arr[1] - arr[3]) / (arr[2] - arr[0]); // Расчёт абсциссы
    res[1] = (arr[1] * arr[2] - arr[3] * arr[0]) / (arr[2] - arr[0]); // Расчёт ординаты
    return res;
}

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
