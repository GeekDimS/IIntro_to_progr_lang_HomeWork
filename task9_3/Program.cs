// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 3, n = 2 -> A(m,n) = 29

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int Akker(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akker(n - 1, 1);
    else
      return Akker(n - 1, Akker(n, m - 1));
}
int A = Prompt("Введите число => ");
int B = Prompt("Введите число => ");
Console.WriteLine(Akker(A,B));

