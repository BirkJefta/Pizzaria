using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Pizza {
        public string Name { get;  private set; }
        public string Toppings { get;  private set; }
       
        public double Price { get;  private set; }

        

        public Pizza() 
        {
            Name = "";
            Toppings = "";
            Price = 0;
            
        }

        public override string ToString()
        {
            
            return ( $" {Name} {Price},- kr \n" +
                $"ingredients: {Toppings}");
        }
    }
}
