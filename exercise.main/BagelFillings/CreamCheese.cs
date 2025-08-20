namespace exercise.main.BagelFillings;

public class CreamCheese : BagelFilling
{
    public override string Name() => "CreamCheese";
    public override string Abbreviation() => "FILX";
    public override decimal Cost() => new(0.12);
}