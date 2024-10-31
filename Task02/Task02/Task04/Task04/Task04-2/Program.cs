int Number = 0;
int Result = 0;
Number = int.Parse(Console.ReadLine());
Console.WriteLine("Entered Number:" + Number);
Console.WriteLine("Answer:");

for (int i = 1; i < 11; i++)
{
    Result = i * Number;
    Console.WriteLine(Number + "*" + i + "=" + Result);   
}