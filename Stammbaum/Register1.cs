using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Register1
    {
        public string eingabeName;
   
        public List<string> Eltern = new List<string> { "Astrid", "Andreas" };
        public List<string> Geschwister = new List<string> { "Niklas", "Merle", "Dominique" };
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
            if (eingabeName == "Niklas")
            {
                Kinder.Add(eingabeName + " hat keine Kinder");
            }
            else if (eingabeName == "Merle")
            {
                Kinder.Add(eingabeName + " hat keine Kinder.");
            }
            else
            {
                Kinder.Add("Ina");
                Kinder.Add("Bea");
            }
        }
        


    }
}
