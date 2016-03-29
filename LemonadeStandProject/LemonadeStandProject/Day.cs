using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
        //public string day1;
        //public string day2;
        //public string day3;
        //public string day4;
        //public string day5;
        //public string day6;
        //public string day7;
        public string dayForecast;
        public int dayTemperature;
        public string theWeather;
        public int visitors;


        public Day(string DayForecast, int DayTemperature, int Visitors)
        {
            dayForecast = DayForecast;
            dayTemperature = DayTemperature;
            visitors = Visitors;
        }



        public string OurWeather()
        {
            for(int i = 0; i < 8; i++)
            {
                //break the days out and print each
            }
            return theWeather;
        }
    }

}
