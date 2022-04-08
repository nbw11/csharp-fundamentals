namespace MyFirstApplication;

internal class Exercise1
{
    /* 1. Write out a method with no arguments and a void return type that will print the output
of the number 35 based on the number systems below. The values should be assigned to a variable inside
the method prior to printing them using Console WriteLine. Utilize the conversion document from your
resources. 
a. Decimal 
b. Hexadecimal 
c. Binary */

    double myDouble = 10.5;
    long myLong = 132_254;
    float myFloat = 1.234F;
    int myInt = 250;
    byte myByte = 4;
    short myShort = 5;
    public void DecimalExMethod()
    {
        int thirtyfive = 35;
        int thirtyfive1 = 0x23A;
        int thirtyfive2 = 0b00100011;
        Console.WriteLine(thirtyfive);
        Console.WriteLine(thirtyfive1);
        Console.WriteLine(thirtyfive2);
    }

    /* 2. Write a method that will accept 3 arguement parameters and a void return type. The first argument should be
     of type byte. The second argument should be of type short. The third argument type should be of type int.
    Using implicit conversion, create variables to conver to using the below information. Use the 
    argument parameters as the values to convert from. Print each converted variable using Console WriteLine
    a. From byte to int
    b. From short to long
    c. From int to float */

    
    public void ConversionImMethod(byte value, short value1, int value2)
    {
       
        int alpha = value;
        long beta = value1;
        float kappa = value2;
        Console.WriteLine(alpha);
        Console.WriteLine(beta);
        Console.WriteLine(kappa);
        
    }

    /* 3. Write a method that will accept 3 argument parameters and a void return type. The first
     argument should be of type double. The second argument should be of type float. 
     The third argument should be of type long. Using Explicit conversion, create variables
     to convert to using the below information. Use the argument parameters as the values to convert
     from. Print each converted variable using Console WriteLine.
        a. From double to long
        b. From float to int
        c. From long to short */
    
    public void ConversionExMethod(double value3, float value4, long value5)
    {
        long theta = (long)value3;
        int zeta = (int)value4;
        short omega = (short)value5;
        Console.WriteLine(theta);
        Console.WriteLine(zeta);
        Console.WriteLine(omega);

    }

    /* 4. Write a method with no arguments and a void reutrn type. Using the values below, 
     assign them to a variable that best suits their value type. Utilize the digit separator
     when assigning them to your variables. Once you have defined you variables, print out each one using Console WriteLine
     Do not use the same value type more than once. 
        a. 123456.987
        b. -9516248
        c. 3500
        d. 988562486
        e. -19733.14895
   */

    public void ValueType()
    {
        double doubleA = 123_456.987;
        Console.Write(doubleA);
        int intA = -9516248;
        Console.Write(intA);
        short shortA = 3500;
        Console.WriteLine(shortA);
        long longA = 123_345_456;
        Console.WriteLine(longA);
        float floatA = -19733.14895F;
        Console.WriteLine(floatA);
        
    }

} // end class 
