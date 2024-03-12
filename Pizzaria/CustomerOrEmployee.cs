using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class CustomerOrEmployee : MenuCatalog
        {


        
        protected override void CreateMenuOptions()
        {
            EnterOption("1: Press 1, if you are a customer");
            EnterOption("2: Press 2 if you are an employee");
        }
        public void RunStartMenu()
        {
            Console.Clear();
            CreateMenuOptions();

            base.RunMenu();

            if (_numberentered == "1")
            {
                
                Console.Clear();
                Console.WriteLine($"Hello, you pressed 1, here is the customer menu");
                CustomerMenu customerMenu = new CustomerMenu();
                customerMenu.RunCustomerMenu();
            }
            else if (_numberentered == "2")
            {
                Console.Clear();
                Console.WriteLine($"Hello, you pressed 2 here is the employee menu ");
                EmployeeMenu employeeMenu = new EmployeeMenu();
                employeeMenu.RunEmployeeMenu();
            }
            else
            {
                Console.Clear() ;
                Console.WriteLine("Please enter either 1 or 2");
                BlankSpace();
                Thread.Sleep(1800);
                ClearList();
                RunStartMenu();
                
            }
        }
    }
}
