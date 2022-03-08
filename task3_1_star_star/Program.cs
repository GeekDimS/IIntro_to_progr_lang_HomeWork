// See https://aka.ms/new-console-template for more information
// Console.WriteLine(int.MaxValue + "   " + int.MinValue);
// Программа определения числа разрядности до Integer на палиндромность
string PromtStr(string message) //Функция ввода символов как строки символов
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

bool Palindrom(string message) //Функция определения, является-ли строка палиндромом
{
    int ls = message.Length;
    int ls2 = ls/2;
    string a = message.Substring(0, ls2);
    string b = "";
    for(int i = ls-1; i >= (ls-ls2); i--)
    {
        b = b + message[i];
    }
    if (a == b) return true;
    else return false;
}

string valS = PromtStr("Введите число не более " + int.MaxValue);
valS = valS.Trim();
int valI = 0;
if (!Int32.TryParse(valS, out valI)) //Проверка на наличие только цифр на вводе
{
    Console.WriteLine("Число введено в неправильном формате");
    return;
}

if (Palindrom(valS)) Console.WriteLine("Число "+ valS + " является палиндромом");
else Console.WriteLine("Число "+ valS + " не является палиндромом");