using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaManager {
        
        public PizzaManager() 
        { 
            
        }

        public Pizza CreatePizza(string pizzaName, string pizzaTopping, double pizzaPrice )
        {
            
            Pizza pizza = new Pizza();
            pizza.Name = pizzaName;
            pizza.Toppings = pizzaTopping;
            pizza.Price = pizzaPrice;
            return pizza;
        }
        public string AddPizza (int PizzaID, Pizza pizza) 
        {
            
            PizzaDataLayer.AddToMenu(PizzaID,pizza);
            return "pizza was added";
            
        }
    }
}
