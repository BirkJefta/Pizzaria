using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria {
    public class InitialMenu {
        List<string> pizzaNames = new List<string>();
        List<string> pizzaToppings = new List<string>();
        List<double> pizzaPrice = new List<double>(); 
        List<Pizza> pizzas = new List<Pizza>();

        private string _names = @"
            
            Margherita
            Vesuvio
            Capricciosa
            Calzone
            Quattro Stagioni
            Marinara
            Vegetariana
            Italiana
            Gorgonzola
            Contadina
            Napoli
            Vichinga
            Calzone Speciale
            Esotica
            Tonno
            Sardegna
            Romana
            Sole
            Big Mamma
            ";

        private string _toppings = @"
        Tomat & ost
        Tomat, ost & skinke
        Tomat, ost, skinke & champignon
        Indbagt pizza med tomat, ost, skinke & champignon
        Tomat, ost, skinke, champignon, rejer & paprika
        Tomat, ost, rejer, muslinger & hvidløg
        Tomat, ost & grønsager
        Tomat, ost, løg & kødsauce
        Tomat, gorgonzola, løg & champignon
        Tomat, ost, champignon & oliven
        Tomat, ost, ansjoser & oliven
        Tomat, ost, skinke, champignon, paprika, hvidløg & chili (stærk)
        (Ikke indbagt) tomat, ost, rejer, skinke & kødsauce
        Tomat, ost, skinke, rejer & ananas
        Tomat, ost, tun & rejer
        Tomat, ost, cocktailpølser, bacon, løg & æg
        Tomat, ost, skinke, bacon & løg
        Tomat, ost, skinke, bacon & æg
        Tomat, gorgonzola, rejer, asparges og parmaskinke
        ";

        private string _prices =
            @"
                80
                92
                98
                98
                98
                97
                98
                93
                97
                92
                95
                98
                98
                98
                97
                97
                98
                98
                99
            ";





        public InitialMenu() {
            InitializePizzaNames();
            InitializeToppings();
            InitializePrice();
        }

        private void InitializePizzaNames()
        {
            string[] names = _names.Trim().Split('\n');
            foreach (string name in names)
            {
                
                pizzaNames.Add(name.Trim());
            }

        }
        private void InitializeToppings()
        {
            string[] toppings = _toppings.Trim().Split("\n");
            foreach (string topping in toppings)
            {
                pizzaToppings.Add(topping.Trim());
            }
        }
        private void InitializePrice()
        {
            string[] prices = _prices.Trim().Split("\n");
            foreach (string price in prices)
            {
                string trimmedPrice = price.Trim();
                double doublePrice = double.Parse(trimmedPrice);
                pizzaPrice.Add(doublePrice);
            }
        }

        //public void RunInitialMenu()
        //{
        //    for (int i = 0; i < pizzaNames.Count; i++)
        //    {
        //        Pizza pizza = new Pizza(pizzaNames[i], pizzaToppings[i], pizzaPrice[i]);
        //        PizzaDataLayer.AddToMenu(i+1, pizza);
        //    }
        //}

        //public void DisplayMenu()
        //{
        //    foreach (string name in pizzaNames)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //public void DisplayMenu()
        //{
        //    foreach (string topping in pizzaToppings)
        //    {
        //        Console.WriteLine(topping);
        //    }
        //}
        //public void DisplayMenu()
        //{
        //    foreach (double price in pizzaPrice)
        //    {
        //        Console.WriteLine(price);
        //    }
        //}




    }
}
