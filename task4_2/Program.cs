// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Программа принимает на вход число и выдаёт сумму цифр в числе. Предположу, что 
// входное число должно быть целым.

int PromtInt(string message) //Функция ввода символов как целого числа с проверкой. При вызове нужна
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

int inpVal = PromtInt("Введите натуральное число ");
if(inpVal == 0) return; // Выход из программы, если ввод ошибочный

int res = 0;
while(inpVal != 0)
{
    res = res + inpVal % 10;
    inpVal = inpVal / 10;
}

if(res<0) res = -1*res; // Если введено отрицательное число, то убираем лишний минус в сумме
Console.WriteLine("Сумма цифр в числе = " + res);