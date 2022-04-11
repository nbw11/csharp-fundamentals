namespace MyFirstApplication;
internal class Exercise5
{
    /* 1. Write a Method that takes 2 int parameters and an int return type. Using
      the formula below from Ohm's law determine the voltage. The first method parameter
      will represent current and the second parameter will represent resistance. Using the Fun<int, int, int>
      and a Lambda expression, determine the voltage calculation and return the value.
        a. Voltage = Current x Resistance */

    public int ExerciseFiveDashOne(int value, int value2)
    {
        Func<int, int, int> volt = (value, value2) => value * value2;
        return volt(value, value2);
    }

    /* 2. Write a method that will take 1 char parameter and a string return type.
      Using a switch expression and the table below, return the description. If
      the value does not match the grade, return the default message, "Not a valid
      grade.".
        E. Excellent
        V. Very Good
        G. Good
        A. Average
        F. Fail
    */

    public string ExerciseFiveDashTwo(char charval)
    {
        switch (charval)
        {
            case 'E':
                return "Excellent Grade!";
            case 'V':
                return "Very Good Grade!";
            case 'G':
                return "Good Grade";
            case 'A':
                return "Average Grade";
            case 'F':
                return "Failing Grade";
            default: return "Not a valid grade";
        }
    }
    /* 3. Write a method that takes 1 argument and a void return type. Using a 
          relational pattern and a switch expression determine a size of  popcorn
          based on the table below and using a Console WriteLine, print the popcorn
          size.
                Less or equal 3 - Microwave bag
                Less or equal 16 - Movie Sack 
                Less or equal 32 - Movie Cup 
                Less or equal 64 - Movie Tub
                Default - We don't have that size.
    */
    public void ExerciseFiveDashThree(int value)
    {
        string cupsize = value switch
        {
            <= 3 => "Microwave bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We dont have that size."
        };
        Console.WriteLine(cupsize);
    }



}

