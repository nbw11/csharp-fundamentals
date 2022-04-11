namespace MyFirstApplication;
// Control Flow Exercise
internal class Exercise4
{
/* 1. Write a method that takes 2 string arguments and avoid return type. Using an if-else 
  statement, compar the two strings to each other. Using a Console WriteLine statement, print
  out the results of whether the strings are equal. Provide a comment inside the method that 
  says what strings you used during testing.*/
public void ExerciseFourDashOne(string value, string value2)
    {
        // I used "hello" twice to get a match and "hello" with "world" to get my else.
        if (value == value2)
            Console.WriteLine($"{value} is the same as {value2}");
        else
            Console.WriteLine("These dont match.");
    }


    /* 2. Write a method that will take 1 char argument and a string return type. Using a switch and the
      table below, return the description. If the value does not match the grade, return the default message
      "Not a valid grade.".
        E. Excellent
        V. Very Good
        G. Good
        A. Average
        F. Fail
     */
    public string ExerciseFourDashTwo(char myGrade)
    {
        switch(myGrade)
        {
            case 'E':
                return "Your grade was Excellent";
            case 'V':
                return "Very Good";
            case 'G':
                return "Good";
            case 'F':
                return "Failed";
            default:
                return "Not a valid grade";

        }
    }

    /* 3. Write a method that takes no arguments and a void reutrn type. Using an iteration
      statement, display all the numbers divisible by 3 from 0 to 30. Utilize a modulus to obtain
      your results.
     */

    public void ExerciseFourDashThree()
    {
        int threes = 3;
        while(threes < 31)
        {
            if(threes % 3 == 0)
            Console.WriteLine($"Numbers divisble by three = {threes}");
            threes += 3;
        }
    }
}