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

            // Objekte anlegen, um auf die anderen Klassen und deren Methoden zugreifen zu können
            Register1 register1 = new Register1();
            Register2 register2 = new Register2();
            Register3 register3 = new Register3();
            Controller controller = new Controller();

            


            while (controller.benutzerWillBeenden == false)
            {

                // Hier gibt der Benutzer die Nummer eines Registers ein und die Eingabe wird in eine verwendbare Zahl umgewandelt
                int zahl = controller.HoleEingabeVomBenutzer();


                // Abhängig von der eingegebenen Zahl wird auf das jeweilige Register zugegriffen
                if (zahl == 1)
                {
                    // Es wird eine Liste ausgegeben, die die Namen anzeigt, die eingegeben werden können
                    Console.WriteLine("Sie haben Register Nummer " + zahl + " eingegen und können aus den folgenden Namen wählen:");
                    register1.PersonenAusgeben();

                    //Anweisung des Benutzers zur Eingabe eines Namens
                    Console.WriteLine("Bitte geben Sie einen Namen aus dieser Liste ein, um die Eltern, Geschwister und Kinder anzeigen zu lassen.");
                    string eingabeName = Console.ReadLine();

                    // Überprüfung, ob der eingegebene Name mit einem der zuvor ausgegebenen übereinstimmt
                    if (register1.Geschwister.Contains(eingabeName))
                    {
                        // Festlegen der der Kinder anhand des eingegebenen Namens
                        register1.eingabeName = eingabeName;
                        register1.KinderFestlegen();

                        Console.WriteLine("Sie haben " + eingabeName + " gewählt.");
                        Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

                        // Anlegen des Objekts anhand der eingegebenen Daten und anschließende Ausgabe
                        Person person = new Person(eingabeName, register1.Eltern, register1.Geschwister, register1.Kinder);
                        person.VerwandteAusgeben(eingabeName);

                    }
                    else
                    {
                        Console.WriteLine("Sie haben einen ungültigen Eingabe getätigt.");
                    }
                }
                else if (zahl == 2)
                {
                    // Es wird eine Liste ausgegeben, die die Namen anzeigt, die eingegeben werden können
                    Console.WriteLine("Sie haben Register Nummer " + zahl + " gewählt. Dies beinhaltet folgende Namen:");
                    register2.PersonenAusgeben();

                    //Anweisung des Benutzers zur Eingabe eines Namens
                    Console.WriteLine("Bitte geben Sie einen Namen aus dieser Liste ein, um die Eltern und Geschwister anzeigen zu lassen.");
                    string eingabeName = Console.ReadLine();

                    // Überprüfung, ob der eingegebene Name mit einem der zuvor ausgegebenen übereinstimmt
                    if (register2.Geschwister.Contains(eingabeName))
                    {
                        // Festlegen der der Kinder anhand des eingegebenen Namens
                        register2.eingabeName = eingabeName;
                        register2.KinderFestlegen();

                        Console.WriteLine("Sie haben " + eingabeName + " gewählt.");
                        Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

                        // Anlegen des Objekts anhand der eingegebenen Daten und anschließende Ausgabe
                        Person person = new Person(eingabeName, register2.Eltern, register2.Geschwister, register2.Kinder);
                        person.VerwandteAusgeben(eingabeName);

                    }
                    else
                    {
                        Console.WriteLine("Sie haben einen ungültigen Namen eingegeben.");
                    }
                }
                else if (zahl == 3)
                {
                    // Es wird eine Liste ausgegeben, die die Namen anzeigt, die eingegeben werden können
                    Console.WriteLine("Sie haben Register Nummer " + zahl + " gewählt. Dies beinhaltet folgende Namen:");
                    register3.PersonenAusgeben();

                    //Anweisung des Benutzers zur Eingabe eines Namens
                    Console.WriteLine("Bitte geben Sie einen Namen aus dieser Liste ein, um die Eltern und Geschwister anzeigen zu lassen.");
                    string eingabeName = Console.ReadLine();

                    // Überprüfung, ob der eingegebene Name mit einem der zuvor ausgegebenen übereinstimmt
                    if (register3.Geschwister.Contains(eingabeName))
                    {
                        // Festlegen der der Kinder anhand des eingegebenen Namens
                        register3.eingabeName = eingabeName;
                        register3.KinderFestlegen();

                        Console.WriteLine("Sie haben " + eingabeName + " gewählt.");
                        Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

                        // Anlegen des Objekts anhand der eingegebenen Daten und anschließende Ausgabe
                        Person person = new Person(eingabeName, register3.Eltern, register3.Geschwister, register3.Kinder);
                        person.VerwandteAusgeben(eingabeName);
                    }
                    else
                    {
                        Console.WriteLine("Sie haben eine ungültige Eingabe getätigt.");
                    }
                }
            }

             //Warten auf Eingabe, damit das Konsolenfenster offen bleibt
             Console.WriteLine("Bitte drücken Sie Enter, um das Programm zu beenden.");
             Console.ReadLine();             
        }
    }
}
