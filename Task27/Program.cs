// Задача 27: Напишите программу, которая
// принимает на вход число и
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = Sum(number);
Console.Write($"{number} -> {sum}");

int Sum(int num)
{
    int temp = 0;    // вводим переменную для промежуточных расчетов
    int res = 0;
    while (num > 0)
    {
        temp = num % 10;
        num = num / 10;
        res += temp;
    }
    return res;
}