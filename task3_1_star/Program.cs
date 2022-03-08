// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Программа проверяет входящее пятизначное число на палиндром при помощи операций с числами, массивами

string PromtStr(string message) //Функция ввода символов как строки символов
{
    Console.WriteLine(message);
    return Console.ReadLine();
}

string valS = PromtStr("Введите пятизначное число");
valS = valS.Trim();
int ls = valS.Length;
int valI = 0;

if (!Int32.TryParse(valS, out valI)) //Проверка на наличие только цифр на вводе
{
    Console.WriteLine("Число введено в неправильном формате");
    return;
}

if (valS.Length != 5) //Проверка правильного количества цифр в введёном числе
{
    Console.WriteLine("Число введено не пятизначное");
    return;
}

int[] arr = new int[ls];
for (int i=ls-1; i>=0; i--)
{
    arr[i] = valI % 10;
    valI = valI / 10;
}

if (arr[0]==arr[4] && arr[1]==arr[3]) Console.WriteLine("Число является палиндромом");
else Console.WriteLine("Число не является палиндромом");