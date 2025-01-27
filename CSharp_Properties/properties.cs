using System;

class Person
{
    // Auto-implemented property for Name
    public string Name { get; set; }

    private int age;

    // Property for Age with validation logic
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Age must be a positive integer.");
            }
            age = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Create a new Person object
            Person person = new Person();

            // Prompt the user to input the Name
            Console.Write("Enter the person's name: ");
            person.Name = Console.ReadLine();

            // Prompt the user to input the Age
            Console.Write("Enter the person's age: ");
            person.Age = int.Parse(Console.ReadLine());

            // If no exception, print the person's details
            Console.WriteLine($"Person's Name: {person.Name}, Age: {person.Age}");
        }
        catch (ArgumentException ex)
        {
            // Handle invalid age input
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            // Handle invalid format input
            Console.WriteLine("Error: Age must be a valid integer.");
        }
        catch (Exception ex)
        {
            // Handle other unexpected exceptions
            Console.WriteLine($"Unhandled Exception: {ex.Message}");
        }
    }
}
