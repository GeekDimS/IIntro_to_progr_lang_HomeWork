// See https://aka.ms/new-console-template for more information
// Программа принимает на вход 3-хзначное число и выдаёт вторую цифру этого числа
Console.WriteLine("Введите трёхзначное число");
int val1 = int.Parse(Console.ReadLine());

int rem = val1 % 10;
val1 = val1 - rem;
rem = val1 % 100;
val1 = rem / 10;

Console.WriteLine("Вторая цифра числа " + val1);