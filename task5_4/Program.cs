// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементами массива.

double[] Array = RandArray(PromtIntCheck("Введите размер массива"));
printArr(Array);
Console.WriteLine($"Разница между минимальным и максимальным значениями массива равна {DispersionArr(Array):f2}");

double DispersionArr(double[] arr) //Функция нахождения разницы между мин.и макс. значенями массива
{
    double minVal=arr[0];
    double maxVal=arr[0];
    foreach (double i in arr)
    {
        if(minVal > i) minVal = i;
        if(maxVal < i) maxVal = i;
    }
    return maxVal - minVal;
}

double[] RandArray(int lenght, double min = -100, double max = 100) //Функция заполнения массива случайными целыми числами
{
    double[] answer = new double[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().NextDouble()*(max-min) + min;
    }
    return answer;
}

int PromtIntCheck(string message) //Функция ввода символов как целого числа с проверкой. Можно указать
// строка запроса, какие именно данные нужны. 
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out int temp)) return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return 0;
    }
}

void printArr(double[] Mas) // Функция вывода на консоль одномерного массива чисел с плавающей запятой
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write($"{Mas[pos]:f2} ");
    }
    Console.WriteLine();
}