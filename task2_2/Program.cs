// See https://aka.ms/new-console-template for more information
// Программа выводит случайное 3-хначное число и удаляет вторую цифру
// этого числа
Random rnd = new Random();
int val = rnd.Next(100, 1000);

Console.WriteLine("Случайное число " + val);

int rem = val % 10;
int div = val / 100;
val = (div*10) + rem;

Console.WriteLine("Число без средней цифры " + val);