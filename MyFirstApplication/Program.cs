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
// Lesson4Example();
// Lesson5Example();
// Lesson6Examlpes();
// Lesson7Example();
// Lesson8Example();
// Lesson9Example();
// Lesson10Example();
// HouseUpdated();
// Lesson11Example();
// Lesson12Example();
// CondoExample();
// Lesson13Example();
// Lesson14Example();
// Lesson15Example();
Lesson16Example();

void Lesson16Example()
{
    Lesson16 myLesson16 = new Lesson16();
    myLesson16.MyListExample();
    myLesson16.MyDictionaryExample();
}

void Lesson15Example()
{
    Lesson15 myLesson15 = new Lesson15();
    // myLesson15.EnumExample();
    string flavor = myLesson15.FavoriteIceCream(IceCreamFlavors.Chocolate);
    //Console.WriteLine(flavor);
    // myLesson15.TupleExample();
    (int val1, int val2, int val3) = myLesson15.TupleReturnExample(11, 35);
    Console.WriteLine($"Answers are {val1}, {val2}, {val3}");

}
void Lesson14Example()
{
    Lesson14 myLesson14 = new Lesson14();
    // myLesson14.SingleIntArray();
    // myLesson14.SingleIntArray();
    myLesson14.MultiIntArray();
    myLesson14.MultiStringArray();
    myLesson14.JaggedArraySample();
}

void Lesson13Example()
{
    Lesson13Derived myLesson13 = new Lesson13Derived(3);
    int total1 = myLesson13.ConvertFeetToInches();
    int total2 = myLesson13.ConvertYardsToFeet();
    Console.WriteLine($"Converting feet to inches {total1} ");
    Console.WriteLine($"Converting yards to feet {total2}");

    //These are from the interface
    int total3 = myLesson13.ConvertMilesToYards();
    Console.WriteLine($"Converting miles to yards {total3}"); 
}



void CondoExample()
{
    Condo myCondo = new Condo();
    myCondo.Maintenance();
    myCondo.DoorOpenClose();
    Console.WriteLine(myCondo.RoofType);
}
void Lesson12Example()
{
    Fruit myFruit = new Fruit();
    myFruit.EatFruit();
    myFruit.EatFruit(3);

    Apple myApple = new Apple();
    myApple.EatFruit();
}

void Lesson11Example()
{
    Square square = new Square();
    double total = square.CalculateInteriorAngle();
    Console.WriteLine(total);

    Triangle triangle = new Triangle();
    double total2 = triangle.CalculateInteriorAngle();
    Console.WriteLine(total2);

}
void HouseUpdated()
{
    // Calling default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();

    // Calling Constructor with 2 parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();

    // Calling constructor with 4 parameters
    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();

}


void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();

    // Using this to call another constructor
    Console.WriteLine(myLesson10.FirstName);

    // Normal Property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);
    
    // Calling Auto Property
    // myLesson10.LastName = "Smith"; // only works in Lesson10 constructor
    Console.WriteLine(myLesson10.Id); // Default Value
    myLesson10.Id = 1500;
    Console.WriteLine(myLesson10.Id); // get 1500

    // Expression Body Property 
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // Second constructor 
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.ZipCode);
}

void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}

void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    // Calling Constant Directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate temperature
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));

    // Static Methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The calculation has been done {Lesson8.DayCount} times.");

    // Static Lambda
    myLesson8.CalculateHoursV2();
}

void Lesson7Example()
{
    Location myLocation = new Location(34.5, 37.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // ReadOnly Struct
    Student myStudent = new Student(10, "Nick");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.StudentName);

    // Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.lastName);

    // Struct Record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);

}



void Lesson6Examlpes()
{
    // default Constructor
    Lesson6 myLesson6 = new Lesson6();
    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.Hatsize}");



    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);

    // Constructor with 2 parameters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.Hatsize); // getting value
    myHats.Hatsize = 6; // setting value

    // Method Parameter Modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.InExample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // Multi-cast Delegat
    Lesson6.TryOn theNewHat, hangTheHat, multiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    multiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hangin up my {myLessonHats.HatType} hat");
    multiHat($"My {myLessonHats.HatType} hat");


}

