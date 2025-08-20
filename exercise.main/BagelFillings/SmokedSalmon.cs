namespace exercise.main.BagelFillings;

public class SmokedSalmon : BagelFilling
{
    public override string Name() => "SmokedSalmon";
    public override string Abbreviation() => "FILS";
    public override decimal Cost() => new(0.12);
}