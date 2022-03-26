// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый 
// и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] origArr = RandArray(PromtIntCheck("Введите размер массива"));
printArr(origArr);

int[] res = MultiArray(origArr);
printArr(res);

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

int[] RandArray(int lenght, int max = -9, int min = 10) //Функция заполнения массива случайными целыми числами
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
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

int PromtIntCheck(string message) //Функция ввода символов как целого числа с проверкой. При вызове нужна
// строка запроса, какие именно данные нужны.
{
    Console.WriteLine(message);
    if (int.TryParse(Console.ReadLine(), out int temp))
        return temp;
    else
        return 0;
}