using exercise.main.BagelFillings;

namespace exercise.main.Bagels;

public class OnionBagel : Bagel
{
    public override string Name() => "Plain";
    public override string Abbreviation() => "BGLP";
    
    public OnionBagel(BagelFilling bagelFilling) : base(bagelFilling, new decimal(0.49))
    {
    }
}