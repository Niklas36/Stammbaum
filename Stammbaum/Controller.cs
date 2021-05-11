using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Controller
    {
        List<string> Registernummern = new List<string> { "1", "2", "3" };
        
        public string eingabe;

        public bool benutzerWillBeenden = false; 

        
        public int HoleEingabeVomBenutzer()
        {
            Console.WriteLine("Bitte geben Sie die Nummer eines Registers ein (1, 2, 3) oder FERTIG zum Beenden:");


            string eingabeZahl = Console.ReadLine();
            eingabe = eingabeZahl;
            
            // Der Benutzer hat die Möglichkeit, das Programm mehrmals zu durchlaufen oder manuell zu beenden
            if (eingabe == "FERTIG")
            {
                benutzerWillBeenden = true;
                return 0;
            }
            else if (Registernummern.Contains(eingabe))
            {
                int zahl = Convert.ToInt32(eingabeZahl);
                return zahl;
            }
            else
            {
                Console.WriteLine("Sie haben eine ungültige Eingabe getätigt.");
                return 0;
            }
        }
    }
}
