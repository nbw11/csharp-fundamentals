namespace MyFirstApplication;
/* Exercise 13 Abstracts & Interfaces */

/* 1. 
 In your exercise 13 file, change your class to an Interface and anme it IMovement. this interface
 will have 1 property. The property will be an int called Speed. It will have a get and an init. 
*/
internal interface IMovement
{
    int Speed { get; init; }

    string Exercise13Dash1();
}// end interface

/* 2.
 Under the interface you will create an Abstract class called WaterBirds. This abstract class will implement 
 the IMovement interface. The interface property should be implemented in the Abstract class as an abstract property.
 Create two abstract methods for the abstract class that is related to WaterBirds. Create a constructor that will take
 an int parameter and be assigned to the Speed property.
*/
public abstract class WaterBirds : IMovement
{
    public abstract int Speed { get; init; }

    
    protected WaterBirds(int speed)
    {
        Speed = speed;
    }
    
    public abstract string Exercise13Dash1();
    public abstract string Exercise13Dash2();

    

}// end class
    
/* 
  3. Under the Abstract class WaterBirds, create a derived class that will extend the WaterBird class.
  Implement the bastact methods and property. Use console WriteLine statements in your methods that provide
  information related to the methods. One of them should use an interpolation string and consume the Speed property.
  Create a constructor that will take an int parameter and the :base() to pass that int value back to the base
  Abstract class.
*/

public class WaterBirdsDerived : WaterBirds
{
    public override int Speed { get; init; } = 20;

    public override string Exercise13Dash1()
    {
        Console.WriteLine("Birds Fly");
        return String.Format("Birds Fly!");
    }

    public override string Exercise13Dash2()
    {
        throw new NotImplementedException();
    }


    protected WaterBirdsDerived(int value)
   : base(value) { }

} // end class 
