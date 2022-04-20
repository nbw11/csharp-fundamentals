namespace MyFirstApplication;
// Exercise 11  2/2
/* Create a child class based on your Boat object. You will follow the same instructions
  as exercise1 except for the following. Include 1 child attribute as expression body
  definition properties. */
internal class Yacht : Boat
{
    private string amenities;

    public string Amenities 
    {  
        get => amenities;
        set => amenities = value;
    }

    public Yacht(string type, string name, int height, int length, string amenities )
        : base(type, name, length, height)
    {
        Amenities = amenities;
    }

    public Yacht(string type, string name)
        : this(type, name, 20, 60, "Luxury Cabin")
    { }

    public Yacht()
        : this("yacht", "uss yachty")
    { }

}

