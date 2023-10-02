//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.



int NaturalNumbers(int N)
{
if (N == 0) return 1 ; 
Console.Write(N+",");
return NaturalNumbers(N - 1);
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if(n == 0) Console.WriteLine("Ошибка! Введите число больше 0 ");
Console.Write($"N = {n} -> " );
NaturalNumbers(n);   
