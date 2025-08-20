using exercise.main.BagelFillings;

namespace exercise.main.Bagels;

public class PlainBagel : Bagel
{
    public override string Name() => "Plain";
    public override string Abbreviation() => "BGLP";
    
    public PlainBagel(BagelFilling bagelFilling) : base(bagelFilling, new decimal(0.39))
    {
    }
}