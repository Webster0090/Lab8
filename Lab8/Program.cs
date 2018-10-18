using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 4;)
            {
                try
                {

                    Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0-18):");
                    int userInput = int.Parse(Console.ReadLine());
                    StudentFacts(userInput);
                    Console.WriteLine("Would you like to know more? (y/n)");
                    string userContinue = Console.ReadLine();
                    if (userContinue == "n")
                    {
                        return;
                    }
                }

                  catch (FormatException)
                {
                    Console.WriteLine("This is not valid input");
                }
            }
        }
        public static void StudentFacts(int userInput)
        {
            string[,] studentFacts = new string[19, 3]
            {
                {"Andrea", "Rochester Hills, MI", "Hop Cat Crack Fries"},
                {"Anthony", "Harrison, MI", "Broderick Grille"},
                { "Brian", "West Bloomfield, MI", "Italian Beef"},
                { "Camille", "Pontiac, MI", "Mac and Cheese"},
                { "Clayton", "Indy", "Dairy Queen"},
                { "Mace", "Detroit, MI", "Chicken Nuggets"},
                { "David", "Warren, MI", "Pizza"},
                { "Evan", "Toledo, OH", "BEEF!" },
                { "Heather", "Lansing", "Pizza"},
                { "Jacky", "Detroit, MI", "Raw fish"},
                { "Johnathan", "Brighton, MI", "Korean Food"},
                { "Katie", "Downriver", "Lasagna"},
                { "Levi", "Detroit, MI", "Pizza"},
                { "Mauricio", "Yipsi", "Grilled Chicken"},
                { "Nicholas", "Ann Arbor, MI", "Coney Island"},
                { "Rudy", "Detroit, MI", "Veggies"},
                { "Sean O", "Flint, MI", "Pasta"},
                { "Steve", "Toledo, OH", "Pizza"},
                { "Ty", "Holly, MI", "Pasta"},
            };
            try
            {
                Console.WriteLine(studentFacts[userInput, 0]);
                Console.WriteLine("What would you like to know about? The students hometown or favorite food?");
                string fact = Console.ReadLine().ToLower();
                if (fact == "hometown")
                {
                    Console.WriteLine(studentFacts[userInput, 1]);
                }
                else if (fact == "favorite food")
                {
                    Console.WriteLine(studentFacts[userInput, 2]);
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Please try again");
            }
        }
    }    
 }

