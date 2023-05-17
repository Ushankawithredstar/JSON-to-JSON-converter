using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace json_to_json_converter
{
    public class Converter
    {
        JsonDataManager jsonDataManager = new();

        public void ParseTweetData()
        {
            //Read JSON from file
            string tweetFromOldJson = File.ReadAllText(Directory.GetCurrentDirectory() + "/tweets.json"); 

            var objects = JArray.Parse(tweetFromOldJson); //Parses as array  


            foreach(JObject root in objects)
            {

                foreach(KeyValuePair<String, JToken> app in root)
                {
                    var fullTweet = (String)app.Value["full_text"]; //Only store the tweet in the string.
                    string? data = fullTweet.ToString();

                    //Filters out retweets.
                    if (Regex.IsMatch(data, "RT "))
                        data = " ";
                    
                    if (data != " ")
                        jsonDataManager.AddDataToList(data);
                }
            }
            jsonDataManager.SaveTweets();
        }
    }
}