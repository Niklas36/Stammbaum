using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Program
    {

        static void Main(string[] args)
        {
            Register1 register1 = new Register1();
            Register2 register2 = new Register2();
            Register3 register3 = new Register3();

            
            //Begrüßungstext und Anweisung für den User
            Console.WriteLine("Hallo! Bitte geben Sie die Nummer eines Registers ein (1, 2, 3):");
           
            
            // Hier gibt der Benutzer die Nummer eines Registers ein
            string eingabeZahl = Console.ReadLine();
            int zahl = Convert.ToInt32(eingabeZahl);
            

            if (zahl == 1)
            {
                Console.WriteLine("Sie haben Register Nummer " + eingabeZahl + " gewählt. Dies beinhaltet folgende Namen:");
                register1.PersonenAusgeben();
            }
            else if (zahl == 2)
            {
                Console.WriteLine("Sie haben Register Nummer " + eingabeZahl + " gewählt. Dies beinhaltet folgende Namen:");
                register2.PersonenAusgeben();
            }
            else if (zahl == 3)
            {
                Console.WriteLine("Sie haben Register Nummer " + eingabeZahl + " gewählt. Dies beinhaltet folgende Namen:");
                register3.PersonenAusgeben();
            }
            else
            {
                Console.WriteLine("Sie haben eine ungültige Eingabe getätigt.");
            }

            //Anweisung des Benutzers zur Eingabe eines Namens
            Console.WriteLine("Bitte geben Sie einen Namen aus dieser Liste ein, um die Eltern und Geschwister anzeigen zu lassen.");

            //TODO: Methode erstellen, die alle ausgegebenen Namen speichert. So kann später auf einen dieser Namen geprüft werden und es soll
            // eine entsprechende Meldung ausgegeben werden, wenn ein ungültiger Name eingegeben wurde.
            string eingabeName = Console.ReadLine();
            Console.WriteLine("Sie haben " + eingabeName + " gewählt.");



            if (zahl == 1)
            {
                register1.ElternUndGeschwisterAusgeben(eingabeName);
            }
            else if (zahl == 2)
            {
                register2.ElternUndGeschwisterAusgeben(eingabeName);
            }
            else if (zahl == 3)
            {
                register3.ElternUndGeschwisterAusgeben(eingabeName);

            }
            

            //Warten auf Eingabe, damit das Konsolenfenster offen bleibt
            Console.WriteLine("Bitte drücken Sie Enter, um das Programm zu beenden.");
            Console.ReadLine();
        }
    }
}
