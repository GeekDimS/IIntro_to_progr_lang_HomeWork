// See https://aka.ms/new-console-template for more information
// Программа принимает цифру дня недели и выдаёт результат, 
// является-л этот день недели выходным.
try 
{
Console.WriteLine("Введите порядковый номер дня недели");
int val1 = int.Parse(Console.ReadLine());

if (val1 > 7 || val1 < 1) 

{
    Console.WriteLine("Введённое число не может являться днём недели");
    return;
}

if (val1 <= 5) Console.WriteLine("Рабочий день недели");
else Console.WriteLine("Выходной день недели");

}
catch (System.FormatException)
{
Console.WriteLine("Неверный формат числа"); // Обработка исключения, если введено не число, либо проcто нажат Enter
}