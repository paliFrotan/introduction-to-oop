﻿//The Pigeon extends the base class Bird
public class Pigeon : Bird
{
    public Pigeon(string name, string color) : base(name, color)
    {
    }

    public override void Speak()
    {
        Console.WriteLine($"Yo! I'm {Name} and I'm a {Color} pigeon.");
    }

    public void EatPizza()
    {
        Console.WriteLine("Delicious pizza!");
    }
}
