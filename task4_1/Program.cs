// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Цикл, к-рый принимает на вх. 2 числа А и В и возводит А в натуральную степень В

int PromtInt(string message) //Функция ввода символов как целого числа с проверкой. При вызове нужна
// строка запроса, какие именно данные нужны. 
{
    Console.WriteLine(message);
    int temp = 0;
    if (int.TryParse(Console.ReadLine(), out temp))
        return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return -1;
    }
}

double PromtDouble(string message) //Функция ввода символов как числа с дробной частью с проверкой.
// При вызове нужна строка запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    double temp = 0;
    if (double.TryParse(Console.ReadLine(), out temp))
        return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return -1;
    }
}

double numbA = PromtDouble("Введите число, которое надо возвести в степень (основание) ");
if (numbA == -1)
    return;
int numbB = PromtInt("Теперь введите натуральную степень, в которую надо возвести основание ");
if (numbB == -1 || numbB < 0)
{
    Console.WriteLine("Ошибка: степень отрицательная");
    return;
}
double res = 1;

for (int i = 1; i <= numbB; i++)
{
    res = res * numbA;
}

Console.WriteLine("Ответ: " + res);
