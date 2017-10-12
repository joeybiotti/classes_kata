using System;

class Car
{
    private string name;
    public Car (string name)
    {
        this.name = name; 
    }
    public string GetName()
    {
        return name; 
    }
    public void Start()
    {
        Console.WriteLine("The car has started");
    }
}