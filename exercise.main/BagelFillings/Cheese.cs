namespace exercise.main.BagelFillings;

public class Cheese : BagelFilling
{
    public override string Name() => "Cheese";
    public override string GetAbbreviation() => "FILC";
    public override decimal GetCost() => new(0.12);
}