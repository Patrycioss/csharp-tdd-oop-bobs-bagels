namespace exercise.main.BagelFillings;

public class SmokedSalmon : BagelFilling
{
    public override string Name() => "SmokedSalmon";
    public override string GetAbbreviation() => "FILS";
    public override decimal GetCost() => new(0.12);
}