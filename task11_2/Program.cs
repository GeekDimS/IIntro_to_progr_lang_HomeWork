// Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

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

bool CheckPrimeNumber(int N = 0, int count = 1)
{
    if(N <= 1) return false;
    count = count + 1;
    if (count == N) return true;        
    if (N % count == 0) return false;
    return CheckPrimeNumber(N, count);
}

int N = PromtIntCheck("Введите число для проверки: ");
if (CheckPrimeNumber(N))
    Console.WriteLine("Это простое число");
else
    Console.WriteLine("Это не простое число");