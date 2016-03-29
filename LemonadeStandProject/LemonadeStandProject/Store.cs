using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Store
    {
        public double onePoundMixCost = 3.00;
        public double twoPoundMixCost = 5.00;
        public double fivePoundMixCost = 10.00;
        public double moneySpent;
        public int cupsInOnePound = 10;
        public int cupsInTwoPounds = 20;
        public int cupsInFivePounds = 45;
        public int purchaseChoice;
        public int totalCupsForMix = 0;

        public double MixturePurchased()
        {
            Console.WriteLine("What quantity of mixture would you like to purchase?");
            Console.WriteLine("(1) 1 Lb Mix for $3, which is 10 cups and will make 10 pitchers");
            Console.WriteLine("(2) 2 lbs MIx for $5, which is 20 cups and will make 20 pitchers");
            Console.WriteLine("(3) 5 Lbs Mix for $10, which is 45 cups and will make 45 pitchers");
            Console.WriteLine("(4) None at this time");
            purchaseChoice = Convert.ToInt32(Console.ReadLine());

            if (purchaseChoice == 1)
            {
                Console.WriteLine("You have chosen the 1 Lb Mix that will cost " + "$" + onePoundMixCost);
                moneySpent = onePoundMixCost;
                return moneySpent;
            } else if(purchaseChoice == 2)
                {
                Console.WriteLine("You have chosen the 2 Lbs Mix that will cost " + "$" + twoPoundMixCost);
                moneySpent = twoPoundMixCost;
                return moneySpent;

            } else if (purchaseChoice == 3)
                {
                Console.WriteLine("You have chosen the 5 Lbs Mix that will cost " + "$" + fivePoundMixCost);
                moneySpent = fivePoundMixCost;
                return moneySpent;
            }
            else if(purchaseChoice == 4)
            {
                Console.WriteLine("Please revisit when you are ready to purchase merchandise.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid response, try again");
                MixturePurchased();
            }
                return moneySpent;

            //be sure to have if the amount chosen to buy exceeds your money that message saying not allowable
            //create a try catch statement at the end to catch the enter button exception on the choice of bundles
  
        }
        
        public int MixtureTotal()
        {if(moneySpent == 3.00)
            {
                Console.WriteLine("You have added 10 cups to your inventory for the stand.");
                totalCupsForMix += cupsInOnePound;
                            }
            else if (moneySpent == 5.00)
            {
                Console.WriteLine("You have added 20 cups to your inventory for the stand.");
                totalCupsForMix += cupsInTwoPounds;
                            }
            else if (moneySpent == 10.00)
            {
                Console.WriteLine("You have added 45 cups to your inventory for the stand.");
                totalCupsForMix += cupsInFivePounds;
            }
            return totalCupsForMix;
        }
    }
        
        //create a list that holds the purchase items with set price packages
        
    }

