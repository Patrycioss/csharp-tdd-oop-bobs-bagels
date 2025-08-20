namespace exercise.main.BagelFillings;

public abstract class BagelFilling
{
    public string Type => "Filling";
    public abstract string Name();
    public abstract string GetAbbreviation();
    public abstract decimal GetCost();
}