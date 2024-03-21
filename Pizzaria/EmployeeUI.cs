using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class EmployeeUI : UIMenu {
        private bool _proceed = true;
        private PizzaController _pizzaController;

        public EmployeeUI()
        {
            _pizzaController = new PizzaController();
        }

        protected override void CreateMenuOptions()
        {
            EnterOption("1: Add new pizza to menu");
            EnterOption("2: Remove pizza from menu");
            EnterOption("3: See orders");
            EnterOption("4: See members in membership club");
            EnterOption("5: Return to user selection menu");
            EnterOption("6: Quit program");
        }

        
        public override void RunMenu()
        {
            while (_proceed == true)
            {
                Console.Clear();
                base.RunMenu();
                SwitchStatements();
            }
        }
        public void SwitchStatements()
        {
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
                    Console.WriteLine("What should the ID be?");
                    int pizzaID = int.Parse(Console.ReadLine());


                    _pizzaController.CreatePizza(pizzaName, pizzaToppings, pizzaPrice);
                    Console.WriteLine(_pizzaController.AddPizza(pizzaID, _pizzaController.CreatePizza(pizzaName, pizzaToppings, pizzaPrice)));
                    BlankSpace();
                    Console.WriteLine("The Menu is now:");
                    BlankSpace();
                    _pizzaController.DisplayMenu();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to proceed");
                    Console.ReadLine();

                    break;

                case "2":
                    Console.Clear();
                    //_pizzaController.DisplayMenu(); (virker ikke af en eller anden årsag)
                    Console.WriteLine("Enter the number of the pizza you want to remove ");
                    int removedPizzaID = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"You pressed {removedPizzaID}");
                    Console.WriteLine($"You are trying to remove {_pizzaController.FindPizza(removedPizzaID)}");
                    Console.WriteLine("Are you sure?");
                    string removeinput = Console.ReadLine();
                    string remove = removeinput.ToLower();
                    
                    if (remove == "y" || remove == "yes")
                    {
                        
                        _pizzaController.RemoveAndUpdateMenu(removedPizzaID);
                        Console.WriteLine("The updated menu is:");
                        

                    }
                    Console.WriteLine("press any key to proceed");
                    Console.ReadKey();
                    
                    break;

                case "3":
                    //TODO: "Her kommer kan man se ordre ved at søge på customer name"
                    break;

                case "4":
                    //TODO: Her kan man printe listen med members i membership club
                    break;

                case "5":
                    YouPressedMessage();
                    UIMenu customerOrEmployee = new CustomerOrEmployee();
                    Console.Clear();
                    customerOrEmployee.RunMenu();
                    break;

                case "6":
                    Console.Clear();
                    YouPressedMessage();
                    Console.WriteLine("Are you sure you want to quit? yes or no? ");
                    string answer = Console.ReadLine();
                    answer = answer.ToLower();
                    if (answer == "y" || answer == "yes")
                    {
                        Console.Clear();
                        Console.WriteLine("Thank you for using Big Mamas Pizza");
                        Console.WriteLine("Program is closing");
                        _proceed = false;
                        Console.Beep();
                    }

                    break;


                default:
                    Console.Clear();
                    Console.WriteLine($"Please enter one of the following numbers: 1, 2, 3 or 4 ");
                    Thread.Sleep(1200);

                    break;
            }
        }
    
    }
}
