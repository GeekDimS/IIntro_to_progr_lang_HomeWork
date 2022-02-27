// See https://aka.ms/new-console-template for more information
// Программа принимает на вход число и выдаёт, чётное оно или нет.
Console.WriteLine("Введите число");
int val1 = int.Parse(Console.ReadLine());

int res = val1 % 2;
if ((val1 % 2) == 0) Console.WriteLine("Число чётное");
else Console.WriteLine("Число нечётное");
