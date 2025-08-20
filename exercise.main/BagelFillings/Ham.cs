namespace exercise.main.BagelFillings;

public class Ham : BagelFilling
{
    public override string Name() => "Ham";
    public override string Abbreviation() => "FILH";
    public override decimal Cost() => new(0.12);
}