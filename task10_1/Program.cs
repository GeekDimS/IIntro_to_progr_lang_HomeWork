// Заданы 2 массива: info и data. В массиве info хранятся двоичные представления
// нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит,
// которые занимают числа из массива info. Напишите программу, которая составит массив
// десятичных представлений чисел массива data с учётом информации из массива info.

void PrintArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count - 1; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine(Mas[Mas.Length - 1]);
}

void BinaryToDecimal(int[] data, int[] info, int begin = 0, int count = 0) // Ф-ция перевода двоичных
// чисел, заданных двумя массивами в массив десятичных чисел, записываемый во второй входной массив,
// изначально содержащий длины двоичных чисел.
{
    if (begin >= data.Length)
        return;

    int c = info[count];
    /*int temp = 0; //          Этот кусок кода заменён рекурсивной функцией AloneBinaryToDecimal.
    for (int i = 0; i < c; i++)
    {
        temp = temp + data[begin + c - i - 1] * Powering(2, i);
    }
    */
    
    info[count] = AloneBinaryToDecimal(data, c, begin);//temp;
    BinaryToDecimal(data, info, begin + c, count + 1);
}

int AloneBinaryToDecimal(int[] data, int c, int begin) // Рекурсивная функция перевода одного двоичного числа в десятичное
{
    if (c == 0)
        return 0;
    return data[begin] * Powering(2, c - 1) + AloneBinaryToDecimal(data, c - 1, begin + 1);
}

int Powering(int b, int a) // Ф-ция возведения в степень (рекурсия).
{
    if (a <= 0)
        return 1;
    return b * Powering(b, a - 1);
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
BinaryToDecimal(data, info);
PrintArr(info);
