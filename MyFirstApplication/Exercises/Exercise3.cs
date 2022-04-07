
namespace MyFirstApplication;

internal class Exercise3
{   
    /* 1. Write a method that takes 1 int argument and an int return type. Utilize the modulus operator 
      to complete this task. Assign the data values below to their own variables. Use the Console WriteLine
      statement on the first 4 variables listed below and calculate the modulus with the passed in 
      argument parameter. Using the last variable below, calculate the modulus with the passed in argument
      parameter and return it.
        a. 15
        b. 456
        c. 23
        d. 89
        e. 245
    */
    public int ExerciseThreeDashOne(int value)
    {
        int var1 = 15;
        int var2 = 456;
        int var3 = 23;
        int var4 = 89;
        int var5 = 245;
        Console.WriteLine(var1 % value);
        Console.WriteLine(var2 % value);
        Console.WriteLine(var3 % value);
        Console.WriteLine(var4 % value);
        return var5 % value;

    }
    /* 2. Write a method that takes no arguments and a void return type. Utilizing
      the math problem in this task, fill in any missing pieces to get the output.
      10 + 32 * 12 / 3 Write a Console WriteLine to solve each output.
        a. Output: 138 
        b. Output: 168
        c. Output: 131
      */ 
    public void ExerciseThreeDashTwo()
    {
        int outPutA = 10 + 32 * 12 / 3;
        Console.WriteLine(outPutA);
        int outPutB = (10 + 32) * 12 / 3;
        Console.WriteLine(outPutB);
        int outPutC = 10 + 32 * 12 / 3;
        Console.WriteLine(outPutC);
    }

    /* 3. Write a method that takes two short type arguments and a void return type. Using the Compound Assignment operators
      below, use the first argument parameter as the left operand to get the result. Print each one using the Console
      WriteLine statement.
        a. +=
        b. -=
        c. *=
        d. %=
    */
    public void ExerciseThreeDashThree(short a, short b)
    {
        Console.WriteLine(a += b);
        Console.WriteLine(a -= b);
        Console.WriteLine(a *= b);
        Console.WriteLine(a %= b);
    }

    /* 4. Write a method that takes two bool type arguments and a void return type. Using Boolean Logical operators &, |,
      ^, and || to complete this task. Use a Console WriteLine statement to calculate each result using the operators. The 
      second argument is the left operand. Use the below values when testing your method. Using comments, provide your
      output results inside the method after your statements.
        a. Argument1 = true, Argument2 = false
        b. Argument1 = false, Argument2 = false
        c. Argument1 = true, Argument2 = true
        d. Argument1 = false, Argument2 = true
    
    */
    public void ExerciseThreeDashFour(bool arg, bool arg2)
    {
        Console.WriteLine(arg2 & arg);
        Console.WriteLine(arg2 | arg);
        Console.WriteLine(arg2 ^ arg);
        Console.WriteLine(arg2 || arg);
    }
}
