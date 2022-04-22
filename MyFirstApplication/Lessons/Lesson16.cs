namespace MyFirstApplication;

// Lesson 16 Collections
internal class Lesson16
{

    /* The List <T> is the same as an ArrayLIst but we define our
      type in its declarationas all items are of the same
      type.
     */
    public void MyListExample()
    {
        List<string> myStringlist = new List<string>();
        myStringlist.Add("Alpha");
        myStringlist.Add("Bravo");
        myStringlist.Add("Charlie");
        myStringlist.Add("Delta");
        myStringlist.Add("Foxtrot");

        // Gets or sets the total number of elements
        Console.WriteLine($" Capactiy is {myStringlist.Capacity}");
        Console.WriteLine($" Total count is {myStringlist.Count}");

        // Bool if list contains?
        Console.WriteLine($" This list might contain {myStringlist.Contains("Delta")} ");

        // Insert and remove Items
        myStringlist.Insert(3, "Happy");
        myStringlist.Remove("Happy");
        
        // Iterate through the elements
        foreach(string item in myStringlist)
        {
            Console.WriteLine(item);
        }
    }

    // This collection is base around key value pairs
    public void MyDictionaryExample()
    {
        Dictionary<int, string> phrases = new Dictionary<int, string>();
        phrases.Add(10, "Csharp");
        phrases.Add(20, "rcoks");
        phrases.Add(30, "Happy");
        phrases.Add(40, "Friday");

        // get a single calue using the TryGetValue Method
        string value;
        if(phrases.TryGetValue(20, out value))
        {
            Console.WriteLine($"For key 20, the value is {value}");
        }
        // iterate through the list
        foreach(KeyValuePair<int, string> item in phrases)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}"); 
        }
    }

}// end class
