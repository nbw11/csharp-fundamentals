
namespace MyFirstApplication;

/* 
 This Class goes over Value Types
 */
internal class Lesson1
{
    // Intergral Signed

    // sbyte range is -128 to 127
    sbyte mySbyte = 2;

    public void SByteMinMax()
    {
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValue);
    }

    // short range -32,768 to 32,767
    short myShort = 6;

    public void ShortMinMax()
    {
        Console.WriteLine(Int16.MinValue);
        Console.WriteLine(Int16.MaxValue);
    }

    // int range -2,147,483,648 to 2,147,483,647
    int myInt = 25685;

    public void IntMinMax()
    {
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
    }

    // Long Range is -9,223,372,436,854,775,808 to 
    // 9,223,372,036,854,775,807
    long myLong = 123456789L;

    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }

    // Integral Unsigned

    // byte range 0 - 255
    byte myByte = 4;

    public void ByteMinMax()
    {
        Console.WriteLine(Byte.MinValue);
        Console.WriteLine(Byte.MinValue);
    }

    // ushort range 0 - 65,535
    ushort myUShort = 43;

    public void UShortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }

    // uint range 0 -4,294,967,295
    uint myUInt = 4532U;

    public void UIntMinMax()
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }

    // ulong range 0 - 18,446,744,073,709,551,615
    ulong myULong = 948372UL;

    public void ULongMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }

    // Floating Point / rea Numbers

    // float range 3.4E +/- 38
    float myFloat = -123.6589F;

    public void FloatMinMax()
    {
        Console.WriteLine(Single.MinValue);
        Console.WriteLine(Single.MaxValue);
    }

    // double range 1.7E +/- 308
    double myDouble = 12.34D; 

    public void DoubleMinMax()
    {
        Console.WriteLine(Double.MinValue);
        Console.WriteLine(Double.MaxValue);
    }

    //decimal range -7.9228E+24 to 7.9228E+24
    decimal myDecimal = 13.23M;

    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }

    // Intergral Literals
    public void IntegralExample()
    {
        // value of 26
        int value1 = 26;
        int value2 = 0x1A; // hexadecimal
        int value3 = 0b11010;
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
       
    }

    // Scientific notation
    double alpha = 6.26E-22;

    // Underscores
    long beta = 1_834_432L;


    // Explicit casting is wher fractions are truncated and not rounded
    // you have to provide permission to cast from a higher type
    // to a lower type.
    public void ConvertFloatToInt()
    {
        int converted = (int)myFloat;
        Console.WriteLine(converted);
    }

    // Implicit cast requires not direct permission
    public void LongFromInt()
    {
        long someValue = myInt;
        Console.WriteLine(someValue);
    }

        }

