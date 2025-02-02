using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog("Buddy"),
            new Cat("Whiskers")
        };

        foreach (var animal in animals)
        {
            animal.MakeSound();
            animal.Describe();

            if (animal is IPet pet)
            {
                pet.Play();
            }

            Console.WriteLine();
        }
    }
}
