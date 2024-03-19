using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaDataLayer {

        private static Dictionary<int, Pizza> _pizzaMenu;



        static PizzaDataLayer() { 
            _pizzaMenu = new Dictionary<int, Pizza>();
        }

        public static void AddToMenu(int pizzaID, Pizza pizza)
        {
            
            _pizzaMenu.Add(pizzaID,pizza);
            
        }


        public static void DisplayPizzaMenu()
        {
            foreach (var item in _pizzaMenu)
            {
                Pizza pizza = item.Value;
                Console.WriteLine("");
                Console.WriteLine($"{item.Key}) {pizza}");
                Console.WriteLine("");
            }
        }






        
    }
}
