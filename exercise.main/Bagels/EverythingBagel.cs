using exercise.main.BagelFillings;

namespace exercise.main.Bagels;

public class EverythingBagel : Bagel
{
    public override string Name() => "Everything";
    public override string Abbreviation() => "BGLP";
    
    public EverythingBagel(BagelFilling bagelFilling) : base(bagelFilling, new decimal(0.49))
    {
    }
}