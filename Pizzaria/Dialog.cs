using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Dialog {
        PizzaController controller;
        public Dialog() {
            controller = new PizzaController();
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

                        controller.DisplayMenu();
                        Thread.Sleep(2500);
                        break;

                    case "2":
                        controller.CreatePizza();
                        Console.WriteLine("\n");
                        controller.DisplayMenu();
                        Thread.Sleep(2500);
                        
                        break;
                    case "3":
                        controller.DisplayMenu();
                        controller.SearchPizzaByNumber();
                        Thread.Sleep(1500);
                        break;
                    case "4":
                        controller.DisplayMenu();
                        Console.WriteLine("\n");
                        controller.SearchByName();
                        Thread.Sleep(2500);

                        break;
                    case "5":
                        Console.WriteLine("YOU PRESSED 5 TO REMOVE A PIZZA");
                        Console.WriteLine("\n");
                        controller.DisplayMenu();
                        controller.DeletePizza();
                        
                        break;
                    case "6":
                        Console.WriteLine("You pressed 5 to Quit the program, are you sure? ");
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
