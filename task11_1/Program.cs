// Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int PromtIntCheck(string message) //Функция ввода символов как целого числа с проверкой. Можно указать
// строка запроса, какие именно данные нужны.
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out int temp))
        return temp;
    else
    {
        Console.WriteLine("Неверно введено число");
        return 0;
    }
}

bool CheckTwoPower(int N = 0)
{
    if (N == 1)
        return true;
    if (N <= 0)
        return false;
    if (N % 2 != 0)
        return false;
    return CheckTwoPower(N / 2);
}

int N = PromtIntCheck("Введите число для проверки: ");
if (CheckTwoPower(N))
    Console.WriteLine("Является степень двойки");
else
    Console.WriteLine("Не является степенью двойки");
