namespace exercise.main.BagelFillings;

public class CreamCheese : BagelFilling
{
    public override string Name() => "CreamCheese";
    public override string GetAbbreviation() => "FILX";
    public override decimal GetCost() => new(0.12);
}