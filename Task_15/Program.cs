// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine()!);

if (number < 1 || number > 7)
{
    Console.Write("Введено некорректное число");
}
else if (number == 6 || number == 7)
{
    Console.Write("Выходной: ");
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
        Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда");
        break;
    }
    case 4:
    {
        Console.WriteLine("Четверг");
        break;
    }
    case 5:
    {
        Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        Console.WriteLine("Воскресенье");
        break;
    }
}
