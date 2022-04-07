using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Below statement calls a local function
// single line comment

BottlesOfBeer bottles = new BottlesOfBeer();
// bottles.LetsSing();


/*
 Multi-line comment
the below statement is a local function. Local functions
are inside of members and areprivate by default. This means
they are specific to that member and can only be called 
by that member
*/

// Lesson Examples
// HouseExample();
// Lesson1Example();
// Lesson2Example();
// Lesson3Example();

// Lesson 3 Operators and Overflow Checking
void Lesson3Example()
{ 
    Lesson3 myLesson3 = new Lesson3();
    // myLesson3.BasicCheckedOperator(14);
    // myLesson3.BasicCheckedExample2;
    // int alpha = 2147483647;
    // int total = alpha + 10;
    // Console.WriteLine(total);
    // -2147483639
    // myLesson3.BasicUncheckedExample();
    // myLesson3.BasicMath();
    // myLesson3.BasicModulus(783);
    // myLesson3.BasicBooleanLogical(true, false);
    //myLesson3.BasicCompoundExample(12, 35, 9);
    // myLesson3.BasicRelationalExample("Tom", "Tom");
    // myLesson3.MyIncrDecrExample();

}

// Lesson2 Strings
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}

void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}

// Lesson 1 Value Types
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}
/* This local function is for my first 
 * exercsise lab.*/

void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool.");
    Console.WriteLine("I am learning stuff every day.");
}

// MyLocalFunction();

// Exercise 1 Test
// Exercise1Test();

void Exercise1Test()
{
    Exercise1 myOne = new Exercise1();
    myOne.DecimalExMethod();
    myOne.ConversionImMethod(4, 5, 8);

}

// Exercise 2 Test
// Exercise2Test();

void Exercise2Test()
{ 
    Exercise2 mytwo = new Exercise2();
    mytwo.ExerciseTwoDashOne(" EXERCISE two Lab ");
    mytwo.ExerciseTwoDashTwo();
    mytwo.ExerciseTwoDashThree();
    Console.WriteLine(mytwo.ExerciseTwoDashFour());

}

// Exercise 3 test
// Exercise3Test();

void Exercise3Test()
{
    Exercise3 mythree = new Exercise3();
   // mythree.ExerciseThreeDashOne(5);
   // mythree.ExerciseThreeDashTwo();
   // mythree.ExerciseThreeDashThree(4, 6);
   // mythree.ExerciseThreeDashFour(true, false);
   // mythree.ExerciseThreeDashFour(false, false);
   // mythree.ExerciseThreeDashFour(true, true);
   // mythree.ExerciseThreeDashFour(false, true);

}




