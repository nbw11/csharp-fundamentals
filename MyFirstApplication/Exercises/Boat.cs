namespace MyFirstApplication;
// Exercise 10 Encapsulation 2/10

/*
  2. Create a class based on your Boat object. You will follow the same instructions as 
 exercise 1 except for the following. Include your attributes as Expression Body Definition
 Properties.
*/
internal class Boat
{
    private string _type;
    private string _name;
    private int _height;
    private int _length;
    
    // properties
    public string Type
    {
        get => _type;
        set => _type = value;
    }
    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int Height
    {
        get => _height;
        set => _height = value;
    }

    public int Length
    {
        get => _length;
        set => _length = value;
    }
    public Boat(string _type, string _name, int _height, int _length)
    {
        Type = _type;
        Name = _name;
        Height = _height;
        Length = _length;
    }

    public Boat(string _name, int _height)
        : this("Yacht", _name, _height, 150)
    { }

    public Boat()
        : this("Stallion", 10)
    { }

}
