using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzaria {
    public class CustomerMenu : UIMenu {
        private PizzaController _pizzaController;

        public CustomerMenu()
        {
            _pizzaController = new PizzaController();
        }
        

        protected override void CreateMenuOptions()
        {
            EnterOption("1: See menu");
            EnterOption("2: Order pizza");
            EnterOption("3: join members club");
            EnterOption("4 return to main menu");
            EnterOption("5: Close program");
        }
        public override void RunMenu()
        {

            while (_proceed==true) { 
            base.RunMenu();

                switch (_numberentered)
                {
                    case "1":
                        YouPressedMessage();
                        Console.Clear();
                        Console.WriteLine("Menu");
                        BlankSpace();
                        _pizzaController.DisplayMenu();
                        break;

                    case "2":
                        // TODO: "Her kommer muligheden for at tilføje en order til pizza"
                        break;

                    case "3":
                        //TODO: "Laver ny menu der laver en customer, som tilføjes til membership liste"
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
                        Console.WriteLine("Please enter one of the following numbers: 1, 2, 3, 4 or 5");
                        Thread.Sleep(1500);
                        RunMenu();
                        break;
                }
            }
        }

        
    }
}
