abstract class Char
{
    //internal state
    protected char @char;

    public Char(char @char)
    {
        this.@char = @char;
    }

    public void DisplayText()
    {
        Console.Write(@char);
    }
}
