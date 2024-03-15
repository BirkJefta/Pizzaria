using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzaria {
    public class CustomerMenu : MenuCatalog {

        

        protected override void CreateMenuOptions()
        {
            EnterOption("1: See menu");
            EnterOption("2: Order pizza");
            EnterOption("3: join members club");
            EnterOption("4 return to main menu");
        }
        public override void RunMenu()
        {

            base.RunMenu();

            switch (_numberentered)
            {
                case "1":
                    
                        Console.WriteLine("Her kommer display menu feature");
                        break;
                    
                case "2":
                    
                        Console.WriteLine("Her kommer muligheden for at tilføje en order til pizza");
                        break;
                    
                case "3":
                    Console.WriteLine("Laver ny menu der laver en customer, som tilføjes til membership liste");
                    break;

                case "4":
                    YouPressedMessage();
                    CustomerOrEmployee customerOrEmployee = new CustomerOrEmployee();
                    Console.Clear();
                    customerOrEmployee.RunMenu();
                    break;

                default:
                    Console.WriteLine("Please enter one of the following numbers: 1, 2, 3 or 4");
                    Thread.Sleep(1500);
                    RunMenu();
                    break;
            }
        }

        
    }
}
