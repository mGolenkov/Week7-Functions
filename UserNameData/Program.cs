using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada oma eesnimi
            //programm kuvab kasutaja eesnime pikkust
            //programm kuvab kasutaja eesnime esimest tähte
            //programm kuvab kasutaja kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla rohkem, kui kolm rida koodi

            Console.WriteLine("Sisesta oma eesnimi: ");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }
        
        public static void GetUserNameData(string UserInput)
        {
            Console.WriteLine($"Sinu nimi on {UserInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {UserInput[0]}.");

            for (int i = UserInput.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(UserInput[i]);
            }
        }
    }
}
