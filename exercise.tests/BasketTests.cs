using System.Diagnostics;
using exercise.main;
using exercise.main.BagelFillings;
using exercise.main.Bagels;

namespace exercise.tests;

public class BasketTests
{
    [Test]
    public void AddBagelTest()
    {
        // Arrange
        Basket basket = new Basket(1);
        Bagel bagel = new EverythingBagel(new Cheese());


        // Act
        basket.AddBagel(bagel);
        basket.AddBagel(bagel);

        // Assert
        Debug.Assert(basket.Count == 1);
    }
    
    [Test]
    public void RemoveBagelTest()
    {
        // Arrange
        Basket basket = new Basket(2);
        Bagel bagel = new EverythingBagel(new Cheese());

        basket.AddBagel(bagel);

        // Act
        basket.RemoveBagel(bagel);
        basket.RemoveBagel(bagel);
        
        // Assert
        Debug.Assert(basket.Count == 0);
    }
    
    [Test]
    public void AdjustCapacityTest()
    {
        // Arrange
        Basket basket = new Basket(0);
        Bagel bagel = new EverythingBagel(new Cheese());
        
        basket.AddBagel(bagel);
        
        // Act
        basket.AdjustCapacity(1);
        basket.AddBagel(bagel);
        
        // Assert
        Debug.Assert(basket.Count == 1);
    }
    
    [Test]
    public void GetTotalCostTest()
    {
        // Arrange
        Basket basket = new Basket(3);
        Bagel bagel1 = new EverythingBagel(new Cheese());
        Bagel bagel2 = new OnionBagel(new CreamCheese());
        Bagel bagel3 = new SesameBagel(new Egg());
        
        basket.AddBagel(bagel1);
        basket.AddBagel(bagel2);
        basket.AddBagel(bagel3);

        const decimal EXPECTED_TOTAL = (decimal)1.83; 
        
        // Act
        decimal totalCost = basket.GetTotalCost();
        
        // Assert
        Debug.Assert(totalCost == EXPECTED_TOTAL);
    }
    
    
}