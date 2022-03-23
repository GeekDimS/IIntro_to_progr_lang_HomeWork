// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Программа задаёт массив из 8 элементов случайными числами и выводит их на экран.
// Заполнение массива оформить в виде функции. Числа натуральные. Задаётся
// как размер массива (кол-во его элементов), так и "амплитуда"- диапазон чисел от нуля
// до заданного числа. Значения по умолчанию выбраны, чтобы
// уложиться в диапазон примеров к заданию.

int PromtInt(string message) //Функция ввода символов как целого числа с проверкой. При вызове нужна
// строка запроса, какие именно данные нужны.
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out int temp))
        return temp;
    else
        return 0;
}

void FillPrintRandArray(int[] Arr, int scope) // Функция заполнения массива заданным диапазоном значений
// натуральных чисел и вывода этого массива в консоль.
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(0, scope + 1);
        Console.Write(Arr[i] + " ");
    }
}

int SizeArr = PromtInt("Введите размер массива или просто нажмите Enter");
if (SizeArr <= 0)
    SizeArr = 8; //значение по умолчанию
int Ampl = PromtInt("Введите амплитуду чисел массива или просто нажмите Enter"); //
if (Ampl <= 0)
    Ampl = 100; //значение по умолчанию

int[] RandArr = new int[SizeArr];
FillPrintRandArray(RandArr, Ampl);
