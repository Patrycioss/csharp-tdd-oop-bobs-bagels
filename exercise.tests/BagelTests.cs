using System.Diagnostics;
using exercise.main.BagelFillings;
using exercise.main.Bagels;

namespace exercise.tests;

public class Tests
{
    [Test]
    public void SetFillingTest()
    {
        // Arrange
        BagelFilling expected = new Cheese();
        Bagel bagel = new EverythingBagel(new Bacon());

        // Act
        bagel.SetFilling(expected);

        // Assert
        Debug.Assert(bagel.Filling == expected);
    }

    [Test]
    public void GetTotalCostTest()
    {
        // Arrange
        BagelFilling filling = new Cheese();
        Bagel bagel = new EverythingBagel(filling);

        const decimal EXPECTED_TOTAL = (decimal)0.61;

        // Act
        decimal totalCost = bagel.GetTotalCost();

        // Assert
        Debug.Assert(totalCost == EXPECTED_TOTAL);
    }
}