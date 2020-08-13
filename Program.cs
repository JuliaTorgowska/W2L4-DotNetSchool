using System;

namespace tydz2lek4
{
    class Program
    {
        static void Main(string[] args)
        {

            // zadanie 1
            string imie;
            string nazwisko;
            int wiek;
            char płec;
            long pesel;
            long numerPracownika;

            //zadanie 2


            char a = char.Parse("x");
            char b = char.Parse("y");
            char c = char.Parse("z");

            Console.WriteLine(c);
            Console.WriteLine(b);
            Console.WriteLine(a);

            // zadanie 3

            Console.WriteLine("Program policzy długość przekątnej na podstawie podanych szerokości i długości prostokąta");
            Console.WriteLine("Podaj szerokość");
            double szerokosc = double.Parse(Console.ReadLine());

            Console.WriteLine("Podaj długość");
            double długosc = double.Parse(Console.ReadLine());

            double akw = Math.Pow(szerokosc, 2);
            double bkw = Math.Pow(długosc, 2);
            double ckw = akw + bkw;

            double wynik = Math.Sqrt(ckw);
            Console.WriteLine("Wynik to:");
            Console.WriteLine(wynik);

            // zadanie 4

            int liczbowa1 = 10;
            double liczbowa2 = 12.5;
            string tekstowa = "Szkoła Dotneta";

            // zadanie 5
            Console.WriteLine("Podaj swoje imie");
            string imie2 = (Console.ReadLine());
            Console.WriteLine("Podaj swoje nazwisko");
            string nazwisko2 = (Console.ReadLine());
            Console.WriteLine("Podaj swoj numer telefonu");
            long telefon = long.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoj adres email");
            string email = (Console.ReadLine());
            Console.WriteLine("Podaj swoj wzrost");
            double wzrost = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoja wage");
            double waga = double.Parse(Console.ReadLine());






        }
    }
}
