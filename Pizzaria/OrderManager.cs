using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class OrderManager {
        Order Order;
        public OrderManager() 
        { 
            Order = new Order();
        }
        public void AddPizzaToOrder (Pizza pizza)
        {
            Order.AddPizzaToOrder(pizza);
        }
        public void DisplayOrder () 
        {
            Order.DisplayOrder();
        }
    }
}
