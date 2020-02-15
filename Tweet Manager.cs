using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterConsole
{
    class TweetManager {
        string[] tweets = new string[10];
        int tweetCounter = 0;
        public string PostTweet(string tweet) {
            if (tweet.Length > 240)
                return "Error: Tweet is longer than 240 characters.";


            if (tweetCounter >= tweets.Length)
                return "Error: Max tweets reached.";

            tweets[tweetCounter++] = tweet;
            return "Tweet posed successfully";
        }
        public int TweetCounter () {
            return tweetCounter;
        }
        public string[] GetTweets() {
            return tweets;
        }
    }
}
