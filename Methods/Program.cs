﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Здесь собираются методы (подпрограммы, функции) для сокращения написания
// новых программ

int PromtInt(string message) //Функция ввода символов как целого числа. Запрашивает на входе
// строку запроса, какие именно данные нужны
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
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

string PromtStr(string message) //Функция ввода символов как строки символов. Можно указать
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

void FillPrintRandArray(int[] Arr, int scope) // Функция заполнения массива заданным диапазоном случайных 
// значений натуральных чисел и вывода этого массива в консоль.
{
    for(int i = 0; i< Arr.Length; i++)
    {
        Arr[i] = Random.Shared.Next(0,scope + 1);
        Console.Write(Arr[i] + " ");
    }
}

int[] MultiArray(int[] arr) // Функция перемножения попарно элементов массива. Пары относительно центра массива
{
    int[] answer = new int[arr.Length/2 + arr.Length % 2];
    for(int i = 0; i < arr.Length/2; i++)
    {
        answer[i] = arr[i]*arr[arr.Length -i-1];
    }
    if(arr.Length % 2 == 1) answer[answer.Length-1] = arr[arr.Length/2];
    return answer;
}

int[] RandArray(int lenght, int min = -9, int max = 10) //Функция заполнения массива случайными целыми числами
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(min, max);
    }
    return answer;
}

void printArr(int[] Mas) // Функция вывода на консоль одномерного массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}

int SummOddElemArray(int[] arr) // Функция суммирования всех нечётных эл-тов массива.
{
    int res = 0;
    foreach (int i in arr)
    {
        if(i % 2 != 0) res = res + i; 
    }
    return res;
}
