// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы,
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на
// друга не делятся)? Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰.
// Указание ограничения для N имеет под собой, видимо, использование типа данных ulong вместо int.

int N = 50; 
List<int> listN = new List<int>(); // Создание списка всех заданных чисел по порядку
for (int i = 1; i <= N; i++)
{
    listN.Add(i);
}

List<List<int>> listList = new List<List<int>>(); // Список списков
listList.Add(listN);

 while (listList[^1].Count != 0) // пока не закончатся числа из исходного списка
{
    listList.Add(SplitList(listList[^1])); // Сам процесс разбиения на группы
}

int k = 0;
foreach (var listPrn in listList) //Печать списка списков
{
    k++;
    if (listPrn.Count != 0)
    {
    System.Console.Write($"Группа {k}: ");
    PrintList(listPrn);
    }
}

//-----------------------------------------------------------------------

List<int> SplitList(List<int> listIn) // Функция оставляет во входящем списке все взаимно простые числа,
// возвращая список "лишних" чисел, не нарушая порядка сортировки по возрастанию
{
    List<int> listOut = new List<int>();
    int c = 0; // Указатель на конец обработанных остающихся в текущем списке (не делящихся) чисел
    int i = 1; // Указатель на начало не проверенных на деление чисел

    while (c != listIn.Count && i != listIn.Count) //Пока не достигли конца списка
    {
        for (int j = 0; j <= c; j++)
        {
            if (c == listIn.Count || i == listIn.Count)
                break;
            if (listIn[i] % listIn[j] == 0) // Если первый элемент необработанного списка делится на предыдущие без остатка
            {
                listOut.Add((listIn[i])); // Переносим его в следующий список
                listIn.RemoveAt(i); // и удаляем из рабочего (текущего)
                j = -1; // Запускаем цикл проверки на деление без остатка снова для след. числа из необработанных
            }
        }
        c++; // Либо нашли неделимое на предыдущие число и сдвигаем счётчики, либо дошли до конца списка
        i++;
    }
    return listOut;
}

void PrintList(List<int> listPrint)
{
    foreach (var val in listPrint)
    {
        Console.Write(val + ",");
    }
    Console.Write("\b \b"); // Удаляем лишнюю запятую
    System.Console.WriteLine();
}
