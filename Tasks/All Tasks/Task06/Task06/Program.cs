//metodebi

int index = 0;
Console.WriteLine("Enter index:");
index = int.Parse(Console.ReadLine());
int[] array = new int[5];
Console.WriteLine("Enter an integer:");

for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(Console.ReadLine());

Console.WriteLine("Result:" + sumNumber(index, array));
static int sumNumber(int index, int[] array)
{
    int num = array[index - 1];
    int sum = 0;
    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}