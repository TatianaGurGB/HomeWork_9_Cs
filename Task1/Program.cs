// Задайте значения M и N. Напишите программу, 
//которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

void ValueSet (int m, int n)
{
    if (n < m) return;
    if (m % 2 == 1) m += 1;
    Console.Write($"{m}, ");
    ValueSet(m + 2, n);
}

ValueSet(1, 8);
