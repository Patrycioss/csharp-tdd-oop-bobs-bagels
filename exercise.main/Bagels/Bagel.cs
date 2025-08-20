using exercise.main.BagelFillings;

namespace exercise.main.Bagels;

public abstract class Bagel
{
    public static string Type => "Bagel";
    public BagelFilling Filling => bagelFilling;
    public abstract string Name();
    public abstract string Abbreviation();

    protected BagelFilling bagelFilling;
    protected decimal cost;

    protected Bagel(BagelFilling bagelFilling, decimal cost)
    {
        this.bagelFilling = bagelFilling;
        this.cost = cost;
    }

    public void SetFilling(BagelFilling filling)
    {
        bagelFilling = filling;
    }

    public decimal GetTotalCost()
    {
        return cost + Filling.Cost();
    }
}