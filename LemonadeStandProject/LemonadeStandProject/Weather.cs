using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Weather
    {
        public int temperature;
        public string forecast;
        public string todaysWeather;
        public string clear = "Clear & Sunny:";
        public string cloudy = "Cloudy:";
        public string rain = "Raining:";
        public string hazy = "Hazy:";
        
        Random rand = new Random();

        public void randomizeTemperature()
        {
            temperature = rand.Next(0, 4);
            switch (temperature)
            {
                case 1:
                    {
                        Console.WriteLine(clear);
                        forecast = clear;
                        temperature = rand.Next(70, 101);
                        Console.WriteLine(temperature + " degrees");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(cloudy);
                        forecast = cloudy;
                        temperature = rand.Next(50, 76);
                        Console.WriteLine(temperature + " degrees");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine(rain);
                        forecast = rain;
                        temperature = rand.Next(50, 65);
                        Console.WriteLine(temperature + " degrees");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine(hazy);
                        forecast = hazy;
                        temperature = rand.Next(50, 76);
                        Console.WriteLine(temperature + " degrees");
                        break;
                    }
            }
        }

        
    }
}

    //choose to not open stand and play another week due to weather prediction results





