using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Dialog {
        PizzaController controller;
        OrderController orderController;
        public Dialog() {
            controller = new PizzaController();
            orderController = new OrderController();
            MenuCatalog.InitialPizzaMenu();
        }
        public void Run()
        {

            bool proceed = true;
            string numberEntered;
            List<string> menuList = new List<string>()
            {
                "1: Display pizza-menu",
                "2: Create new order",
                "3: Add pizza to menu",
                "4: Search pizza by number",
                "5: Search pizza by name",
                "6: Delete a pizza",
                "7: ",
                "7: Quit program"
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
                        controller.DisplayMenu();
                        Thread.Sleep(2500);
                        break;
                    case "2":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO CREATE A NEW ORDER");
                        orderController.CreateNewOrder();
                        break;

                    case "3":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEE ADD TO MENU");
                        controller.CreatePizza();
                        Console.WriteLine("\n");
                        controller.DisplayMenu();
                        Thread.Sleep(2500);
                        
                        break;
                    case "4":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NUMBER");
                        controller.DisplayMenu();
                        controller.SearchPizzaByNumber();
                        Thread.Sleep(1500);
                        break;
                    case "5":
                        Console.WriteLine($"YOU PRESSED {numberEntered}, TO SEARCH BY NAME");
                        controller.DisplayMenu();
                        Console.WriteLine("\n");
                        controller.SearchByName();
                        Thread.Sleep(2500);

                        break;
                    case "6":
                        Console.WriteLine($"YOU PRESSED {numberEntered} TO REMOVE A PIZZA");
                        Console.WriteLine("\n");
                        controller.DisplayMenu();
                        controller.DeletePizza();
                        
                        break;
                    case "7":
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
