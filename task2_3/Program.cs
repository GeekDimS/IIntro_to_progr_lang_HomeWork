// See https://aka.ms/new-console-template for more information
// Программа выводит третью цифру числа, либо сообщает, что её нет.
Console.WriteLine("Введите число ");
string val1 = Console.ReadLine();
val1 = val1.Trim();

if (val1.Length < 3) 
{
    Console.WriteLine("Третьей цифры в этом числе нет");
    return;
}

char res = val1[2];

Console.WriteLine("Третья цифра числа " + res);