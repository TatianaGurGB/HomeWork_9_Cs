// Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int ValueSet (int m, int n)
{
    if (n < m) return 0;
    return ValueSet(m, n - 1) + n;
}

Console.WriteLine(ValueSet(1, 6));
