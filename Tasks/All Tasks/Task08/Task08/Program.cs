
namespace Task08;

internal class Program
{
    static void Main(string[] args)
    {
        //ორი  ცვლადის შექმნა და მნიშვნელობის მინიჭება

        string name = "Mebo";
        int age = 38;

        // ობიექტის შექმნა

        Person person1 = new Person(name, age);

        //ახალი ობიექტის შექმნა და შენახვა

        Person person2 = person1;

        //ობიექტზე ველების მნიშვნელობების შეცვლა

        person2.Age = 30;
        person2.Name = "Salome";


        //რომ ვნახოთ სად რა ხდება

        Console.WriteLine($"name: {name}");
        Console.WriteLine($"age: {age}");
        Console.WriteLine($"person1Name: {person1.Name}");
        Console.WriteLine($"person1Age: {person1.Age}");
        Console.WriteLine($"person2Name: {person2.Name}");
        Console.WriteLine($"person2Age: {person2.Age}");


    }

}