namespace exercise.main.BagelFillings;

public class Bacon : BagelFilling
{
    public override string Name() => "Bacon";
    public override string Abbreviation() => "FILB";
    public override decimal Cost() => new(0.12);
}