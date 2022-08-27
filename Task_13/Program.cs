// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int count = 1000;
int check = 100;
int num = 10;

if (number / check == 0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while (number > count)
    {
    number = number / num;
    }
    Console.WriteLine(number = number % num);
}
