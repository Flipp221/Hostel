// OpenWeatherMap REST API example
// DKY 2021

using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace OpenWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var ApiKey = "Your API Key";
            var url = $"https://api.openweathermap.org/data/2.5/weather?appid={ApiKey}&q={City}&units=metric";

            var request = WebRequest.Create(url);

            var response = request.GetResponse();
            var httpStatusCode = (response as HttpWebResponse).StatusCode;

            if (httpStatusCode != HttpStatusCode.OK)
            {
                Console.WriteLine(httpStatusCode);
                return;
            }

            using (var streamReader = new StreamReader(response.GetResponseStream()))
            {
                string result = streamReader.ReadToEnd();
                Console.WriteLine(result);
                var weatherForecast = JsonConvert.DeserializeObject<Root>(result);
                Console.WriteLine(weatherForecast.main.temp);
            }

        }
    }
}