using System;

namespace OROperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaal sisestada kasutajatunnus ja salasõna;
            //kui sisestatud kasutajatunnus on "admin" ja sisestatud salasõna on "admin1234"
            //siis konsoolis kuvatakse "Tere tulemast!";
            //muul konsoolis kuvatakse "Vale kasutajatunnus või salasõna. Proovi uuesti."

            //OR (või) || (pipes)

            //true || true --> true
            //false || true --> true
            //true || false --> true
            //false || false --> false


            Console.WriteLine("Sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string userPassword = Console.ReadLine();

            if(userName != "admin" || userPassword != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna. Proovi uuesti.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }

            // "admin1" != "admin" || "admin1234" !== "admin1234" --> true || false --> true
            // "admin" != "admin" || "admin123" != "admin1234" --> false || true --> true
            // "admin1" != "admin" || "admin123" != "admin1234" --> true || true --> true
            //"admin" != "admin" || "admin1234" != "admin1234" --> false || false --> false 
        }
    }
}
