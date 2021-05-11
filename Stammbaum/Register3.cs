using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Register3
    {
        public string eingabeName;

        public List <string> Eltern = new List<string> { "Klaus", "Anke" };
        public List<string> Geschwister = new List<string> { "Kerstin", "Astrid", "Anja" };
        public List<string> Kinder = new List<string>();

        // Ausgabe der Personen, anhand derer der Stammbaum bestimmt werden kann
        public void PersonenAusgeben()
        {
            foreach (var name in Geschwister)
            {
                Console.WriteLine("- " + name);
            }
        }

        // Zuweisung der Kinder für den ausgewählten Namen
        public void KinderFestlegen()
        {
            if (eingabeName == "Kerstin")
            {
                Kinder.Add("Philipp");
            }
            else if (eingabeName == "Astrid")
            {
                Kinder.Add("Merle");
                Kinder.Add("Niklas");
                Kinder.Add("Dominique");
            }
            else
            {
                Kinder.Add("Dustin");
                Kinder.Add("Michel");
            }
        }


    }
}
