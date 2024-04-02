using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaController {
        PizzaManager pizzaManager;

        public PizzaController() 
        {
            pizzaManager = new PizzaManager();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("MENU\n");
            pizzaManager.DisplayMenu();
            Console.WriteLine("\n");
        }


    }
}
