using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandProject
{
    public class Stand
    {
        public double onePoundMixCost = -3.00;
        public double twoPoundMixCost = -5.00;
        public double fivePoundMixCost = -10.00;
        public double invoiceCost;
        public double startMoney = 20.00;
        public double moneyBalance;
        public int cupsLeftOfMix;
        public int cupsInOnePound = 10;
        public int cupsInTwoPounds = 20;
        public int cupsInFivePounds = 45;
        public int purchaseChoice;
        public int totalCupsSold;
        public int cupsOfMixLeft;
        public int decreasedMixtureCount;
        public double lemonadeCupCharge;

        public double StoreSellPrice()
        {
            Console.WriteLine("What quantity of mixture did you purchase?");
            Console.WriteLine("(1) 1 Lb Mix for $3, which is 10 cups of mix and will make 10 pitchers");
            Console.WriteLine("(2) 2 lbs MIx for $5, which is 20 cups of mix and will make 20 pitchers");
            Console.WriteLine("(3) 5 Lbs Mix for $10, which is 45 cups of mix and will make 45 pitchers");
            Console.WriteLine("(4) None at this time");
            purchaseChoice = Convert.ToInt32(Console.ReadLine());

            if (purchaseChoice == 1)
            {
                Console.WriteLine("You have chosen the 1 Lb Mix that will adjusted " + "$" + onePoundMixCost + " on your money balance.");
                invoiceCost = onePoundMixCost;
                return invoiceCost;
            }
            else if (purchaseChoice == 2)
            {
                Console.WriteLine("You have chosen the 2 Lbs Mix that will adjusted " + "$" + twoPoundMixCost + " on your money balance.");
                invoiceCost = twoPoundMixCost;
                return invoiceCost;

            }
            else if (purchaseChoice == 3)
            {
                Console.WriteLine("You have chosen the 5 Lbs Mix that will adjusted " + "$" + fivePoundMixCost + " on your money balance.");
                invoiceCost = fivePoundMixCost;
                return invoiceCost;
            }
            else if (purchaseChoice == 4)
            {
                Console.WriteLine("Maybe you need to purchase merchandise.");
            }
            else
            {
                Console.WriteLine("You have entered an invalid response, try again");
                StoreSellPrice();
            }
            return invoiceCost;

            
            //create a try catch statement at the end to catch the enter button exception on the choice of bundles
        }

        public int SetIngredientsQuantities()
        {

            if (invoiceCost == -3.00)
            {
                Console.WriteLine("You have added 10 cups of mix to your inventory for the stand.");
                totalCupsSold += cupsInOnePound;
                return totalCupsSold;
            }
            else if (invoiceCost == -5.00)
            {
                Console.WriteLine("You have added 20 cups of mix to your inventory for the stand.");
                totalCupsSold += cupsInTwoPounds;
                return totalCupsSold;
            }
            else if (invoiceCost == -10.00)
            {
                Console.WriteLine("You have added 45 cups of mix to your inventory for the stand.");
                totalCupsSold += cupsInFivePounds;
                return totalCupsSold;
            }
            return totalCupsSold;
        }
        public double CheckBalance()
        {
            moneyBalance = startMoney;
            moneyBalance += invoiceCost;
            return moneyBalance;
        }

        
        public double CheckStock()
        {
            cupsLeftOfMix += totalCupsSold;
            return cupsLeftOfMix;
        }
          
        public int MixtureUsage()
        {
            
            Console.WriteLine("Note: One pitcher will make 10 cups of lemonade.");
            Console.WriteLine("You currently have " + CheckStock() + " " + "cups of mixture to use.");
            Console.WriteLine("Your remaining money is: " + "$" + moneyBalance);
            Console.ReadLine();
            Console.WriteLine("How many pitchers of lemonade would you like to make today?");
            decreasedMixtureCount = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            if (decreasedMixtureCount <= cupsOfMixLeft)
            {
                Console.WriteLine("You have made " + decreasedMixtureCount + " pitchers of lemonade.");
            }
            else
            {
                Console.WriteLine("Try to make less pitchers, you don't have enough mixture.");
                MixtureUsage();
            }
            return decreasedMixtureCount;
            
        }

        public double SetCupSellPrice()
        {
            Console.WriteLine("How much will you sell a cup of lemonade for?");
            lemonadeCupCharge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The lemonade stand is now open...Ice cold lemonade for sale at " + "$" + lemonadeCupCharge + " " + "a cup!!!");
            Console.WriteLine("----People have begun to walk pass the stand----");
            Console.ReadLine();
            return lemonadeCupCharge;
        }


    }
        
                
    }

