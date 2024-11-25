
public class Cow : Animal
{
    public Cow(string name, int age) : base(name, age) { }

    public override string MakeSound()
    {
        return "Moo";
    }
}