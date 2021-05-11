using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Register2
    {
        public string eingabeName;

        public List<string> Eltern = new List<string> { "Hermann", "Gerda" };
        public List<string> Geschwister = new List<string> { "Edgar", "Andreas", "Heike", "Angelika", "Alexander" };
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
            if (eingabeName == "Edgar")
            {
                Kinder.Add("Lennard");
                Kinder.Add("Marlene");
            }
            else if (eingabeName == "Andreas")
            {
                Kinder.Add("Merle");
                Kinder.Add("Niklas");
                Kinder.Add("Dominique");

            }
            else if (eingabeName == "Heike")
            {
                Kinder.Add("Marie");
            }
            else if (eingabeName == "Angelika")
            {
                Kinder.Add("Marek");
            }
            else
            {
                Kinder.Add("Liv Nike");

            }
        }

    }
}
