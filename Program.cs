using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TweetManager;

namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            TweetManagerFile tm = new TweetManagerFile();

            do
            {
                Console.WriteLine("------Main Menu-----");
                Console.WriteLine();
                Console.WriteLine("1. View All Tweets");
                Console.WriteLine("2. Post New Tweet");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Exit");


                choice = Console.ReadLine();
                Console.WriteLine($"You entered {choice}");
                if (choice == "1")
                {
                    for (int i = 0; i < tm.TweetCounter(); i++)
                    {
                        Console.WriteLine($"Your tweet #{i+1} is '{tm.GetTweets()[i]}' ");
                    }   
                }
                if (choice == "2") {
                    Console.Write("Enter your tweet: ");
                    string tweet = Console.ReadLine();
                    string msg = tm.PostTweet(tweet);
                    Console.WriteLine(msg);
                }
                if (choice == "3") {
                    Console.WriteLine("Enter search term: ");
                    string search = Console.ReadLine();
                    List<string> results = tm.Search(search);
                    Console.WriteLine("Found " + results.Count + " tweets.");
                }
            }
            while (choice != "4");

        }
    }
}
