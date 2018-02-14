using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    using System.Runtime.InteropServices;

    class Program
    {
        static void Main(string[] args)
        {
            // CalculateCircleArea();
            // Ctrl + K D
            // turot Ctrl, spiežam K un tad D
            CountTwoNumbersTogether();
        }

        static void CountTwoNumbersTogether()
        {
            // izveidojam mainīgo, kur glabāt lietotāja ievadīto pirmo skaitli
            double firstNumber;
            // izsaucam skaitļa iegūšanas funkciju, rezultātu ierakstam mainīgajā
            firstNumber = GetNumberFromUser("lūdzu ievadiet pirmo skaitli");
            // izveidojam mainīgo, kur glabāt lietotāja ievadīto otro skaitli 
            double secondNumber;
            // izsaucam skaitļa iegūšanas funkciju, rezultātu ierakstam mainīgajā
            secondNumber = GetNumberFromUser("tagad ievadiet otro skaitli");
            // izveidojam mainīgo, kurā glabāt rezultātu
            double result;
            // aprēķinām rezultātu un ierakstam mainīgajā
            result = firstNumber + secondNumber;
            Console.WriteLine("aprēķina rezultāts: " + result);
            Console.ReadLine();
        }

        static void CalculateCircleArea()
        {
            // izveidojam mainīgo, kur glabāt rādiusu
            double radius;
            // izveidosim mainīgo, kur glabāt rezultātu
            double result;
            // piešķirsim rādiusa mainīgajam vērtību
            radius = GetNumberFromUser("lūdzu ievadiet rādiusu");
            // veicam apreķināšanas operāciju
            result = radius * radius * 3.14;
            // parādam rezultātu lietotājam
            Console.WriteLine("Rezultāts: " + result);
            Console.ReadLine();
        }

        static double GetNumberFromUser(string msg)
        {
            // izvadam funkcijai iedoto paziņojumu
            Console.WriteLine(msg);
            // nolasām lietotāja ievadi no ekrāna un ierakstam teksta mainīgajā
            string textInput = Console.ReadLine();
            // izveidojam mainīgo, kur glabāt apaļo skaitli
            double parsedNumber;
            // pārveidojam ievadīto tekstu par skaitli un ierakstam mainīgajā
            bool parseWasSuccess = double.TryParse(textInput, out parsedNumber);
            if (parseWasSuccess == false)
            {
                Console.WriteLine("slikti ievadīts skaitlis \"" + textInput + "\"");
                Console.WriteLine("ievadi skaitli vēlreiz");
                parsedNumber = GetNumberFromUser(msg);
            }
            else
            {
                Console.WriteLine("brīnišķīgi ievadīts skaitlis");
            }
            return parsedNumber;
        }
    }
}
