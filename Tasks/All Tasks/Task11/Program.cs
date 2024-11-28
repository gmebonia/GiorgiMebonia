
namespace Task11 
{
    public class Program
    {
        static void Main(string[] args)

        {
            //ქაუნთერის გატესტვა

            var counter1 = new Counter();
            Console.WriteLine("Count1: " + Counter.GetCount());
            Counter.ResetCount();
            Console.WriteLine("Count after reset: " + Counter.GetCount());
            var counter2 = new Counter();
            Console.WriteLine("Count2: " + Counter.GetCount());
            var counter3 = new Counter();
            Console.WriteLine("Count3: " + Counter.GetCount());


            //Math Helper-ის გატესტვა

            var result1 = Mathhelper.Add(2, 9);
            var result2 = Mathhelper.Subtract(4, 2);
            var result3 = Mathhelper.Multiply(3, 7);
            var result4 = Mathhelper.Divide(3, 2);
            Console.WriteLine($"Add(2 + 9) = {result1}");
            Console.WriteLine($"Subtract(4 - 2) = {result2}");
            Console.WriteLine($"Multiply(3 * 7) = {result3}");
            Console.WriteLine($"Divide(3:2) = {result4}");
            //result4 = Mathhelper.Divide(10, 0);  // ნოლზე გაყოფის შემოწმება 
            //Console.WriteLine($"Divide(10 : 0) = {result4}");
        }
    }
} 

