
using System;

// שלב 1: מחלקת בסיס
class Animal
{
    public string? Name { get; set; }
    public int Weight { get; set; }

    public virtual string SayHello()
    {
        return "Say Hello";
    }
}

// שלב 2: מחלקות יורשות

class Dog : Animal
{
    public override string SayHello()
    {
        return "Woof Woof";
    }
}

class Cat : Animal
{
    public override string SayHello()
    {
        return "Myau Myau";
    }
}

class Donkey : Animal
{
    public override string SayHello()
    {
        return "Ia Ia";
    }
}

// שלב 4: מחלקה ראשית
class Program
{
    // מתודה סטטית שמקבלת Animal
    static void SayHello(Animal animal)
    {
        Console.WriteLine(animal.Name + ": " + animal.SayHello());
    }

    static void Main(string[] args)
    {
        // שלב 3: יצירת אובייקטים

        Dog dog = new Dog()
        {
            Name = "Buddy",
            Weight = 14
        };

        Cat cat = new Cat()
        {
            Name = "Kitty",
            Weight = 5
        };

        Donkey donkey = new Donkey()
        {
            Name = "Jack",
            Weight = 120
        };

        // שלב 4: הפעלת פולימורפיזם

        SayHello(dog);
        SayHello(cat);
        SayHello(donkey);
    }
}

