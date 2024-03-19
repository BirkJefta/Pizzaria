using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Pizza {
        public string Name { get;  set; }
        public string Toppings { get;  set; }
       
        public double Price { get;  set; }

        

        public Pizza() 
        {
            Name = "";
            Toppings = "";
            Price = 0;
            
        }

        public override string ToString()
        {
            
            return ( $" {Name} costs {Price},- kr \n" +
                $" \n" +
                $"ingredients: {Toppings}");
        }
    }
}
