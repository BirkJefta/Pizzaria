using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Order {
        List<Pizza> pizzaOrdered;

        public Order()
        {
            pizzaOrdered = new List<Pizza>();
        }
        public void AddPizzaToOrder(Pizza pizza)
        {
            pizzaOrdered.Add(pizza);
        }
        public void DisplayOrder() 
        { 
            foreach (Pizza pizza in pizzaOrdered)
            {
                Console.WriteLine(pizza);
            }
        }

    }
}

 
