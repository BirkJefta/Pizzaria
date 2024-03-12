using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzaria {
    public class MenuCatalog {

        
        protected string _numberentered;
        List<string> messages = new List<string>();
        



        protected void EnterOption(string message)
        {
            messages.Add(message);
        }

        public void DisplayOptions()
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
        public void ClearList () 
        { 
            messages.Clear(); 
        }

        protected virtual void CreateMenuOptions(){}

        public void RunMenu()
        {

            Console.WriteLine("");
            Console.WriteLine("Please enter number and then press enter");
            Console.WriteLine("");
            DisplayOptions();
            _numberentered = Console.ReadLine();
        }
        public void BlankSpace() 
        {
            Console.WriteLine("");
        }


    }
}
