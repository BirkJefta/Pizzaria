using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Store {
        UIMenu CustomerOrEmployee = new CustomerOrEmployee();
        
        public void Run()
        {
            InitialPizzaMenu initialMenu = new InitialPizzaMenu();
            initialMenu.RunInitialMenu();
            CustomerOrEmployee.RunMenu();

        }

    }
}
