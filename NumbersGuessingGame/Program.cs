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
            int guessableNumber = randomNumberMaker.Next(1, maxNumber);

            // cikls: kamēr lietotājs neuzmin:
            while (true)
            {
                // paprasīt lietotājam lai viņš min kāds skaitlis ir izveidots (iegūt ievadi)

                // salīdzināt, vai lietotājs ir uzminējis
                // // ja ir, tad izbeigt spēli
                // ja nav uzminējis, tad pateikt lietotājam
                // vai viņa minējums ir lielāks vai mazāks par minamo skaitli un turpināt spēli
                if ()
                {
                    break;
                }
            }
        }
    }
}
