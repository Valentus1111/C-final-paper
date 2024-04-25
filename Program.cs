/*
Задача 1: Задайте значения M и N. 
Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Использовать рекурсию, не использовать циклы.
*/
/*
System.Console.WriteLine("Введите число M"); //4
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N"); //8
int N = Convert.ToInt32(Console.ReadLine());
int SumMN(int M, int N)
{
    if (M == N)
    return M;
    else
    return (M + SumMN(M + 1, N));
}
int result = SumMN( M,N);
System.Console.WriteLine(result);
*/



/*
Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
*/
/*
System.Console.WriteLine("Введите неотрицательное число m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите неотрицательное число n");
int n = Convert.ToInt32(Console.ReadLine());

int result = AckermanNum(m, n);
Console.Write($"Функция Аккермана = {result} ");
int AckermanNum(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return AckermanNum(m - 1, 1);
    else
        return AckermanNum(m - 1, AckermanNum(m, n - 1));
}
*/

/*
Задача 3: Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/
/*
char[] arr = { 'h', 'e', 'l', 'l', 'o' };
void PrintArray(char[] arr, int index)
{
    if (index < 0)
        return;
    else
    {
        System.Console.Write(arr[index] + " ");
        PrintArray(arr, index - 1);
    }
}
PrintArray(arr, arr.Length - 1);
*/
