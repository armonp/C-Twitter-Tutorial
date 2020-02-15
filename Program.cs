using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitter_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("------Main Menu-----");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post New Tweet");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();

                Console.WriteLine($"You entered {choice}");

                Console.ReadLine();
            }
            while (choice != "3");

            Console.ReadLine();

            //string[] tweets = new string[4];
            //for(int i = 0; i < tweets.Length; i++)
            //{

            //    Console.Write("Enter tweet #{0}: ", i+1);
            //    tweets[i] = Console.ReadLine();

            //}

            //Console.WriteLine("Tweet Posted Successfully");
            //Console.WriteLine();
            //Console.WriteLine("Your tweets are: ");
            //for (int i = 0; i < tweets.Length; i++) {

            //    if (tweets[i].Length > 140 )
            //        Console.WriteLine("Tweet is longer than 140 characters");
            //    else
            //        Console.WriteLine("Your tweet #{0} is '{1}' ", i + 1, tweets[i]);
            
            //}
            //Console.ReadLine();
        }
    }
}
