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
        public int numberOfVisitors;
        public int purchasingCustomers;
        public int numberofCupsBought;
        public double moneyTakenIn;

        public Day(string DayForecast, int DayTemperature, int Visitors)
        {
            dayForecast = DayForecast;
            dayTemperature = DayTemperature;
            visitors = Visitors;
        }

     
        public int CustomerChanceToBuy()
        {
            Customer buddies = new Customer();
            Stand ourCupPricing = new Stand();

            buddies.GenerateCustomers(CustomerCountByWeather());
            //for loop
            if(buddies.goodMood >= 5 && ourCupPricing.lemonadeCupCharge < .75)
            {
                //buy
                return purchasingCustomers;
            }
            if(buddies.goodMood >= 5 && ourCupPricing.lemonadeCupCharge >= .75)
            {
                //pass
            }
            if (buddies.goodMood >= 5 && ourCupPricing.lemonadeCupCharge < .35)
            {
                Console.WriteLine("Great price!");
            }
            if (buddies.goodMood < 5 && ourCupPricing.lemonadeCupCharge < .35)
            {
                //buy
                return purchasingCustomers;
            }
            if (buddies.goodMood < 5 && ourCupPricing.lemonadeCupCharge >= .35)
            {
                //pass
            }
            return purchasingCustomers;
        }  
        

        public List<string> buyingCustomers = new List<string>();
        public List<string> notBuyingCustomers = new List<string>();

        public int CustomerCountByWeather()
        {
            Random rand = new Random();
            Weather weather1 = new Weather();
            
            if (weather1.forecast == weather1.clear)
            {
                numberOfVisitors = rand.Next(45, 66);
                return numberOfVisitors;
            }
            else if (weather1.forecast == weather1.cloudy)
            {
                numberOfVisitors = rand.Next(30, 45);
                return numberOfVisitors;
            }
            else if (weather1.forecast == weather1.rain)
            {
                numberOfVisitors = rand.Next(15, 30);
                return numberOfVisitors;
            }
            else if (weather1.forecast == weather1.hazy)
            {
                numberOfVisitors = rand.Next(30, 45);
                return numberOfVisitors;
            }
            return numberOfVisitors;
        }

        /*
        public double BuyCupLemonade()
        {
            numberofCupsBought = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(lemonadeCupCharge * numberofCupsBought);
            return moneyTakenIn;
        }
            */
        public void MoneyIntakeForDay()
        {
            
        }
        
    }

}
