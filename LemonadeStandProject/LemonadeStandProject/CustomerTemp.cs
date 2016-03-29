using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class CustomerTemp
    {
        public double moneySpent;
        public bool lemonadePurchase;
        public int mood;

        public CustomerTemp(int Mood)
        {
            mood = Mood;
        }

        //create sub classes for thirsty, cheap, generous who will purchase according to weather and price differences
        //thirsty make up 60% in A weather; 60% in B weather ; 55% in C weather
        //cheap make up 15% in A weather; 10% in B ground weather ; 5% in C weather
        //generous make up 25% in A weather; 30% in B ground weather ; 40% in C weather
        //use AI with a quantity choice from select range and go into a list of customers
        //in function give option of purchasing more than one cup based on budget and purchase tendancy?
        //if mood is set, this will allow for separation of created instances and adding integer that increases to end going into list

        
        /* for sub class generation of customer objects
        
        public List<Robot> CreateRobots(int numberOfRobots)
        {
            Random rand = new Random();
            List<Robot> robots = new List<Robot>();
            for (int i = 0; i < numberOfRobots; i++)
            {
                robots.Add(new Robot(rand.Next(0, 4)));
            }
            return robots;
        }   
        */

    }
}
