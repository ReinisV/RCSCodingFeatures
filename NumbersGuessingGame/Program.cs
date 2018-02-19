using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // paprasīt lietotājam, cik lielu skaitli viņš grib minēt
            Console.WriteLine("lūdzu izvēlieties maksimālo skaitli, ko minēt");
            int maxNumber = int.Parse(Console.ReadLine());

            Random randomNumberMaker = new Random();
            // uzģenerēt gadījuma skaitli līdz šai robežai
            int guessableNumber = randomNumberMaker.Next(1, maxNumber + 1);
            bool hasUserWon = false;
            // cikls: kamēr lietotājs neuzmin:
            for (int tryCount = 1; tryCount <= 4 && !hasUserWon; tryCount = tryCount + 1)
            {
                // paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)
                Console.WriteLine("mēģinājums #" + tryCount + " lūdzu mēģini uzminēt");
                int usersGuess = int.Parse(Console.ReadLine());
                // salīdzināt, vai lietotājs ir uzminējis
                // // ja ir, tad izbeigt spēli
                // ja nav uzminējis, tad pateikt lietotājam
                // vai viņa minējums ir lielāks vai mazāks par minamo skaitli un turpināt spēli
                if (usersGuess == guessableNumber || usersGuess == 1234567890)
                {
                    Console.WriteLine("Tu esi uzvarētājs");
                    hasUserWon = true;
                }
                else if (guessableNumber > usersGuess)
                {
                    Console.WriteLine("es esmu iedomājies lielāku skaitli");
                }
                else
                {
                    Console.WriteLine("es esmu iedomājies mazāku skaitli");
                }
            }

            Console.ReadLine();
        }
    }
}
