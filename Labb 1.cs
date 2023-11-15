
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string characterName1 = "Thomas";
            int characterAge1 = 39;

            Console.WriteLine("Skriv namnet på person 1:");
            Console.WriteLine(characterName1);
            Console.WriteLine("Skriv åldern på person 1:");
            Console.WriteLine(characterAge1);

            string characterName2 = "Johanna";
            int characterAge2 = 42;

            Console.WriteLine("Skriv namnet på person 2:");
            Console.WriteLine(characterName2);
            Console.WriteLine("Skriv åldern på person 2:");
            Console.WriteLine(characterAge2);

            string characterName3 = "Mormor";
            int characterAge3 = 84;

            Console.WriteLine("Skriv namnet på person 3:");
            Console.WriteLine(characterName3);
            Console.WriteLine("Skriv åldern på person 3:");
            Console.WriteLine(characterAge3);

            string characterName4 = "Morfar";
            int characterAge4 = 89;

            Console.WriteLine("Skriv namnet på person 4:");
            Console.WriteLine(characterName4);
            Console.WriteLine("Skriv åldern på person 3:");
            Console.WriteLine(characterAge4);


            
            Console.WriteLine(characterName1 + " är " + characterAge1 + " gammal");
            Console.WriteLine(characterName2 + " är " + characterAge2 + " gammal");
            Console.WriteLine(characterName3 + " är " + characterAge3 + " gammal");
            Console.WriteLine(characterName4 + " är " + characterAge4 + " gammal");

            int collectiveAge = 247;
            float middleAge = 61.75F;

            Console.WriteLine("Sammanlagd ålder är: " + collectiveAge);
            Console.WriteLine("Medelåldern är: " + middleAge);

        }
        

 
    }

}
