using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaManager {
        

        public PizzaManager() { 
        }

        public void DisplayMenu () 
        {
            MenuCatalog.DisplayPizza();
        }
    }
}
