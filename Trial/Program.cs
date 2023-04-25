using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

class Program
{
    //Arutri Ülesanne
    class Attributes
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Attributes(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Random random = new Random();
            Age = random.Next(1, 100);
        }
    }
    static void Main(string[] args)
    {
        Attributes[] attributesArray = new Attributes[5];
        attributesArray[0] = new Attributes("Martin", "Smithtable");
        attributesArray[1] = new Attributes("Luca", "Kto");
        attributesArray[2] = new Attributes("Yarik", "kakoito");
        attributesArray[3] = new Attributes("Alena", "Brownich");
        attributesArray[4] = new Attributes("Aleksei", "West");

        Console.WriteLine("Kõik rajatised:");
        foreach (Attributes attributes in attributesArray)
        {
            Console.WriteLine($"{attributes.FirstName} {attributes.LastName}, vanus: {attributes.Age}");
        }
        Console.WriteLine("\nÜhtlase vanusega objektid:");
        foreach (Attributes attributes in attributesArray)
        {
            if (attributes.Age % 2 == 0)
            {
                Console.WriteLine($"{attributes.FirstName} {attributes.LastName}, vanus: {attributes.Age}");
            }
        }
        Console.WriteLine("-----------------------------------------");

        //сортировка списка строк в порядке убывания количества гласных букв в каждой строке.
        //Sorteerige ridade loetelu kahanevas järjekorras vokaalide arvu järgi igas reas.

        List<string> strings = new List<string>();
        while (true)
        {
            Console.Write("Sisestage string või vajutage väljumiseks ENTER: ");
            string s = Console.ReadLine().Trim();
            if (s == "")
            {
                break;
            }
            strings.Add(s);
        }
        strings.Sort((a, b) => CountVowels(b).CompareTo(CountVowels(a)));

        foreach (string s in strings)
        {
            Console.WriteLine(s);
        }
        }
        static int CountVowels(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if ("aäeioöõuüAÄEIOÖÕUÜ".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
}


