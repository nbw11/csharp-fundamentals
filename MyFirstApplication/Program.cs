using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Below statement calls a local function
// single line comment
HouseExample();

/*
 Multi-line comment
the below statement is a local function. Local functions
are inside of members and areprivate by default. This means
they are specific to that member and can only be called 
by that member
*/
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
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

MyLocalFunction();
