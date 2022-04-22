namespace MyFirstApplication;
// Exercise 16 Collections

internal class Exercise16
{
    /*
      1. Write a method that has no parameters and no return type. Create a
     List<T> of your Horse objects. When creating your list, utilize all the 
     constructors you created with your Horse class. Using a foreach loop, print
     out the results of your collection using a ConsoleWriteLine Statement.
    */
    public void Exercise16DashOne()
    {
        List<string> horseList = new List<string>();
        horseList.Add("Breed");
        horseList.Add("Name");
        horseList.Add("Color");
        foreach(string item in horseList)
        {
            Console.WriteLine(item);
        }
    }
    /*
      2. Write a method that has no parameters and no return type. Using only the 
     data you used when building your favorite movies from exercise 15, create a Dictionary
     collection that takes an int key and string value. When adding dictionary elemtns, pick
     an int value as the key and use the favorite movies data as the string. Using a foreach loop,
     print out the results of your collection using a ConsoleWritLine.
     */
    public void Exercise16DashTwo()
    {
        Dictionary<int, string> movieDictionary = new Dictionary<int, string>();
        movieDictionary.Add(1, "Waynes World");
        movieDictionary.Add(2, "Friday");
        movieDictionary.Add(3, "Spiderman");
        movieDictionary.Add(4, "Batman");
    
        foreach(KeyValuePair<int, string> item in movieDictionary)
        {
            Console.WriteLine($" Key: {item.Key} Movie: {item.Value}");
        }
    
    }
}
