using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stammbaum
{
    class Register1
    {

        private List<string> Eltern = new List<string> { "Astrid", "Andreas" };
        private List<string> Geschwister = new List<string> { "Niklas", "Merle", "Dominique" };
        //TODO: Kinder einfügen


        public void PersonenAusgeben()
        {
            foreach (var name in Geschwister)
            {
                Console.WriteLine(name);
            }
        }

        public void ElternUndGeschwisterAusgeben(string eingabeName)
        {
            Console.WriteLine(eingabeName + " hat folgende Eltern:");
            foreach (var name in Eltern)
            {
                Console.WriteLine(name);
            }

            
            Geschwister.Remove(eingabeName);

            Console.WriteLine(eingabeName + " hat folgenden Geschwister:");
            foreach (var name in Geschwister)
            {
                Console.WriteLine(name);
            }

        }
                
    }
}
