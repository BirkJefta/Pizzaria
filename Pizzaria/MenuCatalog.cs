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
        public void InitialPizzaMenu() {
            Pizza pizza1 = new Pizza();
            pizza1.Name = "Margherita";
            pizza1.Price = ;
        }
        public static void CreatePizza(string Name, string toppings, int price)
        {
            Pizza pizza = new Pizza();
            pizza.Name = Name;
            pizza.Toppings = toppings;
            pizza.Price = price;
            pizzas.Add(pizza);
            Console.WriteLine($"{pizza} \n" +
                $"Was succesfully added");
        }

        public static void DisplayPizza()
        {
            Console.WriteLine("Big Mamas Pizza Menu");
            foreach (Pizza pizza in pizzas)
            {
                int i = 1;
                
                Console.WriteLine($"{i}, {pizza}");
                i++;
            }
        }
        public static Pizza Read(int number) {
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
                Console.WriteLine("No pizza was found, please try another number");
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
    }
}
