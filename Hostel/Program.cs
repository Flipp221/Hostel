// OpenWeatherMap REST API example
// DKY 2021

using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Hostel
{
    class Program
    {
        static void Main(string[] args)
        {
            var ApiKey = "0698c10ec8c2ee9d51be29d9c9886757";
            var url = $"https://apidata.mos.ru/v1/datasets/2343/rows?api_key={ApiKey} ";

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
                var hostel = JsonConvert.DeserializeObject<Root>(result);
                Console.WriteLine(Hostel.main.temp);
            }

        }
    }
}
