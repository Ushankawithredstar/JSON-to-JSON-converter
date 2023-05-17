using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace json_to_json_converter
{
    public class JsonDataManager
    {
        public List<string> _data = new List<string>();

        public void AddDataToList(string data)
        {
            _data.Add(data);
            Console.WriteLine(data);
        }

        public void SaveTweets()
        {
            string tweetToNewJson = JsonConvert.SerializeObject(_data, Formatting.Indented);
            File.WriteAllText(Directory.GetCurrentDirectory() + "/only_tweets.json", tweetToNewJson);
        }
    }
}