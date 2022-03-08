// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Программа принимает на вход целое число N и выводит кубы всех чисел от 1 до N
int PromtInt(string message) //Функция ввода символов как целого числа
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int N = PromtInt("Введите целое число");
for (int i = 1; i <= N; i++)
{
    Console.Write((i*i*i) + ", ");
}