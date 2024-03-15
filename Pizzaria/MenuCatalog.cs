using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Pizzaria {
    public class MenuCatalog {

        
        protected string _numberentered; //evt lav som get/set for at lave private.
        List<string> messages = new List<string>();
        

        public void DisplayOptions()
        {
            foreach (var message in messages)
            {
                Console.WriteLine(message);
                BlankSpace();
            }
            BlankSpace();
        }

        protected virtual void CreateMenuOptions(){ }//måske lav abstract i stedet.



        public virtual void RunMenu()
        {
            
            Console.Clear();
            ClearList();
            CreateMenuOptions();
            BlankSpace();
            Console.WriteLine("Please enter number and then press enter");
            BlankSpace();
            DisplayOptions();
            _numberentered = Console.ReadLine();
        }
        protected virtual void YouPressedMessage()
        {
            Console.Clear();
            Console.WriteLine($"You pressed {_numberentered} ");
            Thread.Sleep(1000);
        }


        public void BlankSpace() 
        {
            Console.WriteLine("");
        }
        public void ClearList()
        {
            messages.Clear();
        }

        protected void EnterOption(string message)
        {
            messages.Add(message);
        }

    }
}
