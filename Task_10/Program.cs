// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
int result;


if (num < 100 || num >999)
{
    Console.Write("Введено некорректное число");
}
else
{
    // result = (num - num / 100 * 100 - num % 10) / 10; (Исходный вариант)
    result = num / 10 % 10; 

    Console.WriteLine(result);
}
