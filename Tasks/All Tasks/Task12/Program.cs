namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Box = new Box<int>();
            Box.setvalue(10);
            int value = Box.getvalue();
            Console.WriteLine( value );

            var Box1 = new Box<string>();
            Box1.setvalue("teqsti");
            string value1 = Box1.getvalue();
            Console.WriteLine( value1);
            
            // მეორე დავალების ტესტი

            List<string> list = new List<string>();
            list.Add("Mebo");
            list.Add("Mebo2");
            int numberOfElements = Utility.getelementnumber<string>(list);
            Console.WriteLine(numberOfElements);
        }

    }
}
