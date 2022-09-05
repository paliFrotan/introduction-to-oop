internal class Program
{
    private static void Main(string[] args)
    {
        //Bird myBird = new("Tweety", "Yellow");
       // myBird.Speak();
       // myBird.Fly();
        Pigeon pippa = new("Pippa", "Grey");
        pippa.Speak();
        pippa.Fly();
        pippa.EatPizza();

        pippa.Spin();
        pippa.DoTheCaterpillar();
        pippa.Jump();

        Penguin pingu = new Penguin("Pingu", "Black & White");
        pingu.Speak();
        pingu.Fly();

        pingu.Spin();
        pingu.DoTheCaterpillar();
        pingu.Jump();

        //Parrot polly = new Parrot("Polly", "Tropical");
        //polly.Speak();
        //polly.Fly();
    }
}