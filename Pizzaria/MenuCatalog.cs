using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class MenuCatalog
    {
        private static List<Pizza> _pizzas;
        static  MenuCatalog()
        {
            _pizzas = new List<Pizza>();
        }
        public static void InitialPizzaMenu() {
            CreatePizza("Margherita", "Tomato & Cheese", 80);
            CreatePizza("Vesuvio", "Tomato, Cheese & Ham", 92);
            CreatePizza("Capricciosa", "Tomato, Cheese, Ham & Mushroom ", 98);
        }
        public static void CreatePizza(string name, string toppings, double price)
        {
            Pizza pizza = new Pizza(name,toppings,price);
            
            _pizzas.Add(pizza);
            
        }

        public static void DisplayPizza()
        {
            Console.WriteLine("Big Mamas Pizza Menu");
            int i = 1;
            foreach (Pizza pizza in _pizzas)
            {
                
                
                Console.WriteLine($"{i}, {pizza}");
                Console.WriteLine("");
                i++;
            }
        }
        public static Pizza SearchPizzaByNumber(int number) {
            
            int pizzanumber = number-1;
            int pizzaByIndex;
            try
            {
                pizzaByIndex = _pizzas.IndexOf(_pizzas[pizzanumber]);
                Console.WriteLine($"you picked:{_pizzas[pizzaByIndex]}");
                return _pizzas[pizzaByIndex];
            } 
            catch
            {
                Console.WriteLine("No pizza was found, please try a different number");
                return null;
            }
        }

        public static Pizza SearchPizza(string name)
        {
            string formattedName = char.ToUpper(name[0])+name.Substring(1);
            Pizza pizzaSearch = null;
            foreach (Pizza pizza in _pizzas)
            {
                if (pizza.Name == formattedName)
                {
                    pizzaSearch = pizza;
                }
                
            }
            if (pizzaSearch != null)
            {
                Console.WriteLine("your pizza is: \n" + pizzaSearch);
            }
            else
            {
                Console.WriteLine("Did not find pizza, please try again");
            }
            return pizzaSearch;
            
        }
        public static void DeletePizza(int number)
        {
            int deletedpizza = number - 1;
            _pizzas.Remove(_pizzas[deletedpizza]);
            
        }
    }
}
