using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.WriteLine("MENU");
            Console.WriteLine("\n");
            pizzaManager.DisplayMenu();
            Console.WriteLine("\n");
        }
        public void CreatePizza()
        {
            double price = 0;
            Console.WriteLine("What is the name of the pizza?");
            string name = Console.ReadLine();
            bool IsValid = false;
            while (IsValid != true)
            {
                try
                {
                    Console.WriteLine("What is the price of the pizza?");
                    string stringPrice = Console.ReadLine();


                    price = double.Parse(stringPrice);
                    IsValid = true;
                }
                catch
                {
                    Console.WriteLine("wrong format, please enter a number");
                }
            }
            Console.WriteLine("What is the toppings");
            string toppings = Console.ReadLine();

            pizzaManager.CreatePizza(name,toppings,price);
            
        }
        public void SearchPizzaByNumber() 
        {
            bool isValid = true;
            while(isValid){
                
                    Console.WriteLine("What is the number of the pizza you want to find?");
                    string stringEnteredNumber = Console.ReadLine();
                try
                {
                    int enteredNumber = Int32.Parse(stringEnteredNumber);
                    if (pizzaManager.SearchPizzaByNumber(enteredNumber) != null)
                    {
                        isValid = false;
                    }
                }
                catch
                {
                    Console.WriteLine("Please enter a number ");
                }
                
            } 

        }
        public void SearchByName()
        {
            Console.WriteLine("What is the name of the pizza you want to find?");
            string name = Console.ReadLine();
            pizzaManager.SearchByName(name);
        }


    }
}
