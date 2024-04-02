using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Dialog {
        PizzaController controller;
        public Dialog() {
            controller = new PizzaController();
        }
        public void Run()
        {

            bool proceed = true;
            string numberEntered;
            List<string> menuList = new List<string>()
            {
                "1: Display menu",
                "2: Add pizza to menu",
                "3: Search pizza by number",
                "4: Search pizza by name",
                "5: Quit program"
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
                        
                        break;

                    case "2":
                        
                        
                        
                        break;


                }
                
            } 
        }

        
    }
}
