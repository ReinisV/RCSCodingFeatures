using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainsOnlyApp
{
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            // palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
            Console.WriteLine("lūdzu ievadi burtus, no kuriem vēlies veidot vārdus");
            string usersLetters = Console.ReadLine();
            // ielādējam visus vārdus no vārdnīcas faila
            string[] wordsFromDictionary = File.ReadAllLines(@"C:\Users\reinis.vesers\Desktop\words.txt");
            // izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
            foreach (string wordFromDict in wordsFromDictionary)
            {
                // PĀRBAUDĀM, VAI VISI LIETOTĀJA IEVADĪTIE BURTI IR ATRODAMI VĀRDNĪCAS VĀRDĀ
                // izveidojam mainīgo, kurā piefiksēsim to, vai vārdā no vārdnīcas ir
                //  ir atrasti nevajadzīgi burti 
                bool hasInvalidLetterBeenFound = false;
                // izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
                foreach(char currentSymbol in usersLetters)
                {
                    // pārbaudam, vai burts atrodas vārdnīcas vārdā
                    if (wordFromDict.Contains(currentSymbol) == false)
                    {
                        // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                        hasInvalidLetterBeenFound = true;
                    }
                }

                // PĀRBAUDĀM, VAI VISI VĀRDNĪCAS VĀRDA BURTI ATRODAMI LIETOTĀJA IEVADĪTAJĀ VĀRDĀ
                // izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
                foreach (char symbol in wordFromDict)
                {
                    // pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
                    if (usersLetters.Contains(symbol) == false)
                    {
                        // ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
                        hasInvalidLetterBeenFound = true;
                    }
                }
                // kad vārdu apstrāde pa burtiem beigusies,
                // pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
                if (hasInvalidLetterBeenFound == false)
                {
                    // ja nav, tad izvadām vārdu uz ekrāna
                    Console.WriteLine(wordFromDict);
                }
                
            }


        }
    }
}
