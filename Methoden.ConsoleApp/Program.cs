using System;

namespace Methoden.ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Prints "*" to the Commandline for the committed int-number of times
        /// </summary>
        /// <param name="numberOfStars"></param>
        static string PrintStarsToConsole(int numberOfStars)
        {
            string buildedString="";
            for (int i = 0; i < numberOfStars; i++)
            {
                buildedString += "*";
            }
            return buildedString;
        }
        /// <summary>
        /// Takes to int-numbers and returns the greater one
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns></returns>
        static int GetMaxNumber(int numberOne, int numberTwo)
        {
            int maxValue;
            if (numberOne > numberTwo)
            {
                maxValue = numberOne;
            }
            else
            {
                maxValue = numberTwo;
            }
            return maxValue;
        }

        /// <summary>
        /// Takes two int-numbers to build the nth-power of the first one, the exponen is the second number.
        /// </summary>
        /// <param name="basis"></param>
        /// <param name="exponent"></param>
        /// <returns></returns>
        static int PowerOfNumber(int basis, int exponent)
        {
            int temp = basis;
            for (int i = 0; i < exponent-1; i++)
            {
                basis *= temp; 
            }
            return basis;
        }

        /// <summary>
        /// Takes a string and two int-numbers. Takes a substring out of the committed string, starting at the index of the value of the first int-numbers with a length value of the second int-number
        /// </summary>
        /// <param name="inputString"></param>
        /// <param name="startingPosition"></param>
        /// <param name="substringLength"></param>
        /// <returns></returns>
        static string CreateSubstring(string inputString, int startingPosition, int substringLength)
        {
            string foundSubstring = "";
            for (int i = 0; i < substringLength; i++)
            {
                foundSubstring += (char)(inputString[startingPosition + i]);
            }
            return foundSubstring;
        }

        /// <summary>
        /// Takes two strings. Checks if the second one is part of the first and returns the startposition, else it returns -1
        /// </summary>
        /// <param name="lookUpString">The string where you look up for the substring</param>
        /// <param name="substring"></param>
        /// <returns></returns>
        static int IndexOf(string lookUpString, string substring)
        {
            int index = -1;
            for (int i = 0; i < lookUpString.Length; i++)
            {
                for (int j = 0; j < substring.Length; j++)
                {

                }
            }
            return index;
        }

        static void Main(string[] args)
        {
            string input = "",returnedString;
            string firstMethodCommittedString, secondMethodCommittedString;
            int firstMethodCommittedNumber, secondMethodCommittedNumber;
            int returnedNumber;

            do
            {
                Console.WriteLine("Methodenauswahl");
                Console.WriteLine("===============");
                Console.WriteLine("Bitte aus folgenden Modi auswählen:");
                Console.WriteLine("Sterne ausgeben    <1>");
                Console.WriteLine("Maximum berechnen  <2>");
                Console.WriteLine("Zahlen potenzieren <3>");
                Console.WriteLine("Substring erstellen<4>");
                Console.WriteLine("Substring finden   <5>");
                Console.WriteLine("===============");
                Console.Write("Welcher Modus <'e' zum Beenden>: ");
                input = Console.ReadLine();
                
                //Programmauswahl
                switch (input)
                {
                    case "e":
                        break;
                    case "1":
                        Console.Write("Bitte Anzahl der Sterne eingeben: ");
                        firstMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        returnedString = PrintStarsToConsole(firstMethodCommittedNumber);
                        Console.WriteLine(returnedString);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Write("Bitte 1. Nummer eingeben: ");
                        firstMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte 2. Nummer eingeben: ");
                        secondMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        returnedNumber = GetMaxNumber(firstMethodCommittedNumber, secondMethodCommittedNumber);
                        Console.WriteLine("Die größere Nummer ist {0}", returnedNumber);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Write("Bitte 1. Nummer (Basis) eingeben: ");
                        firstMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte 2. Nummer (Exponent) eingeben: ");
                        secondMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        returnedNumber = PowerOfNumber(firstMethodCommittedNumber, secondMethodCommittedNumber);
                        Console.WriteLine("Die Potenz {0} hoch {1} ist {2}",firstMethodCommittedNumber,secondMethodCommittedNumber,returnedNumber);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Write("Bitte zu durchsuchenden Text eingeben: ");
                        firstMethodCommittedString = Console.ReadLine();
                        Console.Write("Bitte Startindex eingeben: ");
                        firstMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Bitte Länge des Substrings eingeben: ");
                        secondMethodCommittedNumber = Convert.ToInt32(Console.ReadLine());
                        returnedString = CreateSubstring(firstMethodCommittedString,firstMethodCommittedNumber,secondMethodCommittedNumber);
                        Console.WriteLine("Der Substring lautet '{0}' ", returnedString);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "5":
                        Console.Write("Bitte zu durchsuchenden Text eingeben: ");
                        firstMethodCommittedString = Console.ReadLine();
                        Console.Write("Bitte vermuteten Substring eingeben: ");
                        secondMethodCommittedString = Console.ReadLine();
                        returnedNumber = IndexOf(firstMethodCommittedString, secondMethodCommittedString);
                        Console.WriteLine("Startposition des Substrings: {0}", returnedNumber);
                        break;
                    default:
                        Console.Write("Fehlerhafte Eingabe! Zum Fortfahren beliebige Taste drücken ...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            while (input != "e");
        }
    }
}
