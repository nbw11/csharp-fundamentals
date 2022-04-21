namespace MyFirstApplication;

/*
 This will be about abstract modifier and Interfaces
 */

public interface ILesson13Interface
{
    int Miles { get; }
    int ConvertMilesToYards();
} // end interface


internal abstract class Lesson13Base : ILesson13Interface
{
    protected int num;

    // Abstract Properties
    protected abstract int Inches { get; }
    protected abstract int Feet { get; }

    // Implemented from interface
    public abstract int Miles { get; }

    // Constructor
    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // Abstract Methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();

    // Implemented from interface
    public abstract int ConvertMilesToYards();

}// end class 

/* 
 Our derived class will implement our Abstract class members
 */
internal class Lesson13Derived : Lesson13Base
{
    // implementing abstract properties
    protected override int Inches { get; } = 12;
    protected override int Feet { get; } = 3;

    // implementing interface
    public override int Miles { get; } = 1760;

    // Constructor
    public Lesson13Derived(int value)
        : base(value) { }


    // Implementing abstract Methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }

    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    }

    // Implemented interface method
    public override int ConvertMilesToYards()
    {
        return num * Miles;
    }
} // end class 
