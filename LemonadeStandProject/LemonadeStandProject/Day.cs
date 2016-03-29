using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Day
    {
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
        
        public void TodaysCondition()
        {
            Weather skiesView = new Weather();
            //Customer  
            skiesView.randomizeTemperature();
            Console.WriteLine(skiesView.forecast);
            Console.WriteLine(skiesView.temperature);
        }

        public void PotentialCustomers()
        {
            Weather possibles = new Weather();
            Customer buddies = new Customer();
            buddies.GenerateCustomers(possibles.PassingPeople());
        }   //return or not...how to isolate customers


        /*
        public string OurWeather()
        {
            for(int i = 0; i < 8; i++)
            {
                //break the days out and print each
            }
            return theWeather;
        }
        */
    }

}
