using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                RonAndKanye.KanyeQuote();
                RonAndKanye.RonQuote();
            }

            var usingWeather = true;

            do
            {
                Console.WriteLine("Enter a city name (case sensitive):");
                var city = Console.ReadLine();
                OpenWeatherMapAPI.Weather(city);
                Console.WriteLine("Are you finished using the weather functions? (y/n)");
                var complete = Console.ReadLine().ToLower();
                switch (complete)
                {
                    case "y": usingWeather = false; break;
                    case "n": usingWeather = true; break;
                }

            } while (usingWeather == true);
            
        }
    }
}
