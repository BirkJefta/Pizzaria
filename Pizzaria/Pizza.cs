using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Pizza {
        private string Name { get;  set; }
        private string Toppings { get;  set; }
        private string PizzaID { get;  set; }
        private double Price { get;  set; }


        public Pizza(string name, string toppings, double price, string pizzaID) 
        {
            Name = name;
            Toppings = toppings;
            PizzaID = pizzaID;
            Price = price;
        }

        public override string ToString()
        {
            return $"{PizzaID}, {Name} with ( {Toppings} ) costs {Price} ";
        }
    }
}
