using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Xml.Linq;

namespace Pizzaria {
    public class UIMenu {

        
        protected string _numberentered; //TODO: evt lav som get/set for at lave private.
        List<string> messages = new List<string>();
        protected bool _proceed = true;
        protected PizzaController pizzaController;




        public void DisplayOptions()
        {
            
            foreach (var message in messages)
            {
                Console.WriteLine(message);
                BlankSpace();
                
            }
            BlankSpace();
            
        }
        

        protected virtual void CreateMenuOptions(){ }//TODO: måske lav abstract i stedet.



        public virtual void RunMenu()
        {

            pizzaController = new PizzaController();
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
