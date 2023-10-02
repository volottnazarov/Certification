// Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
int[]GenerateArray(int M, int N)
{
int length = N - M + 1;
int[]array = new int[length];
for (int i = 0; i < length ; i++)
{
    array[i] = M;
    M++;
}
return array;
}

int SumNaturalNumber(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
       sum = sum + array[i]; 
    }
return sum;
}

Console.Write("Введите начало промежутка чисел значение M : ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение конца промежутка чисел N : ");
int n = int.Parse(Console.ReadLine()!);
if(n == 0 || m == 0)
{
     Console.WriteLine("Ошибка! Введите число больше 0 ");
}     
int[] arr = GenerateArray(m,n);
Console.Write($"M = {m} ; N = {n} -> ");
Console.Write(SumNaturalNumber(arr));

