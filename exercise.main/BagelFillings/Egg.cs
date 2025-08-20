namespace exercise.main.BagelFillings;

public class Egg : BagelFilling
{
    public override string Name() => "Egg";
    public override string Abbreviation() => "FILE";
    public override decimal Cost() => new(0.12);
}