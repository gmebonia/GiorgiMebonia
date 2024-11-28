
namespace Task11
{
    internal class Counter
    {
        private static int count = 0;

        public Counter ()
        {
            count ++; //მნიშვნელობის ერთით გაზრდა 
            //count = count + 1; //მნიშვნელობის ერთით გაზრდა მეორენაირად

        }
        public static int GetCount() //ქაუნთ მნიშვნელობის დაბრუნება
        {
            return count;
        }
        public static void ResetCount() //ქაუნთ მნიშვნელობის ნოლზე დაბრუნება
        {
            count = 0;
        }

    }
}
