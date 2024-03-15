using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class Customer {
        private string Name { get; set; }
        private string Address { get; set; }
        private string Email { get; set; }

        public Customer(string name, string adress, string email) 
        {
            Name = name;
            Address = adress;
            Email = email;
        }
        public override string ToString()
        {
            return $"Customer name: {Name} \n" +
                $" Adress: {Address}\n" +
                $"Email: {Email}";
        }
    }
}
