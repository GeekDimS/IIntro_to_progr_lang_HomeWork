// See https://aka.ms/new-console-template for more information
// Программа, которая принимает 2 числа и выдаёт, какое больше
Console.WriteLine("Введите 2 числа через Enter");
int val1 = int.Parse(Console.ReadLine());
int val2 = int.Parse(Console.ReadLine());

if (val1 > val2) 
{
    Console.WriteLine("Число " + val1 + " больше числа " + val2);
    return;
}
if (val2 > val1) Console.WriteLine("Число " + val2 + " больше числа " + val1);
else Console.WriteLine("Число " + val1 + " равно числу " + val2);