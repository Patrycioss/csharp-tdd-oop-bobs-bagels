namespace exercise.main.BagelFillings;

public class Ham : BagelFilling
{
    public override string Name() => "Ham";
    public override string GetAbbreviation() => "FILH";
    public override decimal GetCost() => new(0.12);
}