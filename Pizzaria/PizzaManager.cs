using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaManager {
        

        public PizzaManager() { 
        }

        public void DisplayMenu () 
        {
            MenuCatalog.DisplayPizza();
        }
        public void CreatePizza(string Name, string toppings, double price)
        {
            MenuCatalog.CreatePizza(Name, toppings, price);
            Console.WriteLine($"Pizza " +
                $"was succesfully added");
        }
        public Pizza SearchPizzaByNumber (int number)
        {
            return MenuCatalog.SearchPizzaByNumber(number);
            
        }
        public Pizza SearchByName (string name)
        {
            return MenuCatalog.SearchPizza(name);
        }
        public void DeletePizza(int number)
        {
            MenuCatalog.DeletePizza(number);
        }
    }
}
