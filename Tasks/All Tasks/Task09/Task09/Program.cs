
// შევქმნათ abstract class Animal, IAnimal interface იმპლემენტაციისთვის

public abstract class Animal : IAnimal
{
    public string Name { get; private set; }
    public int Age { get; private set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public abstract string MakeSound();
}

public interface IAnimal
{
    string MakeSound();
}