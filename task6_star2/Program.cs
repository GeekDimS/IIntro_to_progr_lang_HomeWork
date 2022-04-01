// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Написать программу перевода десятичного числа в двоичное с помощью рекурсии

int Decimal = PromtIntCheck("Введите целое число ");
Console.WriteLine(decimalToBinary(Decimal));

string decimalToBinary(int Val) // Функция перевода целого десятичного числа в строковый двоичный вид
{
    int Rem = 0;
    string Res = "";

    Rem = Val % 2;
    Val = Val / 2;
    Res = Res + Rem;

    if (Val > 0)
        Res = decimalToBinary(Val) + Res;
    return Res;
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
