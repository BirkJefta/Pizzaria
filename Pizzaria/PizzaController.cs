using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaController {

        
        private PizzaManager PizzaManager ;
        


        public PizzaController() 
        {
            PizzaManager = new PizzaManager();
        }
        public Pizza CreatePizza(string pizzaName, string pizzaTopping, double pizzaPrice)
        {
            return PizzaManager.CreatePizza(pizzaName, pizzaTopping, pizzaPrice);
        }

        public string AddPizza(int pizzzaID, Pizza pizza)
        {
            return PizzaManager.AddPizza(pizzzaID, pizza);
        }


    }
}
