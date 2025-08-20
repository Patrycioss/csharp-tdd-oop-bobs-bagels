using exercise.main.BagelFillings;

namespace exercise.main.Bagels;

public class SesameBagel : Bagel
{
    public override string Name() => "Sesame";
    public override string Abbreviation() => "BGLP";
    
    public SesameBagel(BagelFilling bagelFilling) : base(bagelFilling, new decimal(0.49))
    {
    }
}