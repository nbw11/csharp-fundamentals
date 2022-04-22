namespace MyFirstApplication;
/* Exercise 14 Arrays */

/*
 1. Write a method with no parameters and no return type. Write a single
 dimensional string array of ice cream flavors. Using a foreach loop in 
 your method, print out the results of your array using a Console WriteLine
 ststement.
 */
internal class Exercise14
{
    public void CreamArray()
    {
        string[] creamArray = {"Vanilla", "Chocolate", "Strawberry" };

        foreach (string item in creamArray)
        {
            Console.WriteLine(item);
        }
    } // end array
/*
 2. Write a method with no parameters and no return type. Write a two-dimensional
 array using the int data type. Using the link below, fill in each dimension with KC chiefs
 regular season scores. The first dimension will be the
 be the home team, while the second dimension will be the away team. Using a foreach 
 loop, print out the results of your array using a Console WriteLine statement. to 
 determine which team is home and away, the website includes the link to the box 
 score. The link label shows both teams. The first team in the label is the away team. 
 */

    public void TeamArray()
    {
        int[,] teamArray = new int[2,2];
        teamArray[0,0] = 20;
        teamArray[0,1] = 34;
        teamArray[1,0] = 23;
        teamArray[1,1] = 20;

        foreach (int item in teamArray)
        { Console.WriteLine($"{item}");}
    
    } // end array

} // end class
