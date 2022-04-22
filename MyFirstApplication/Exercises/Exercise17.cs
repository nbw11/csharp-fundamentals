namespace MyFirstApplication;
// Exercise 17 Exception Handling


internal class Exercise17
{
    /*
     1. Write a method that has two int parameters and no return type. You will use
     a try/catch for this method. Create a division problem in the try block. The 
     Catch block will utilize the DivideByZero exception. Provide a Console WriteLine
     message for both the try block and the catch block. The on in the try blcok should
     display the answer to the division problem. The one in the catch block should have 
     a message using interpolation along with a variable.Message syntax. Test the method
     with different numbers, including zero so you can ensure the catch executes.
     */
    public void Exercise17DashOne(int value, int value2)
    {
        try
        {
            int value3 = value / value2;
            Console.WriteLine($"The value is {value3}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($" The value:{ex.Message}");
        }
    }
    /*
     2. Write a method that has a horse parameter and no return type. Using an if statemnt,
    determine if your horse is null. If it is null, use the throw keyowrd and a message
    to indicate it is null. If the horse is not null, use a Console WriteLine statement to print
    out one of your horse properties. 
    */
    public void Exercise17DashTwo(Horse horse)
    {
        if (horse == null)
        {
            throw new NullReferenceException("Horse is null");
        }
        else
        {
            Console.WriteLine(horse.Breed);
            Console.WriteLine(horse.Color);
            Console.WriteLine(horse.Name);
         }
    }


} // end class
