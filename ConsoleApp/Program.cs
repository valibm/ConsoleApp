using System;
using ConsoleApp.Models;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexer<Gun> guns = new Indexer<Gun>();
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to Darkhill shooting range !");
            Menu:
            Console.WriteLine("Press 1 to choose a weapon from our inventory or create one for yourself.");
            
            string input = GetInput<string>("answer");

            switch (input)
            {
                case "1":
                    PrintGuns();
                    break;
                default:
                    goto Menu;
            }
        }
        public static string GetStringInput(string output)
        {
            TryAgain:
            Console.WriteLine("Please enter a {0}", output);
            string input = Console.ReadLine().Trim();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid Input!\nPlease try again.");
                goto TryAgain; 
            }
            return input;
        }
        public static T GetInput<T> (string output)
        {
            TryAgain:
            Console.WriteLine("Please enter a {0}", output);
            string input = Console.ReadLine().Trim();
            T convertedInput;
            try
            {
                convertedInput = (T)Convert.ChangeType(input, typeof(T));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input!\nPlease try again.");
                goto TryAgain;
            }
            return convertedInput;
        } 
        public static Gun CreateGun()
        {
            string name = GetInput<string>("name");
            string kind = GetInput<string>("kind");

            return new Gun(name, kind);
        }
        public static void PrintGuns()
        {
            Indexer<Gun> guns = new Indexer<Gun>();
            Pistol glock = new Pistol("Pistol", "Glock");
            Pistol dEagle = new Pistol("Pistol", "Desert Eagle");
            Pistol revolver = new Pistol("Pistol", "Revolver");
            guns.Add(glock);
            guns.Add(dEagle);
            guns.Add(revolver);
            foreach (var item in guns)
            {
                Console.WriteLine(item.ToString());
            }
        } 
    }
}
