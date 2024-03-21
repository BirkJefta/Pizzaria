using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaManager {
        PizzaDataLayer pizzaDataLayer;


        public PizzaManager() 
        { 
            pizzaDataLayer = new PizzaDataLayer();
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
        public void DisplayMenu()
        {
           pizzaDataLayer.DisplayPizzaMenu();
        }
        public void RemoveAndUpdate(int pizzaID) 
        {

            pizzaDataLayer.RemoveAndUpdateMenu(pizzaID);        
        }
        public Pizza FindPizza(int pizzaID)
        {
           return pizzaDataLayer.FindPizza(pizzaID);
        }
    }
}
