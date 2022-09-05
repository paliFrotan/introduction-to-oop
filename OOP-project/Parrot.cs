public class Parrot : Bird
{
    public Parrot(string name, string color) : base(name, color)
    {
    }

    public override void Speak()
    {
        Console.WriteLine($"Who's a pretty boy?");
    }

    
}
