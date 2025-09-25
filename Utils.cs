namespace VendingMachine
{
    /* 
     * Schreibt ein Programm, welches einen Getränkeautomaten nachbildet:
     * Der Spieler beginnt mit einem festen Geldbetrag und darf diesen am Automaten ausgeben.
     * Die Auswahl der Getränke soll über Nutzereingabe passieren.
     * Wenn ein Getränk und der entsprechende Geldbetrag eingegeben wurde, soll der Spieler ein Getränk in sein Inventar
     * übergeben bekommen. Dieses bekommt er nach jedem Kauf aufgelistet.
     * 
     * Je nach Stand, kann man weitere Features zum Automaten hinzufügen.
     * Getränk trinken können... Füllstatus des Automaten... Text-Effekte und Farbe...
     */

    internal class Utils
    {
        private prices pr = new prices();

        public float returnRest(float input, float price)
        {
            if (enough(price, input))
            {
                return Math.Abs(input -price);
            }
            else
            {
                return 0f;
            }
        }

        public bool enough(float price, float input)
        {
            if(price >= input)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       public float GetPrice(string item)
        {
            if (pr._prices.ContainsKey(item))
            {
                return pr._prices[item];
            }
            return 0;
        }
    }
}
