namespace MyFirstApplication;
// Exercise 8 - Constants & Static

/*
  1. Write a constant at the class level. The constant should Foot with a value of 12
 to represent the number of inches in a foot. Write a method that takes 1 int parameter and 
 a void return type. This method will convert feet to inches. The formula that you would use
 will be the parameter * Foot. Your parameter will represent the number of feet to convert
 to inches. Using a console WriteLine statement, print the results. Test your method using the
 number 3 to see fi you get 36
*/

internal class Exercise8
{
    public const int Foot = 12;
    public void ExerciseEightDashOne(int arg)
    {
        int inches = arg * Foot;
        Console.WriteLine(inches);
    }


    /*
      2. Write a static method that takes 2 int parameters and a void return type. 
     This method will be used to calculate the length and width of a rectangle/square
     This formula is length x width. The first parameter should represent the length 
     and the second parameter should be the width. Using a Console WriteLine statement,
     print the results. Test your method and add what you use to test as a comment,
     before or after the method. 
    */

    // I used 12, and 12 to test and got 144 as the area. 
    public static void ExerciseEightDashTwo(int value, int value2)
    {
        int area = value * value2;
        Console.WriteLine($"The area of the shape is {area}");
    }
}