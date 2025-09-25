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
            return 0;

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
       /* public Dictionary<string,float> ChooseItem(string item, int itemint = 0)
        {
            if(itemint == 0) //out of range by fedalt to not mess with the rest
            {
                itemint = 986;
            }
            for (int i = 0; i < pr._prices.Count; i++)
            {
                if(i == itemint)
                {
                    return pr._prices[i];
                }
            }


        }*/
    }
}
