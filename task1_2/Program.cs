// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 числа через Enter");
int val1 = int.Parse(Console.ReadLine());
int val2 = int.Parse(Console.ReadLine());
int val3 = int.Parse(Console.ReadLine());

int max = val1;
if (max < val2) max = val2;
if (max < val3) max = val3;

Console.WriteLine("Максимальное из введёных чисел " + max);