using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class EmployeeMenu : MenuCatalog{

        protected override void CreateMenuOptions()
        {
            EnterOption("1: Add new pizza to menu");
            EnterOption("2: See orders");
            EnterOption("3: See members in membership club");
            EnterOption("4: return to main menu");
            
        }
        public void RunEmployeeMenu()
        {

            CreateMenuOptions();
            base.RunMenu();

            switch (_numberentered)
            {
                case "1":

                    Console.WriteLine("Her kommer PizzaMenu.add feature");
                    break;

                case "2":

                    Console.WriteLine("Her kommer kan man se ordre ved at søge på customer name");
                    break;

                case "3":
                    Console.WriteLine("Her kan man printe listen med members i membership club");
                    break;

                case "4":
                    Console.WriteLine("You pressed 4 and will be returned to main menu");
                    CustomerOrEmployee customerOrEmployee = new CustomerOrEmployee();
                    Console.Clear();
                    customerOrEmployee.RunStartMenu();
                    break;

                default:
                    Console.WriteLine("Please enter one of the following numbers:");
                    RunEmployeeMenu();
                    break;
            }
        }
    }
}
