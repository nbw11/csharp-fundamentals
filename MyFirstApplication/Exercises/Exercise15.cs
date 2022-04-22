﻿namespace MyFirstApplication;
// Exercise 15 Enums & Tuples

/*
 1. Above the class, write an enum called FavoriteMovies. Add your own
 favorite movies to the enum. Write a method that has a string return type
 and an enum parameter. This enum parameter will be your facorite movie enum.
 write a switch expression that takes the enum and prints out a string return.
 Use strin interpolation in your return message that includes the name of the
 movie chosen.
 */

public enum FavoriteMovies { WaynesWorld, Friday, Spiderman, Batman} 
internal class Exercise15
{
    public string Exercise15Enum(FavoriteMovies favoriteMovies)
    {
        string message = favoriteMovies switch
        {
            FavoriteMovies.WaynesWorld => $"My favorite movie is {FavoriteMovies.WaynesWorld}",
            FavoriteMovies.Friday => $"My favorite movie is {FavoriteMovies.Friday}",
            FavoriteMovies.Spiderman => $"My favorite movies {FavoriteMovies.Spiderman}",
            _ => $"My favorite movies is {FavoriteMovies.Batman}"
        };
        return message;
    } // end method
    /*
     2. Write a method that takes an enum parameter. This enum will be your favorite
     movie enum. The method will have a tuple reutrn type (int num, string movie). 
     Using an explicit int cast on one of your enum, assign the value to an int variable.
     Create second variable of type string. Assign the same enum value you used and use the
     ToString() at the end of it. Return botha variables as tuples. See example below for clarity
       a. Int value = (int)Enum.Value;
       b. string something = Enum.Value.ToString();
    */

    public (int num, string movie) Exercise15Enum2(FavoriteMovies favorite)
    {
        int num = (int)FavoriteMovies.Friday;
        string movie = FavoriteMovies.Friday.ToString();
        return (num, movie);
    }

} // end class
