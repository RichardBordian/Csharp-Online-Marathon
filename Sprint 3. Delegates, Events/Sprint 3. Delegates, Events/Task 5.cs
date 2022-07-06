﻿//Define an event  Show of EventHandler type.
//Define four static methods: Dog(), Cat(), Mouse(), Elephant().Each method outputs the corresponding inscription of an animal: "Dog", "Cat", "Mouse" or "Elephant".
//Define the class EventProgram and constructor with these four method instances added to the invocation list of Show event. Invoke event out of the constructor. 

public delegate void EventHandler();
class EventProgram
{
    public event EventHandler Show;
    public EventProgram()
    {
        Show += Dog;
        Show += Cat;
        Show += Mouse;
        Show += Elephant;

        Show.Invoke();
    }

    public static void Dog()
    {
        Console.WriteLine("Dog");
    }
    public static void Cat()
    {
        Console.WriteLine("Cat");
    }
    public static void Mouse()
    {
        Console.WriteLine("Mouse");
    }
    public static void Elephant()
    {
        Console.WriteLine("Elephant");
    }
}

