namespace MyFirstApplication;

// This calss uses loops and if statements to sing a song.
internal class BottlesOfBeer
{

    private int _beernum = 99;
    private string _word = "bottles";

    public void LetsSing()
    {
        while(_beernum > 0)
        {
            if(_beernum == 1)
            {
                _word = "bottle";
            } //end if

            Console.WriteLine($"{_beernum} {_word} of beer on the wall.");
            Console.WriteLine($"{_beernum} {_word} of beer");
            Console.WriteLine("Take one down");
            Console.WriteLine("Pass it around");
            
            _beernum--;

            if(_beernum > 0)
            {
                Console.WriteLine($"{_beernum} {_word} of beer on the wall.");
                Console.WriteLine();
            } // end if 
            else
            {
                Console.WriteLine("No more bottles of beer on the wall.");
            }
        } // end while


    } // end method


} // End Class
