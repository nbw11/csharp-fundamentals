namespace MyFirstApplication;
// Structs and Records

/*
  1. Change the type from class to struct. Change the name of the struct from Exercise7 to Employee. 
 The filename should not be changed. Create 2 struct variables. The first one will be of type int
 and named _id. The second variable should be of type string and be named _name. Create a constructor
 that takes 2 arguments, with the first being an int and the second a string. The struct variables 
 should be assigned to the constructor parameters. Create properties for these 2 variables.
*/
internal struct Employee
{
    private int _id;
    private string _name;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Employee(int arg, string arg2)
    {
        _id = arg;
        _name = arg2;
    }
}

/* 
   2. Create a Record based on your boat object from the Object Oriented Programming lesson.
  In your Record body, include the boat method that you defined. This record can be in the same
  file as exercise 1. Just put the code under it as seen in the lecture. Test your record to ensure
  it is working correctly. 
 */

public record Boat()
{
    internal void MeBoat()
    {
        Console.WriteLine("Boat Floats");
    }
}


