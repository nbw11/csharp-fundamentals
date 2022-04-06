namespace MyFirstApplication;

internal class Exercise2
{
    /* 1. Write a method that takes a string argument parameter and void return type. Using string
     concatenation and the below string methods, write a Console WriteLine statement for each of them.
     Inside the string concatenation will be the name of each string method. When testing this
     method use the follow string "EXERCISE two Lab".
        a. Trim()
        b. ToLower()
        c. Contains("tow")
        d. Length()
        e. IndexOf('C')
     */

    public void ExerciseTwoDashOne(string value)
    {
        Console.WriteLine("Trim()" + value.Trim());
        Console.WriteLine("ToLower()" + value.ToLower());
        Console.WriteLine("Contains()" + value.Contains("tow"));
        Console.WriteLine("Length" + value.Length);
        Console.WriteLine("IndexOf()" + value.IndexOf('C'));

    }
    /* 2. Write a method that takes no argument and a void return type. Using the Unicode table resource link
     assign the Unicode value of the PIlcrow Sign to a variable. Use the Console WriteLine to print that variable.
     This variable should utilizethe type that takes 1 character.
     */
    public void ExerciseTwoDashTwo()
    {
        char pilcrow = '\u00B6';
        Console.WriteLine(pilcrow);
    }
    /* 3. Write a method that takes no arguments and a void reutrn type. Use 1
      string variable and 1 Console WriteLine to complete this task. Use escape
      sequences to achieve the below results.
        Output:
        Jack and Jill
        went up the hill
        to fetch a pail of water.
        Jack fell down and broke his crown
        and Jill came tumbling after.
    */
    public void ExerciseTwoDashThree()
    {
        string jackandjill = " Jack and Jill\n went up the hill\n to fetch a pail of water.\n Jack felldown and broke his crown.\n and Jill came tumbling after";
        Console.WriteLine(jackandjill);
    }
    /* 4. Write a method that takes no arguments but does have a string return type.
        You will utilize Interpolation to complete this task. Creat Variables
        for each provided data below. Using Interpolation return a string that includes
        the variables in a sentence.
            a. Name
            b. Favorite Movie
            c. Favorite Movie Snack
            d. Favorite Movie Drink
     */
  
    public string ExerciseTwoDashFour()
    {
        string name = "Nick";
        string favemovie = "Avengers";
        string favesnack = "Chips";
        string favedrink = "Soda";
        return $"My name is {name}, my favorite movie is {favemovie}. I love to have {favesnack} and {favedrink} while i watch it.";    
    }
}
