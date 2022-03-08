// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Программа принимает на вход координаты 2 точек и находит расстояние между ними в 3D
int PromtInt(string message) //Функция ввода символов как целого числа
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

double CalcDist(int a1, int a2, int a3, int b1, int b2, int b3)
{
    return Math.Sqrt(Math.Pow(b1-a1,2) + Math.Pow(b2-a2,2) + Math.Pow(b3-a3,2));
}

int ax = PromtInt("Введите поочереди через Enter координаты первой точки");
int ay = PromtInt("");
int az = PromtInt("");
int bx = PromtInt("Введите поочереди через Enter координаты второй точки");
int by = PromtInt("");
int bz = PromtInt("");

Console.WriteLine(CalcDist(ax, ay, az, bx, by, bz));
