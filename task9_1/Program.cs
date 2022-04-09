// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа
// в промежутке от M до N.
// M = 1; N = 5. -> "2, 4"
// M = 4; N = 8. -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintEven(int M, int N)
{
    if (M % 2 != 0)
        M++;
    if (M > N)
        return;
    Console.Write(M + " ");
    PrintEven(M + 2, N);
}

int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
PrintEven(M, N);
