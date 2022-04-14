namespace MyFirstApplication;


internal class Exercise6
    /* Constructors Methods and More*/
{
    private int _size = 10;
    private string _type = "Nike";

    /* 
     1. Write a constructor for your exercise file that takes 2 parameters. The first
    The first parameter should have an int type and a variable name of shoeSize. The second
    parameter should have string type and a variable name of shoeType. Create private class
    variables for these types and use an underscore when defining them. Inside the constructor
    associate the class variable with the constructor parameters. 
    */
    public Exercise6(int shoeSize, string shoeType)
    {

        // Console.WriteLine($"My {_type} shoes are size {_size}.");

    }
    /*
     2. Wrtie the properties for the calss variables defined in exercise 1. Ensure they are 
      labeled as public and are spelled using a capital letter.
     */

    public string ShoeType
    {
        get { return _type; }
        set { _type = value; }
    }

    public int ShoeSize
    {
        get { return _size; }
        set { _size = value; }
    }

    /*
     3. Write a delegate that takes a string paramenter. This delegate should be named TryOn.
      Write a method that takes a string argument and void return type. In the method body include
      a Console WriteLine statement that will print the message. Test your delegate in Program.cs
      to ensure everything works properly. Using a mult-line comment on your Exercise6.cs file,
      provide the information you used to test the delegate.
    */

    public delegate void TryOn(string type);

    public void ExerciseSixDashThree(string arg)
    {
        Console.WriteLine(arg);
    }
    // I used "Nike" and 10 for my test. 
}
