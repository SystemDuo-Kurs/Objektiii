using System;
using System.Collections.Generic;

namespace Objektiii
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = 15;

            List<int> brojevi = new();
            brojevi.Add(15);

            int broj2 = broj;
            List<int> lista2 = brojevi;

            broj2++; //16
            lista2[0]++; //16

            Console.WriteLine(
                $"Broj je {broj}, a u listi brojeva je {brojevi[0]}");

            Osoba a = new();
            a.Ime = "Pera";
            
            Osoba b = new();
            b.Ime = "Neko";

            Console.WriteLine(a.Ime);

        }
    }

    class Osoba
    {
        public string Ime;
        public string Prezime;
        public string BrTel;
        public string Adresa;
    }
        


}
