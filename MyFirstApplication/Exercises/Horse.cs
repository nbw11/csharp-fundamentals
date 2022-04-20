namespace MyFirstApplication;
// Exercise 10 Encapsulation 1/2

/*
  1. Create a class based on your Horse object. Include your attributes as auto 
 properties. Create 3 constructors. The first constructor should have parameters
 equal to your properties Assign each parameter to your properties. The second constructor
 should have 2 parameters. Using the :this() keyword, you will pass 2 default values in 
 that will pass to the 2nd constructor. Also include in the class, your method for Horse.
*/
internal class Horse  
{
    // properties
    public string Breed { get; init; }
    public string Name { get; init; }
    public string Color { get; init; }
    public int Height { get; init; }

    
    public Horse(string breed, string name, string color, int height)
    {
        Breed = breed;
        Name = name;
        Color = color;
        Height = height;
    }

    public Horse(string name, int height)
        : this("Clydsdale", name, "Brown", height)
    { }

    public Horse()
        :this("Craigory", 8)
    { }
}
