namespace exercise.main.BagelFillings;

public class Egg : BagelFilling
{
    public override string Name() => "Egg";
    public override string GetAbbreviation() => "FILE";
    public override decimal GetCost() => new(0.12);
}