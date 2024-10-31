int WeekDay = 0;
Console.Write("Hello, Enter number (1-7): ");
WeekDay = int.Parse(Console.ReadLine());

switch (WeekDay)
{
    case 1:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Monday");
        break;
    case 2:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Tuesday");
        break;
    case 3:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Wednesday");
        break;
    case 4:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Thursday");
        break;
    case 5:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Friday");
        break;
    case 6:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer: Saturday");
        break;
    case 7:
        Console.WriteLine("Entered number:" + WeekDay);
        Console.WriteLine("Answer:Sunday");
        break;
    default:
        Console.WriteLine("Incorrect number");
        break;
}
