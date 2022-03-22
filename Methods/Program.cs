// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Здесь собираются методы (подпрограммы, функции) для сокращения написания
// новых программ

int PromtInt(string message) //Функция ввода символов как целого числа. Запрашивает на входе
// строку запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

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

string PromtStr(string message) //Функция ввода символов как строки символов. Запрашивает на входе
// строку запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    return Console.ReadLine();
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

bool Palindrom(string message) //Функция определения, является-ли строка палиндромом
{
    int ls = message.Length;
    int ls2 = ls / 2;
    string a = message.Substring(0, ls2);
    string b = "";
    for (int i = ls - 1; i >= (ls - ls2); i--)
    {
        b = b + message[i];
    }
    if (a == b)
        return true;
    else
        return false;
}
