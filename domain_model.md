## Core ##
| Methods/Properties                                  | Scenario                                                                  | Outputs                                                      |
|-----------------------------------------------------|---------------------------------------------------------------------------|--------------------------------------------------------------|
| Basket.AddBagel(Bagel bagel)                        | add specific type of bagel, should notify when full                       | A notification if full                                       |
| Basket.RemoveBagel(Bagel bagel)                     | remove a bagel from the basket, should notify if the bagel does not exist | A notification if bagel does not exist                       |
| Basket.AdjustCapacity(int capacity)                 | change the capacity of the basket                                         | None                                                         |
| Basket.GetTotalCost()                               | get the total cost of all bagels in the basket                            | The total cost of all bagels in the basket                   |
| Bagel.SetFilling(BagelFilling filling)              | change filling of the bagel                                               | None                                                         |
| BagelFilling.GetCost()                              | get the cost of the filling                                               | The cost of the filling                                      |
    