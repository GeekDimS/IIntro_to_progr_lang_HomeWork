// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Программа принимает на вход число и выдаёт сумму цифр в числе. Предположу, что 
// входное число должно быть целым.

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

int inpVal = PromtInt("Введите натуральное число ");
if(inpVal == -1) return; // Выход из программы, если ввод ошибочный

int res = 0;
while(inpVal != 0)
{
    res = res + inpVal % 10;
    inpVal = inpVal / 10;
}

if(res<0) res = -1*res; // Если введено отрицательное число, то убираем лишний минус в сумме
Console.WriteLine("Сумма цифр в числе = " + res);