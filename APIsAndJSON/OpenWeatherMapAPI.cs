using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static void Weather(string cityname)
        {
            var client = new HttpClient();

            var city = cityname;
            var key = "c8751ce973594af2bed7f5ad6b9c57f5";

            var weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={city}&units=imperial&appid={key}";

            var response = client.GetStringAsync(weatherURL).Result;

            var formattedResponse = JObject.Parse(response).GetValue("main").ToString();

            var temp = JObject.Parse(formattedResponse).GetValue("temp");

            Console.WriteLine($"The current temperature in {city} is {temp} degrees Fahrenheit.");
        }

    }
}
