﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaController {
        private PizzaManager _pizzaManager;

        public PizzaController() 
        {
            _pizzaManager = new PizzaManager();
        }

        public void DisplayMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("\n");
            _pizzaManager.DisplayMenu();
            Console.WriteLine("\n");
        }
        public void CreatePizza()
        {
            double price = 0;
            Console.WriteLine("Please enter the name of the pizza");
            string name = Console.ReadLine();
            string formattedName = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            bool IsValid = false;
            while (IsValid != true)
            {
                try
                {
                    Console.WriteLine("Please enter the price of the pizza");
                    string stringPrice = Console.ReadLine();


                    price = double.Parse(stringPrice);
                    IsValid = true;
                }
                catch
                {
                    Console.WriteLine("wrong format, please enter a number");
                }
            }
            Console.WriteLine("Please enter the name of the toppings");
            string toppings = Console.ReadLine();

            _pizzaManager.CreatePizza(formattedName,toppings,price);
            
        }
        public int SearchPizzaByNumber() 
        {
            int enteredNumber = 0;
            bool isValid = true;
            while(isValid){
                
                    Console.WriteLine("What is the number of the pizza?");
                    string stringEnteredNumber = Console.ReadLine();
                try
                {
                     enteredNumber = Int32.Parse(stringEnteredNumber);
                    if (_pizzaManager.SearchPizzaByNumber(enteredNumber) != null)
                    {
                        isValid = false;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please enter a number ");
                }
                
            } 
            return enteredNumber;

        }
        public void SearchByName()
        {
            Console.WriteLine("What is the name of the pizza?");
            string name = Console.ReadLine();
            _pizzaManager.SearchByName(name);
        }
        public void DeletePizza()
        {
            _pizzaManager.DeletePizza(SearchPizzaByNumber());
            Console.WriteLine("Pizza was succesfully deleted");
        }


    }
    
}
