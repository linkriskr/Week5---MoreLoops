using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus osaleb kaks mängijat - arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringuid;
            //programm kontrollib, kumb mängija viskas rohkem;
            //mängija, kes viskab rohkem, ongi mängu võitja.
            //*täringuid visatakse kolm korda
            //programm kuulutab võitjat.

            Random rnd = new Random();

            //arvuti vise
            int cpuRandom = rnd.Next(1, 7);
            //kasutaja vise
            int userRandom = rnd.Next(1, 7);

            int cpuScore = 0;
            int userScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{i+1} Arvuti viskas {cpuRandom}. Kasutaja viskas {userRandom}.");
                cpuRandom = rnd.Next(1, 7);
                userRandom = rnd.Next(1, 7);
            }
            if (cpuRandom < userRandom)
            {
                Console.WriteLine("Kasutaja on mängu võitnud.Palju õnne!");
                userScore = userScore + 1;
            }
            else if (cpuRandom > userRandom)
            {
                Console.WriteLine("Arvuti on mängu võitnud.");
                cpuScore = cpuScore + 1;
            }
            else
            {
                Console.WriteLine("Viik!");
            }
            Console.WriteLine("Kena päeva!");
        }
    }
}
