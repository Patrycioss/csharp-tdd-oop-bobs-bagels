namespace exercise.main.BagelFillings;

public class Bacon : BagelFilling
{
    public override string Name() => "Bacon";
    public override string GetAbbreviation() => "FILB";
    public override decimal GetCost() => new(0.12);
}