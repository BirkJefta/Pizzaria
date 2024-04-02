using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class OrderController {
        PizzaController controller;
        public OrderController() 
        { 
            controller = new PizzaController();
        }

        public void CreateNewOrder()
        {
            Console.WriteLine("HERE IS THE MENU YOU CAN CHOOSE FROM:");
            Console.WriteLine("");
            controller.DisplayMenu();
            Console.WriteLine("\n");
            controller.SearchPizzaByNumber();
            

        }
        public void DisplayOrderedPizza()
        {

        }
    }
}
