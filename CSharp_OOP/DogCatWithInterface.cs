using System;

public class Dog : Animal, IPet
{
    public Dog(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bark");
    }

    public override void Describe()
    {
        Console.WriteLine($"This is a dog named {Name}. It loves to fetch the ball.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is fetching the ball.");
    }
}

public class Cat : Animal, IPet
{
    public Cat(string name) : base(name) { }

    public override void MakeSound()
    {
        Console.WriteLine("Meow");
    }

    public override void Describe()
    {
        Console.WriteLine($"This is a cat named {Name}. It enjoys chasing laser pointers.");
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is chasing the laser pointer.");
    }
}
