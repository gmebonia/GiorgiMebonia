
int Number = 0;
int Sum = 0;
string EnteredNumber = "";

while (Number >= 0)
{
    Console.WriteLine("Enter Number");
    Number = int.Parse(Console.ReadLine());
    if (Number > 0) 
    {

        Sum = Sum + Number;
        
    }

    EnteredNumber += Number + ";";

}
   
Console.WriteLine("Enter Numbers: " + EnteredNumber);
Console.WriteLine("Sum:" + Sum);