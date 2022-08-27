// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number < 1 || number > 7)
{
    Console.Write("Введено некорректное число");
}
else if (number == 6 || number == 7)
{
    Console.Write("Выходной день: ");
}
else
{
    Console.Write("Будний день: ");
}

switch (number)
{
    case 1:
    {
        Console.Write("Понедельник");
        break;
    }
    case 2:
    {
        Console.Write("Вторник");
        break;
    }
    case 3:
    {
        Console.Write("Среда");
        break;
    }
    case 4:
    {
        Console.Write("Четверг");
        break;
    }
    case 5:
    {
        Console.Write("Пятница");
        break;
    }
    case 6:
    {
        Console.Write("Суббота");
        break;
    }
    case 7:
    {
        Console.Write("Воскресенье");
        break;
    }
}
