using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class MenuCatalog
    {
        static List<Pizza> pizzas;
        static MenuCatalog()
        {
            pizzas = new List<Pizza>();
        }
        public static void InitialPizzaMenu() {
            CreatePizza("Margherita", "Tomato & Cheese", 80);
            CreatePizza("Vesuvio", "Tomato, Cheese & Ham", 92);
            CreatePizza("Capricciosa", "Tomato, Cheese, Ham & Mushroom ", 98);
        }
        public static void CreatePizza(string Name, string toppings, double price)
        {
            Pizza pizza = new Pizza();
            pizza.Name = Name;
            pizza.Toppings = toppings;
            pizza.Price = price;
            pizzas.Add(pizza);
            
        }

        public static void DisplayPizza()
        {
            Console.WriteLine("Big Mamas Pizza Menu");
            int i = 1;
            foreach (Pizza pizza in pizzas)
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
                pizzaByIndex = pizzas.IndexOf(pizzas[pizzanumber]);
                Console.WriteLine($"you picked:{pizzas[pizzaByIndex]}");
                return pizzas[pizzaByIndex];
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
            foreach (Pizza pizza in pizzas)
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
            pizzas.Remove(pizzas[deletedpizza]);
            
        }
    }
}
