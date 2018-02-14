using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // izsaucam sevis izveidoto funkciju
            SayHello();
            // izsaucam savu otro izveidoto funkciju
            // SayHelloToUser();
        }

        static void SayHelloToUser()
        {
            // palūdzam lietotājam ievadīt savu vārdu
            // uzrakstot lūgumu ekrāna
            Console.WriteLine("Please enter your name:");
            // izveidojam mainīgo, kur glabāt lietotāja ievadīto vērtību
            string usersName;
            // paprasam konsolei ievadīt tekstu, saglabajām rezultātu mainīgajā
            usersName = Console.ReadLine();
            string age;
            Console.WriteLine("Please enter your age:");
            age = Console.ReadLine();
            age = age + 100;
            Console.WriteLine("Labdien," + usersName + "!" + "Tavs vecums ir " + age + "!");// Reinis "Labdien, Reinis!"
            Console.ReadLine();
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, world!");
            Console.ReadLine();
        }
    }
}
