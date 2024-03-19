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
            //InitialMenu initialMenu = new InitialMenu();
            //initialMenu.RunInitialMenu();
            CustomerOrEmployee.RunMenu();

        }

    }
}
