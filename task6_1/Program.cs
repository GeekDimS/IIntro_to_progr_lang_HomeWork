// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.

int[] Array = PromtSeveralInt("Введите несколько отрицательных и положительных чисел, разделённых пробелом или запятой");
printArr(Array); // Можно закомментить - было для проверки и отладки
Console.WriteLine("Положительных чисел найдено: " + CountingNegNumbers(Array));

int CountingNegNumbers(int[] arr) // Функция подсчёта количества отрицательных чисел в массиве
{
    int res = 0;
    foreach (int i in arr)
    {
        if(i > 0) res = res + 1;
    }
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

void printArr(int[] Mas) // Функция вывода на консоль одномерного массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}
