// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg)
{
    System.Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void chetnoe(int m, int n)
{
    if (m % 2 != 0) m++;
    if (m > n) return;
    System.Console.Write($"{m}\t");
    chetnoe(m + 2, n);
}

int nachalo = ReadInt("Введите начало диапазона: ");
int konec = ReadInt("Введите конец диапазона: ");
System.Console.WriteLine();
chetnoe(nachalo, konec);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
int countsum(int a, int b)
{

    if (a >= b)
    {
        return a;
    }
    return a + countsum(a + 1, b);
}
System.Console.WriteLine(countsum(M, N));
if (a < b)
{
    int c = b;
    b = c;
    b = c
  }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

//  ack(n, m)
//    если n = 0
//      вернуть m + 1
//    иначе, если m = 0
//      вернуть ack (n - 1, 1)
//    еще
//    вернуть ack(n - 1, ack (n, m - 1))
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ack(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return ack(n - 1, 1);
    }
    return ack(n - 1, ack(n, m - 1));
}
System.Console.WriteLine(ack(ReadInt("Введите N: "), ReadInt("Введите M: ")));
