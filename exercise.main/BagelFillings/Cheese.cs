namespace exercise.main.BagelFillings;

public class Cheese : BagelFilling
{
    public override string Name() => "Cheese";
    public override string Abbreviation() => "FILC";
    public override decimal Cost() => new(0.12);
}