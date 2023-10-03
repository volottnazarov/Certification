// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
  if (n == 0) return m + 1;
     else
    if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
      else 
      return Akkerman(n - 1, Akkerman(n, m - 1));
}

Console.WriteLine("Вычисление значения функции Аккермана");
Console.WriteLine("         { m+1, если n=0; ");
Console.WriteLine("A(n,m) = { A(n-1,1), если n!=0, m=0;");
Console.WriteLine("         { A(n-1,A(n,m-1)), если n>0, m>0.");
Console.WriteLine("Значения n и m должны быть неотрицательными");
Console.Write("Введите значение n : ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение m : ");
int m = int.Parse(Console.ReadLine()!);
if(n == 0 || m == 0) Console.WriteLine("Ошибка! Введите неотрицательное число!");
Console.Write($"n = {n}, m = {m} -> A(n,m) = {Akkerman(n,m)}");




