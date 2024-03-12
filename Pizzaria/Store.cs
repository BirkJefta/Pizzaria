using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Store {
        CustomerOrEmployee CustomerOrEmployee = new CustomerOrEmployee();
        private string _name; 

        public void Run()
        {
            Console.WriteLine("Hello what is your name?");
            Console.WriteLine("");
            _name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Hello {_name} welcome to Big Mamas Pizza");
            Thread.Sleep(2200);
            CustomerOrEmployee.RunStartMenu();
        }

    }
}
