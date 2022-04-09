// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int CalcSumm(int M, int N)
{
    if (M > N)
        return 0;
    return M + CalcSumm(M + 1, N);
}
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
Console.WriteLine(CalcSumm(M, N));
