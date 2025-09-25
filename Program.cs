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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Vending Machine!");
            Automat automat = new();
            automat.DisplayDrinks();
        }
    }
}
