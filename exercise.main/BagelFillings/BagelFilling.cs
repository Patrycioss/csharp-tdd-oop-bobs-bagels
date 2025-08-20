namespace exercise.main.BagelFillings;

public abstract class BagelFilling
{
    public string Type => "Filling";
    public abstract string Name();
    public abstract string Abbreviation();
    public abstract decimal Cost();
}