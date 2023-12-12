using System;
using System.Net;
using System.Reflection;

namespace typy_danych_ver3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Witaj!");
            Console.WriteLine("Podaj swoje dane:\r\nImię");
            string firstName = Console.ReadLine();

            Console.WriteLine("Nazwisko");
            string lastName = Console.ReadLine();

            Console.WriteLine("Wiek");
            string age = Console.ReadLine();

            Console.WriteLine("Płeć");
            string gender = Console.ReadLine();

            Console.WriteLine("PESEL");
            string pesel = Console.ReadLine();

            Console.WriteLine("Nr pracownika");
            string nrPracownika = Console.ReadLine();

            //2
            Console.WriteLine("Podaj literę");
            string letterOne = Console.ReadLine();

            Console.WriteLine("Podaj literę");
            string letterTwo = Console.ReadLine();

            Console.WriteLine("Podaj literę");
            string letterThree = Console.ReadLine();

            Console.WriteLine(letterThree + letterTwo + letterOne);

            //3
            Console.WriteLine("Podaj długości boków prostokąta \"a\" i \"b\", aby obliczyć przekątną");
            
            string aGiven = Console.ReadLine();
            int sideA;
            Int32.TryParse(aGiven, out sideA);

            string bGiven = Console.ReadLine();
            int sideB;
            Int32.TryParse(bGiven, out sideB);

            double aSquare = Math.Pow(sideA,2);
            double bSquare = Math.Pow(sideB,2);
            double diagonal = Math.Pow(aSquare + bSquare, 0.5);

            Console.WriteLine($"Długość przekątnej tego prostokąta jest równy {diagonal}");

            //4
            int firstNum = 10;
          
            float secondNum =12.5f;

            string word = "Szkoła Dotneta";

            Console.WriteLine($"a. {firstNum}");
            Console.WriteLine($"b.{word}");
            Console.WriteLine($"c. {secondNum}");
            
            //5
            Console.WriteLine("Podaj:\r\nimię");
            string name = Console.ReadLine();

            Console.WriteLine("nazwisko");
            string surname = Console.ReadLine();

            Console.WriteLine("nr telefonu");
            string phoneNum = Console.ReadLine();
            int phoneNumConverted = Int32.Parse(phoneNum);

            Console.WriteLine("adres zamieszkania");
            string homeAddress = Console.ReadLine

            Console.WriteLine("email");
            string email = Console.ReadLine();

            Console.WriteLine("wiek");
            string userAge = Console.ReadLine();
            int userAgeConverted = Int32.Parse(userAge);

            Console.WriteLine("wzrost");
            string height = Console.ReadLine();
            float heightConverted = Single.Parse(height);

            Console.WriteLine("waga");
            string weight = Console.ReadLine();
            float weightConverted = Single.Parse(weight);

            Console.WriteLine("Oto twoje dane:");
            Console.WriteLine($"* imię i nazwisko: {name} {surname};");
            Console.WriteLine($"* nr telefonu: {phoneNumConverted};");
            Console.WriteLine($"* adres zamieszkania: {homeAddress};");
            Console.WriteLine($"* email: {email};");
            Console.WriteLine($"* wiek, wzrost, waga: {userAgeConverted} lat(a), {heightConverted}cm, {weightConverted}kg.");
        }
    }
}