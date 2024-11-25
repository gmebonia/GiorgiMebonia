       // ცხოველების მასივის შექმნა
public class Program
{
    public static void Main(string[] args)
    {
        IAnimal[] animals = new IAnimal[]
        {
            new Dog("ძაღლი", 1),
            new Cat("ფისო", 2),
            new Cow("ძროხა", 3)
        };

        // დაიბეჭდოს ცხოველები და რა ხმას გამოსცემენ
        foreach (IAnimal animal in animals)
        {
            Console.WriteLine($"{animal.GetType().Name} says: {animal.MakeSound()}");
        }
    }
}