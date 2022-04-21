namespace MyFirstApplication;
// Exercise 11 1/2

/*
  Create a child class based on your Horse object. Include one child attribute as an auto property.
 Create 3 constructors. The first constructor should have 4 parameters with 3 of them from Horse and
 your child property. Using the keyword :base(), you will put the four horse parameters in the parenthesis
 In the body fo the constructor you will assign your child parameter to your property. 
*/
internal class Pony : Horse
{
    public string Legs { get; set; }

    public Pony(string breed, string name, string color, int height, string legs)
        :base(breed, name, color, height)
    {
        Legs = legs;
    }

    /*
      The second constructor should have 2 parameters, 2 based on the horse and 1 from your child. Using the
    :this() keyword, you will pass 2 of the parent attricbutes to your child attribute information to the first 
    constructor. Include default values to represent the 2 remainign horse paremeters.
     */
    public Pony(string breed, string name)
        :this(breed, name, "black", 4, "short")
    { }
    
    /*
      For the last constructor, you will create the default constructor. Using the :this() keyword, you will create the
     default constructor. Using the :this() keyword, you will pass 2 default values in that will pass to the
    2nd constructor. Also include in the class, your method for your child class. */

    public Pony()
        :this("shetland", "Craigory")
    { }
    /* i think the psuedocode method i used for my pony was
     * pony
     * small
     * four legged
     * gallops
    */
}