// Lesson 5 Expressions & Pattern Matching
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();

    // Call method of myLesson5
    // myLesson5.IsOperatorExample(34);

    Lesson5.Del handler = myLesson5.DelegateMethod;
    // handler("Hello CSharp");

    // Func delegate
    Func<int, int> add = myLesson5.Sum;
    // Console.WriteLine($"func delegate example = {add(23)}");

    // Lambda Expression
    // myLesson5.LambdaSquare();
    // myLesson5.LambdaGreeting();

    //Switch Expressions
    string value1 = myLesson5.BasicSwitch("red");
    // Console.WriteLine(value1);
    string value2 = myLesson5.FavoriteColor("green");
    // Console.WriteLine(value2);

    // Relational Pattern
    // myLesson5.DrinkSize(33);

    // Logical Patterns
    // myLesson5.TemperatureGuide(48.6);
    // myLesson5.NumberChoice(3);
}


// Lesson 4 Control Flow
void Lesson4Example()
{
    Lesson4 myLesson4 = new Lesson4();
    // myLesson4.BasicIfStatement(11);
    // myLesson4.BasicIfElseStatement(15);
    // myLesson4.BasicIfElseChainStatement(10);
    // myLesson4.BasicAndOrCondition(20, 20);
    // Console.WriteLine(myLesson4.BasicTernaryExample(35));
    // myLesson4.BasicSwitchStatement(3);
    // myLesson4.BasicWhileStatment();
    // myLesson4.BasicDoStatement();
    // myLesson4.BasicForStatement();
    // myLesson4.BasicJumpStatement();

}

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
    // myLesson3.BasicCompoundExample(12, 35, 9);
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
// Exercise 4 Test
// Exercise4Test();
void Exercise4Test()
{
    Exercise4 myfour = new Exercise4();
    myfour.ExerciseFourDashOne("hello", "hello");
    myfour.ExerciseFourDashTwo('E');
    myfour.ExerciseFourDashThree();
}

// Exercise 5 Test
// Exercise5Test();
void Exercise5Test()
{
    Exercise5 myfive = new Exercise5();
    Console.WriteLine(myfive.ExerciseFiveDashOne(5,5));
    Console.WriteLine(myfive.ExerciseFiveDashTwo('V'));
    myfive.ExerciseFiveDashThree(32);
}

// Exercise 6 Test
// Exercise6Test();
void Exercise6Test()
{
    Exercise6 mysix = new Exercise6(10, "Nike");
    Exercise6.TryOn myShoe = mysix.ExerciseSixDashThree;
    myShoe($"I tried on a {mysix.ShoeType} pair, they were size {mysix.ShoeSize}.");
}

// Exercise 7 Test
// Exercise7Test();

void Exercise7Test()
{
    Employee myEmployee = new Employee(0, "Nick");
    Console.WriteLine(myEmployee.Name);
//    Boat myBoat = new Boat();
//    Console.WriteLine(myBoat.MeBoat);
}

// Exercise 8 Test
// Exercise8Test();

void Exercise8Test()
{
    Exercise8 myEight = new Exercise8();
    myEight.ExerciseEightDashOne(3);
    Exercise8.ExerciseEightDashTwo(12, 12); 
}

// Exercise 10 Test
// Exercise10Test();

void Exercise10Test()
{
    Horse myHorse = new Horse();
    Console.WriteLine(myHorse.Color);

    Horse myHorse2 = new Horse("Fred", 4);
    Console.WriteLine(myHorse2.Color);

    Horse myHorse3 = new Horse("Mustang", "Craigery", "Black", 6);
    Console.WriteLine(myHorse3.Name);

    Boat myBoat = new Boat();
    Console.WriteLine(myBoat.Length);

    Boat myBoat2 = new Boat("USS Boat", 10);
    Console.WriteLine(myBoat2.Name);

}

// Exercise 11 test
// Exercise1112Test();

void Exercise1112Test()
{
    Pony myPony = new Pony("short","craigory","brown", 3, "short");
    Console.WriteLine(myPony.Name);
    Yacht myYacht = new Yacht("yacht", "uss yachty", 10, 20, "cabin");
    Console.WriteLine(myYacht.Name);
    myPony.HorseGallop("pony");
}

// Exercise 13 
// Exercise13Test();

// Exercise 14
// Exercise14Test();

void Exercise14Test()
{
    Exercise14 myExcercise14 = new Exercise14();
    Console.WriteLine();
    myExcercise14.TeamArray();
}

// Exercise 15
Exercise15Test();

void Exercise15Test()
{
    Exercise15 myExercise15 = new Exercise15();
    string movie = myExercise15.Exercise15Enum(FavoriteMovies.Friday);
    Console.WriteLine(movie);
    (int val1, string val2) = myExercise15.Exercise15Enum2(FavoriteMovies.Friday);
    Console.WriteLine($" My favorite = {val1}{val2}");
}

  