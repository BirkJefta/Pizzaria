﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Dialog {
        private PizzaController _controller;
        
        public Dialog() {
            _controller = new PizzaController();
            MenuCatalog.InitialPizzaMenu();
        }
        public void Run()
        {

            bool proceed = true;
            string numberEntered;
            List<string> menuList = new List<string>()
            {
                "1: Display pizza-menu",
                "2: Add pizza to menu",
                "3: Search pizza by number",
                "4: Search pizza by name",
                "5: Delete a pizza",
                "6: Quit program"
            };
            
            while (proceed)
            {
                
                foreach (string menuChoice in menuList)
                {
                    Console.WriteLine(menuChoice);
                }
                Console.WriteLine("\n");
                Console.WriteLine("Enter number of option");
                numberEntered = Console.ReadKey().KeyChar.ToString();
                
                Console.WriteLine("\n");

                switch (numberEntered)
                {
                    case "1":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEE MENU");
                        _controller.DisplayMenu();
                        Thread.Sleep(3500);
                        break;

                    case "2":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO ADD A PIZZA TO MENU");
                        _controller.CreatePizza();
                        Console.WriteLine("\n");
                        _controller.DisplayMenu();
                        Thread.Sleep(3500);
                        
                        break;
                    case "3":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NUMBER");
                        _controller.DisplayMenu();
                        _controller.SearchPizzaByNumber();
                        Thread.Sleep(3500);
                        break;
                    case "4":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NAME");
                        _controller.DisplayMenu();
                        Console.WriteLine("\n");
                        _controller.SearchByName();
                        Thread.Sleep(3500);

                        break;
                    case "5":
                        Console.WriteLine($"YOU PRESSED {numberEntered} TO REMOVE A PIZZA");
                        Console.WriteLine("\n");
                        _controller.DisplayMenu();
                        _controller.DeletePizza();
                        
                        break;
                    case "6":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO QUIT");
                        Console.WriteLine("Are you sure");
                        Console.WriteLine("Press y for yes , otherwise press n for no");
                        ConsoleKeyInfo quit = Console.ReadKey();
                        
                        if (quit.KeyChar == 'y' || quit.KeyChar == 'Y')
                        {
                            proceed = false;
                        }
                        Console.Beep();
                        
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again");
                        break;

                }
                Console.WriteLine("\n");
                
            } 
        }

        
    }
}
