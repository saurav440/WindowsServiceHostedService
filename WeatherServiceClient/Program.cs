using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WeatherServiceClient client = new ServiceReference1.WeatherServiceClient();
            Console.WriteLine("Celcius to Farenheit-:");

            Console.WriteLine("Tempeture in Farenheit: {0}", client.CelciusToFarenheit(Convert.ToDouble(Console.ReadLine())));

            Console.WriteLine("**************************");

            Console.WriteLine("Farenheit to Celcius-");

            Console.WriteLine("Tempeture in Celcius: {0}", client.FarenheitToCelcius(Convert.ToDouble(Console.ReadLine())));
        }
    }
}
