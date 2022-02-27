// See https://aka.ms/new-console-template for more information
// Программа принимает на вход число и выдаёт все чётные числа от 1
// до этого числа
Console.WriteLine("Введите число");
int val1 = int.Parse(Console.ReadLine());

for (int i = 2; i <= val1; i = i + 2 )
{
    Console.Write(i + " ");
}

Console.WriteLine();