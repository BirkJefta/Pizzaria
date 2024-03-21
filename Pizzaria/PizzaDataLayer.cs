using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class PizzaDataLayer {

        private static Dictionary<int, Pizza> _pizzaMenu;



        static PizzaDataLayer() 
        { 
            _pizzaMenu = new Dictionary<int, Pizza>();
        }

        public static void AddToMenu(int pizzaID, Pizza pizza)
        {
                
            try
            {
                    if (!_pizzaMenu.ContainsKey(pizzaID))
                    {
                        _pizzaMenu.Add(pizzaID, pizza);
                    }
                    else
                    {
                        throw new PizzaIDIsInUseException("pizza ID is already in use");
                    }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                Console.WriteLine("This is the menu, each number is the pizzaID ");
                foreach (var item in _pizzaMenu.Keys) 
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine("please enter new id");
                int newID = int.Parse(Console.ReadLine());
                pizzaID = newID;
            }
        }
        public  void RemoveFromMenu(int pizzaID)
        {

            Console.WriteLine($"Pizza {_pizzaMenu[pizzaID]} was removed");
            _pizzaMenu.Remove(pizzaID);
        }

        public void RemoveAndUpdateMenu(int pizzaID) 
        {

            RemoveFromMenu(pizzaID);
            List<Pizza> tempPizzaList = new List<Pizza>();

            foreach (var pizza in _pizzaMenu.Values)
            {
                tempPizzaList.Add(pizza);
            }


            _pizzaMenu.Clear();

            int newKey = 1;

            foreach (var pizza in tempPizzaList)
            {
                _pizzaMenu.Add(newKey++, pizza);
            }


        }


        public void DisplayPizzaMenu()
        {
            foreach (var pizza in _pizzaMenu)
            { 
                Console.WriteLine("");
                Console.WriteLine($"{pizza.Key}) {_pizzaMenu[pizza.Key]}");
                Console.WriteLine("");
            }
        }

        public Pizza FindPizza (int pizzaID) 
        { 
            if (_pizzaMenu.ContainsKey(pizzaID))
            { 
                return _pizzaMenu[pizzaID];
            }
            else
            {
                return null;
            }
        }
   

        
  
    }
}
