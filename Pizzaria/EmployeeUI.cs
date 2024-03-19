using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class EmployeeUI : UIMenu {
        private bool _proceed = true;

        protected override void CreateMenuOptions()
        {
            EnterOption("1: Add new pizza to menu");
            EnterOption("2: See orders");
            EnterOption("3: See members in membership club");
            EnterOption("4: Return to user selection menu");
            EnterOption("5: Quit program");
        }

        
        public override void RunMenu()
        {
            while (_proceed == true)
            {
                
                base.RunMenu();

                switch (_numberentered)
                {
                    case "1":

                        //TODO: Add Pizza
                        Console.Clear();
                        Console.WriteLine("What is the name of the pizza?");
                        string pizzaName = Console.ReadLine();
                        Console.WriteLine("What is the price of the pizza?");
                        string pizzaPriceString = Console.ReadLine();
                        double pizzaPrice = double.Parse(pizzaPriceString);
                        Console.WriteLine("What is the toppings of the pizza?");
                        string pizzaToppings = Console.ReadLine();
                        
                        pizzaController.CreatePizza(pizzaName, pizzaToppings, pizzaPrice);
                        Console.WriteLine(pizzaController.AddPizza(20, pizzaController.CreatePizza(pizzaName, pizzaToppings, pizzaPrice)));

                        Console.WriteLine("The Menu is now:");
                        
                        Console.WriteLine();
                        break;

                    case "2":
                        //TODO: "Her kommer kan man se ordre ved at søge på customer name"
                        break;

                    case "3":
                        //TODO: Her kan man printe listen med members i membership club
                        break;

                    case "4":
                        YouPressedMessage();
                        UIMenu customerOrEmployee = new CustomerOrEmployee();
                        Console.Clear();
                        customerOrEmployee.RunMenu();
                        break;

                    case "5":
                        Console.Clear();
                        YouPressedMessage();
                        Console.WriteLine("Are you sure you want to quit? yes or no? ");
                        string answer = Console.ReadLine();
                        answer = answer.ToLower();
                        if (answer == "y" ||  answer == "yes")
                        {
                            Console.Clear();
                            Console.WriteLine("Thank you for using Big Mamas Pizza");
                            Console.WriteLine("Program is closing");
                            _proceed = false;
                            Console.Beep();
                        }

                        break;
                        

                    default:
                        Console.Clear ();
                        Console.WriteLine($"Please enter one of the following numbers: 1, 2, 3 or 4 ");
                        Thread.Sleep(1200);

                        break;
                }
            }
        }
    
    }
}
