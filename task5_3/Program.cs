﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] Array = RandArray(PromtIntCheck("Введите размер массива"), -99, 100);
printArr(Array);
Console.WriteLine("Сумма нечётных элементов массива равно " + SummOddElemArray(Array));

int SummOddElemArray(int[] arr) // Функция суммирования всех нечётных эл-тов массива.
{
    int res = 0;
    foreach (int i in arr)
    {
        if(i % 2 != 0) res = res + i; 
    }
    return res;
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

void printArr(int[] Mas) // Функция вывода на консоль одномерного массива
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ");
    }
    Console.WriteLine();
}