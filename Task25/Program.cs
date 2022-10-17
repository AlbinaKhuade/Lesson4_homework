// Задача 25: Напишите цикл, который
// принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// // 2, 4 -> 16

Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0) 
{
    int exp = ExpInt(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {exp}");
}
else if (numberB < 0) 
{
    double exp = ExpNegative(numberA, numberB);
    Console.WriteLine($"{numberA}, {numberB} -> {exp}");
}
else if (numberB == 0)
{
    int exp = 1;
    Console.WriteLine($"{numberA}, {numberB} -> {exp}");
}

int ExpInt(int numA, int numB)   // метод для возведения в натуральное число
{
    int res = 1;
    for (int i = 1; i <= numB; i++)
    {
        res = res * numA;
    }
    return res;
}

double ExpNegative(int numA, int numB)   // метод для возведения в отрицательное число
{
    double res = 1;
    for (int i = -1; i >= numB; i--)
    {
        res = res * (1 / (double)numA);
    }
    res = Math.Round(res, 3, MidpointRounding.ToZero);
    return res;
}

