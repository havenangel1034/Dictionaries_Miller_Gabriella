using System;
using System.Collections;
using System.Collections.Generic;

namespace Dictionaries_Miller_Gabriella
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to store top games with ranking as key
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "The Legend of Zelda; Breath of the Wild");
            topGames.Add(2, "Fortnite");
            topGames.Add(3, "Call of Duty");
            topGames.Add(4, "FNAF");
            topGames.Add(5, "Poppy's Playtime");
            topGames.Add(6, "Bendy and the Ink Machine");
            topGames.Add(7, "The Stanley Parable");
            topGames.Add(8, "Genshin Impact");
            topGames.Add(9, "Roblox");
            topGames.Add(10, "Minecraft");

            // Iterating through the dictionary and printing each key-value pair
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}!");
            }

            // Checking if the dictionary contains key 1 and printing the corresponding value
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}!");
            }

            // Attempting to retrieve a value for key 11
            string result = "";
            topGames.TryGetValue(11, out result);

            // Checking if a game exists at key 11 and printing the result
            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position.");
            }

            // Ensuring key 5 exists before updating its value
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Poppy's Playtime";
            }

            // Printing the updated value for key 5
            Console.WriteLine(topGames[5]);

            // Creating a Hashtable from the dictionary
            Hashtable hashTable = new Hashtable(topGames);

            // Retrieving and printing a favorite game from the Hashtable
            string favGame = (string)hashTable[1];
            Console.WriteLine($"Favorite Game: {favGame}!");

            // Creating another Hashtable with additional key-value pairs for state capitals
            Hashtable capitals = new Hashtable(topGames)
            {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin" },
                { "Ohio", "Colombus" },
            };

            // Iterating through the Hashtable and printing each key-value pair
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($" Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // Clearing all entries from the capitals Hashtable
            capitals.Clear();



        }
    }
}