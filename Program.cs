using System.Text.Json;

namespace json_to_json_converter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Converter converter = new();

            Console.WriteLine("Press any key to start.");
            Console.ReadKey();
            Console.WriteLine("Starting conversion...");

            converter.ParseTweetData();

            Console.WriteLine("Finished!\nPress any key to exit the program.");
            Console.ReadKey();
        }
    }
}