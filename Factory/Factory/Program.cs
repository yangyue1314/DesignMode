using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore chicago = new ChicagoPizzaStore();
            PizzaStore ny = new NYPizzaStore();

            Pizza pizzaChicago = chicago.OrderPizza("chicago");
            Pizza pizzaNY = ny.OrderPizza("NY");
        }
    }
}
