using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

namespace SharpHeroAPI
{
    public class SuperHeroClient
    {
        private string apiKey;
        private WebClient client = new WebClient();

        /// <summary>
        /// Create a new instance of the SuperHero API client.
        /// </summary>
        /// <param name="apiKey">This is your api key. To get your own key visit https://superheroapi.com/index.html sign up with FaceBook</param>
        public SuperHeroClient(string apiKey)
        {
            this.apiKey = apiKey;
        }

        /// <summary>
        /// Returns a list of characters for the given input (the name of the character). If the function returns nothing then there were no results found.
        /// </summary>
        /// <param name="characterName">The name of the character to search for.</param>
        /// <returns></returns>
        public List<Character> SearchByName(string characterName)
        {
            List<Character> results = new List<Character>();

            string link = "https://www.superheroapi.com/api.php/" + apiKey + "/search/" + characterName;
            string json = client.DownloadString(link);
            json = json.Replace("-", string.Empty);
            CharacterResults hero;
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(CharacterResults));
                hero = (CharacterResults)deserializer.ReadObject(ms);
            }

            if (hero.response != "success")
            {
                throw new Exception("The search did not yield any results.");
            }
            else
            {
                return hero.results;
            }
        }

        /// <summary>
        /// Returns the character assigned to the input ID.
        /// </summary>
        /// <param name="id">The ID of the character to search for.</param>
        /// <returns></returns>
        public Character SearchById(int id)
        {
            string link = "https://www.superheroapi.com/api.php/" + apiKey + "/" + id;
            string json = client.DownloadString(link);
            json = json.Replace("-", string.Empty);
            Character hero;
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(Character));
                hero = (Character)deserializer.ReadObject(ms);
            }

            if (hero.response != "success")
            {
                throw new Exception("Could not find any characters with that ID.");
            }
            else
            {
                return hero;
            }
        }
    }
}
