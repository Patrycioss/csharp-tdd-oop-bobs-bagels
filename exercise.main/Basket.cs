using exercise.main.BagelFillings;
using exercise.main.Bagels;

namespace exercise.main;

public class Basket
{
    public int Count => _contents.Count;
    
    private readonly List<Bagel> _contents = new();
    private int _maxCapacity;

    public Basket(int maxCapacity)
    {
        _maxCapacity = maxCapacity;
    }

    public void AddBagel(Bagel bagel)
    {
        if (_contents.Count < _maxCapacity)
        {
            _contents.Add(bagel);
        }
        else
        {
            Console.WriteLine("Basket is at max capacity!");
        }
    }

    public void RemoveBagel(Bagel bagel)
    {
        if (!_contents.Remove(bagel))
        {
            Console.WriteLine("Could not find bagel to remove!");
        }
    }

    public void AdjustCapacity(int capacity)
    {
        _maxCapacity = capacity;
    }

    public decimal GetTotalCost()
    {
        decimal cost = 0;
        foreach (var bagel in _contents)
        {
            cost += bagel.GetTotalCost();
        }

        return cost;
    }
}