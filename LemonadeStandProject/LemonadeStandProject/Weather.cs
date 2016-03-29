﻿using System;
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

        //string[] dayConditions = new string[4] { "Clear & Sunny", "Cloudy", "Rain", "Hazy" };
        Random rand = new Random();

        /*public string randomizeForecast()
        {
            forecast = dayConditions[rand.Next(0, forecast.Count())];
            Console.WriteLine("The forecast is " + forecast + " " + "for the day.");
            return forecast;
        }*/

        public int randomizeTemperature()
        {
            temperature = rand.Next(0, 4);
            switch (temperature)
            {
                case 1:
                    {
                        Console.WriteLine(clear);
                        temperature = rand.Next(70, 101);
                        Console.WriteLine(temperature + " degrees");
                        return temperature;
                    }
                case 2:
                    {
                        Console.WriteLine(cloudy);
                        temperature = rand.Next(50, 76);
                        Console.WriteLine(temperature + " degrees");
                        return temperature;
                    }
                case 3:
                    {
                        Console.WriteLine(rain);
                        temperature = rand.Next(50, 65);
                        Console.WriteLine(temperature + " degrees");
                        return temperature;
                    }
                case 4:
                    {
                        Console.WriteLine(hazy);
                        temperature = rand.Next(50, 76);
                        Console.WriteLine(temperature + " degrees");
                        return temperature;
                    }
                    
            }
            return temperature;
            
        }



        /*public string todaysPrediction()
        {
            Console.WriteLine("Today's it is " + forecast + " " + "with a temperature of " + temperature + " " + "degrees.");
            return todaysWeather;
        }*/
        

        

    }

    //A (clear & sunny) weather will bring 45 to 65 people pass and is 60-100 degrees 
    //B (cloudy) or (hazY) weather will bring 30 to 44 people pass and is 50-75 degrees  
    //C (rain) weather will bring 15 to 29 people pass and is 50-75 degrees    


    //choose to not open stand and play another week due to weather prediction results
}



