
public class Cat : Animal
{
    public Cat(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Meow";
    }
}