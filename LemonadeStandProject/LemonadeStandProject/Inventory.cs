using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Inventory
    {
        public int cupsOfMixLeft;
        public double starterMoney = 20.00;
        public double moneyBalance;
        public int decreasedMixtureCount;
        public int recipeUsed;
        public int currentMixCount;

        public double CalculateBalance()
        {
            Store storePurchase = new Store();
            Customer buyingCustomer = new Customer();
            starterMoney -= storePurchase.moneySpent += buyingCustomer.moneyTakenIn;
            return moneyBalance;
        }

        public int PitchersMade()
        {
            Console.WriteLine("How many pitchers of lemonade would you like to make today?");
            Console.ReadLine();
            return decreasedMixtureCount;
            //be sure to have if the amount chosen to make exceeds the amount remaining that message saying not allowable
        }
        
        public int CalculateMixLeft()
        {
            Store scoopsBought = new Store();
            scoopsBought.totalCupsForMix += cupsOfMixLeft;
            cupsOfMixLeft -= decreasedMixtureCount;
            return cupsOfMixLeft;
        }

        
        //      https://www.omsi.edu/exhibitions/moneyville/activities/lemonade/lemonadestand.htm
        //      http://www.coolmath-games.com/0-lemonade-stand
        //create function that captures remaining items over the course of days played and purchases made
        //create function that returns end of game if reach certain amount

    }
}
