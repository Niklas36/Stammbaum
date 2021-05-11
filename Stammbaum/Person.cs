using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Person
    {
        public string name;
        public List<string> Eltern;
        public List<string> Geschwister;
        public List<string> Kinder;
        

        public Person(string name ,  List <string> Eltern, List <string> Geschwister, List <string> Kinder)
        {
            this.name = name;
            this.Eltern = Eltern;
            this.Geschwister = Geschwister;            
            this.Kinder = Kinder;
        }


        // Ausgabe der Eltern, Geschwister und Kinder anhand des eingegebenen Names
        public void VerwandteAusgeben(string eingabeName)
        {

            Console.WriteLine(eingabeName + " hat folgende Eltern:");
            foreach (var name in Eltern)
            {
                Console.WriteLine("- " + name); 
            }
            Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

            Geschwister.Remove(eingabeName);

            Console.WriteLine(eingabeName + " hat folgende Geschwister:");
            foreach (var name in Geschwister)
            {
                Console.WriteLine("- " + name);
            }
            Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

            Console.WriteLine(eingabeName + " hat folgende Kinder:");
            foreach (var name in Kinder)
            {
                Console.WriteLine("- " + name);   
            }
            Console.WriteLine(); // Leerzeile zur besseren Lesbarkeit innerhalb der Konsole

            Kinder.Clear(); // Die Liste "Kinder" leeren, damit bei einer erneuten Abfrage keine vorher hinterlegten Kinder vorhanden sind und ausgegeben werden
            Geschwister.Add(eingabeName); // Die ausgewählte Person wird aus der Liste "Geschwister" gelöscht. Nun muss sie wieder hinzugefügt werden, damit sie wieder angezeigt wird
        }
    }
}
