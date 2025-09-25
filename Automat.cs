using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class Automat
    {
        private prices currentStock = new prices();

        public void WelcomeMessage()
        {
            //Willkommensnachricht
        }
        public void DisplayDrinks()
        {
            //Folgende Drinks sind verfügbar
            int drinkNumber = 0;

            //foreach (var item in currentStock._prices)
            //{
            //    //Jeden Drink mit Namen und Wert zb "Wasser, 5 EUR" anzeigen lassen
            //    //Angeben welche Nummer (drinkNumber) für den Drink gewählt werden muss "(1) Wasser, 5 EUR"
            //    Console.WriteLine(currentStock._prices.Keys.ToString() + " " + currentStock._prices.Values.ToString() + "\n");
            // 
            //
            //    drinkNumber = 0;
            //
            //}

            for (int i = 0; i < currentStock._prices.Count; i++)
            {
                Console.WriteLine(currentStock._prices.Keys.First());
            }

            //"Bitte wählen sie aus und bestätige mit ENTER


        }
        public void SelectDrinks()
        {

        }
        public void Buy()
        {

        }
        public void InputMoney(float value)
        {

        }


    }
}
